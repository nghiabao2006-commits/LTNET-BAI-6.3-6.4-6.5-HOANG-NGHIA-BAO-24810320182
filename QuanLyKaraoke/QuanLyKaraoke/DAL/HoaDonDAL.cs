using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.DAL
{
    public class HoaDonDAL
    {
        public List<HoaDon> GetAll()
        {
            List<HoaDon> danhSach = new List<HoaDon>();
            string sql = @"
                SELECT hd.MaHD, hd.MaPhong, p.TenPhong, hd.GioVao, hd.GioRa,
                       hd.TongTienPhong, hd.TongTienDichVu, hd.TrangThai
                FROM HoaDon hd
                JOIN PhongHat p ON p.MaPhong = hd.MaPhong
                ORDER BY hd.MaHD DESC";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(DocHoaDon(reader));
                }
            }
            return danhSach;
        }

        public HoaDon GetDangMo(int maPhong)
        {
            string sql = @"
                SELECT TOP 1 hd.MaHD, hd.MaPhong, p.TenPhong, hd.GioVao, hd.GioRa,
                       hd.TongTienPhong, hd.TongTienDichVu, hd.TrangThai
                FROM HoaDon hd
                JOIN PhongHat p ON p.MaPhong = hd.MaPhong
                WHERE hd.MaPhong = @MaPhong AND hd.TrangThai = 0
                ORDER BY hd.MaHD DESC";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DocHoaDon(reader);
                    }
                }
            }
            return null;
        }

        // Dùng SqlDataAdapter + DataTable để đổ danh sách dịch vụ đã gọi lên lưới.
        public DataTable GetChiTietTable(int maHD)
        {
            string sql = @"
                SELECT ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia,
                       ct.SoLuong * ct.DonGia AS ThanhTien
                FROM ChiTietDichVu ct
                JOIN DichVu dv ON dv.MaDV = ct.MaDV
                WHERE ct.MaHD = @MaHD
                ORDER BY dv.TenDV";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
            {
                adapter.SelectCommand.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Gọi thêm dịch vụ: kiểm tra tồn kho rồi cộng dồn số lượng, cập nhật tổng tiền dịch vụ.
        public void GoiDichVu(int maHD, int maDV, int soLuong)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    bool daThanhToan;
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT TrangThai FROM HoaDon WITH (UPDLOCK) WHERE MaHD = @MaHD", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        object ketQua = cmd.ExecuteScalar();
                        if (ketQua == null)
                        {
                            throw new Exception("Không tìm thấy hóa đơn.");
                        }
                        daThanhToan = Convert.ToBoolean(ketQua);
                    }

                    if (daThanhToan)
                    {
                        throw new Exception("Hóa đơn đã thanh toán, không thể gọi thêm dịch vụ.");
                    }

                    string tenDV;
                    decimal donGia;
                    int tonKho;

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT TenDV, DonGia, TonKho FROM DichVu WHERE MaDV = @MaDV", conn, trans))
                    {
                        cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                throw new Exception("Không tìm thấy dịch vụ.");
                            }
                            tenDV = reader["TenDV"].ToString();
                            donGia = Convert.ToDecimal(reader["DonGia"]);
                            tonKho = Convert.ToInt32(reader["TonKho"]);
                        }
                    }

                    int daGoi;
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT ISNULL(SoLuong, 0) FROM ChiTietDichVu
                          WHERE MaHD = @MaHD AND MaDV = @MaDV", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                        object ketQua = cmd.ExecuteScalar();
                        daGoi = ketQua == null || ketQua == DBNull.Value ? 0 : Convert.ToInt32(ketQua);
                    }

                    if (daGoi + soLuong > tonKho)
                    {
                        throw new Exception("Dịch vụ \"" + tenDV + "\" chỉ còn " + tonKho
                            + " trong kho (đã gọi " + daGoi + ").");
                    }

                    int soDong;
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE ChiTietDichVu SET SoLuong = SoLuong + @SoLuong
                          WHERE MaHD = @MaHD AND MaDV = @MaDV", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                        soDong = cmd.ExecuteNonQuery();
                    }

                    if (soDong == 0)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            @"INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia)
                              VALUES (@MaHD, @MaDV, @SoLuong, @DonGia)", conn, trans))
                        {
                            cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                            cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = donGia;
                            cmd.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE HoaDon
                          SET TongTienDichVu =
                              (SELECT ISNULL(SUM(SoLuong * DonGia), 0)
                               FROM ChiTietDichVu WHERE MaHD = @MaHD)
                          WHERE MaHD = @MaHD", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // Thanh toán: tính tiền phòng theo giờ, trừ kho dịch vụ, đóng hóa đơn và trả phòng trong transaction.
        public HoaDon ThanhToan(int maHD)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int maPhong;
                    string tenPhong;
                    DateTime gioVao;
                    decimal giaTheoGio;

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT hd.MaPhong, p.TenPhong, hd.GioVao, hd.TrangThai, p.GiaTheoGio
                          FROM HoaDon hd WITH (UPDLOCK, HOLDLOCK)
                          JOIN PhongHat p ON p.MaPhong = hd.MaPhong
                          WHERE hd.MaHD = @MaHD", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                throw new Exception("Không tìm thấy hóa đơn.");
                            }
                            if (Convert.ToBoolean(reader["TrangThai"]))
                            {
                                throw new Exception("Hóa đơn này đã được thanh toán.");
                            }

                            maPhong = Convert.ToInt32(reader["MaPhong"]);
                            tenPhong = reader["TenPhong"].ToString();
                            gioVao = Convert.ToDateTime(reader["GioVao"]);
                            giaTheoGio = Convert.ToDecimal(reader["GiaTheoGio"]);
                        }
                    }

                    List<KeyValuePair<int, int>> chiTiet = new List<KeyValuePair<int, int>>();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT MaDV, SoLuong FROM ChiTietDichVu WITH (UPDLOCK) WHERE MaHD = @MaHD", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                chiTiet.Add(new KeyValuePair<int, int>(
                                    Convert.ToInt32(reader["MaDV"]),
                                    Convert.ToInt32(reader["SoLuong"])));
                            }
                        }
                    }

                    foreach (KeyValuePair<int, int> dong in chiTiet)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            @"UPDATE DichVu SET TonKho = TonKho - @SoLuong
                              WHERE MaDV = @MaDV AND TonKho >= @SoLuong", conn, trans))
                        {
                            cmd.Parameters.Add("@MaDV", SqlDbType.Int).Value = dong.Key;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = dong.Value;
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                throw new Exception("Dịch vụ mã " + dong.Key + " không đủ tồn kho để thanh toán.");
                            }
                        }
                    }

                    decimal tongTienDichVu;
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT ISNULL(SUM(SoLuong * DonGia), 0) FROM ChiTietDichVu
                          WHERE MaHD = @MaHD", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        tongTienDichVu = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    DateTime gioRa = DateTime.Now;
                    double soPhut = (gioRa - gioVao).TotalMinutes;
                    int soGio = (int)Math.Ceiling(soPhut / 60.0);
                    if (soGio < 1)
                    {
                        soGio = 1;
                    }
                    decimal tongTienPhong = soGio * giaTheoGio;

                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE HoaDon
                          SET GioRa = @GioRa, TongTienPhong = @TongTienPhong,
                              TongTienDichVu = @TongTienDichVu, TrangThai = 1
                          WHERE MaHD = @MaHD AND TrangThai = 0", conn, trans))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;
                        cmd.Parameters.Add("@GioRa", SqlDbType.DateTime).Value = gioRa;
                        cmd.Parameters.Add("@TongTienPhong", SqlDbType.Decimal).Value = tongTienPhong;
                        cmd.Parameters.Add("@TongTienDichVu", SqlDbType.Decimal).Value = tongTienDichVu;
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            throw new Exception("Hóa đơn đã được thanh toán bởi người khác.");
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE PhongHat SET TrangThai = N'Trống' WHERE MaPhong = @MaPhong", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();

                    return new HoaDon
                    {
                        MaHD = maHD,
                        MaPhong = maPhong,
                        TenPhong = tenPhong,
                        GioVao = gioVao,
                        GioRa = gioRa,
                        TongTienPhong = tongTienPhong,
                        TongTienDichVu = tongTienDichVu,
                        TrangThai = true
                    };
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        private HoaDon DocHoaDon(SqlDataReader reader)
        {
            return new HoaDon
            {
                MaHD = Convert.ToInt32(reader["MaHD"]),
                MaPhong = Convert.ToInt32(reader["MaPhong"]),
                TenPhong = reader["TenPhong"].ToString(),
                GioVao = Convert.ToDateTime(reader["GioVao"]),
                GioRa = reader["GioRa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["GioRa"]),
                TongTienPhong = Convert.ToDecimal(reader["TongTienPhong"]),
                TongTienDichVu = Convert.ToDecimal(reader["TongTienDichVu"]),
                TrangThai = Convert.ToBoolean(reader["TrangThai"])
            };
        }
    }
}
