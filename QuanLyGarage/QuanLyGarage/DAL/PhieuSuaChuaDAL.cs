using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyGarage.DTO;

namespace QuanLyGarage.DAL
{
    public class PhieuSuaChuaDAL
    {
        public List<PhieuSuaChua> GetAll()
        {
            List<PhieuSuaChua> danhSach = new List<PhieuSuaChua>();
            string sql = @"
                SELECT p.MaPhieu, p.BienSo, p.NgayNhan, p.NoiDungSua, p.TongTien, p.TrangThai,
                       kh.TenKH
                FROM PhieuSuaChua p
                JOIN Xe x ON x.BienSo = p.BienSo
                JOIN KhachHang kh ON kh.MaKH = x.MaKH
                ORDER BY p.MaPhieu DESC";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new PhieuSuaChua
                    {
                        MaPhieu = Convert.ToInt32(reader["MaPhieu"]),
                        BienSo = reader["BienSo"].ToString(),
                        NgayNhan = Convert.ToDateTime(reader["NgayNhan"]),
                        NoiDungSua = reader["NoiDungSua"] == DBNull.Value ? "" : reader["NoiDungSua"].ToString(),
                        TongTien = Convert.ToDecimal(reader["TongTien"]),
                        TrangThai = reader["TrangThai"] == DBNull.Value ? "" : reader["TrangThai"].ToString(),
                        TenKH = reader["TenKH"].ToString()
                    });
                }
            }
            return danhSach;
        }

        public List<ChiTietSuaChua> GetDetails(int maPhieu)
        {
            List<ChiTietSuaChua> danhSach = new List<ChiTietSuaChua>();
            string sql = @"
                SELECT ct.MaPhieu, ct.MaPhuTung, ct.SoLuong, ct.TienCong,
                       pt.TenPhuTung, pt.DonGia
                FROM ChiTietSuaChua ct
                JOIN PhuTung pt ON pt.MaPhuTung = ct.MaPhuTung
                WHERE ct.MaPhieu = @MaPhieu
                ORDER BY pt.TenPhuTung";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new ChiTietSuaChua
                        {
                            MaPhieu = Convert.ToInt32(reader["MaPhieu"]),
                            MaPhuTung = Convert.ToInt32(reader["MaPhuTung"]),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            TienCong = Convert.ToDecimal(reader["TienCong"]),
                            TenPhuTung = reader["TenPhuTung"].ToString(),
                            DonGia = Convert.ToDecimal(reader["DonGia"])
                        });
                    }
                }
            }
            return danhSach;
        }

        // Lập phiếu, thêm chi tiết và trừ kho trong cùng một transaction.
        public int CreateInvoice(string bienSo, string noiDung, List<ChiTietSuaChua> chiTiet)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    decimal tongTien = 0;

                    // Đọc giá và tồn kho hiện tại, khóa dòng để tránh trừ kho sai.
                    foreach (ChiTietSuaChua ct in chiTiet)
                    {
                        string sqlXem = @"
                            SELECT TenPhuTung, DonGia, SoLuongTon
                            FROM PhuTung WITH (UPDLOCK, ROWLOCK)
                            WHERE MaPhuTung = @MaPhuTung";

                        using (SqlCommand cmd = new SqlCommand(sqlXem, conn, trans))
                        {
                            cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = ct.MaPhuTung;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    throw new Exception("Không tìm thấy phụ tùng có mã " + ct.MaPhuTung + ".");
                                }

                                string tenPhuTung = reader["TenPhuTung"].ToString();
                                decimal donGia = Convert.ToDecimal(reader["DonGia"]);
                                int tonKho = Convert.ToInt32(reader["SoLuongTon"]);

                                if (tonKho < ct.SoLuong)
                                {
                                    throw new Exception("Phụ tùng \"" + tenPhuTung + "\" không đủ số lượng trong kho (còn "
                                        + tonKho + ", cần " + ct.SoLuong + ").");
                                }

                                tongTien += ct.SoLuong * donGia + ct.TienCong;
                            }
                        }
                    }

                    // 1. Tạo phiếu sửa chữa.
                    int maPhieu;
                    string sqlPhieu = @"
                        INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai)
                        VALUES (@BienSo, GETDATE(), @NoiDungSua, @TongTien, N'Đã hoàn thành');
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(sqlPhieu, conn, trans))
                    {
                        cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;
                        cmd.Parameters.Add("@NoiDungSua", SqlDbType.NVarChar, -1).Value =
                            string.IsNullOrWhiteSpace(noiDung) ? DBNull.Value : noiDung;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;
                        maPhieu = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Thêm chi tiết và 3. trừ số lượng phụ tùng trong kho.
                    foreach (ChiTietSuaChua ct in chiTiet)
                    {
                        string sqlChiTiet = @"
                            INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong)
                            VALUES (@MaPhieu, @MaPhuTung, @SoLuong, @TienCong)";

                        using (SqlCommand cmd = new SqlCommand(sqlChiTiet, conn, trans))
                        {
                            cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                            cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = ct.MaPhuTung;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ct.SoLuong;
                            cmd.Parameters.Add("@TienCong", SqlDbType.Decimal).Value = ct.TienCong;
                            cmd.ExecuteNonQuery();
                        }

                        string sqlTruKho = @"
                            UPDATE PhuTung
                            SET SoLuongTon = SoLuongTon - @SoLuong
                            WHERE MaPhuTung = @MaPhuTung AND SoLuongTon >= @SoLuong";

                        using (SqlCommand cmd = new SqlCommand(sqlTruKho, conn, trans))
                        {
                            cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = ct.MaPhuTung;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ct.SoLuong;
                            int soDong = cmd.ExecuteNonQuery();
                            if (soDong == 0)
                            {
                                throw new Exception("Không đủ số lượng phụ tùng trong kho để trừ.");
                            }
                        }
                    }

                    trans.Commit();
                    return maPhieu;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public decimal Pay(int maPhieu)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    string trangThai;
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT TrangThai FROM PhieuSuaChua WITH (UPDLOCK) WHERE MaPhieu = @MaPhieu", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                        object ketQua = cmd.ExecuteScalar();
                        if (ketQua == null)
                        {
                            throw new Exception("Không tìm thấy phiếu sửa chữa.");
                        }
                        trangThai = ketQua.ToString();
                    }

                    if (trangThai == "Đã thanh toán")
                    {
                        throw new Exception("Phiếu này đã được thanh toán.");
                    }
                    if (trangThai != "Đã hoàn thành")
                    {
                        throw new Exception("Chỉ thanh toán phiếu đã hoàn thành sửa chữa.");
                    }

                    decimal tongTien;
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT ISNULL(SUM(ct.SoLuong * pt.DonGia + ct.TienCong), 0)
                          FROM ChiTietSuaChua ct
                          JOIN PhuTung pt ON pt.MaPhuTung = ct.MaPhuTung
                          WHERE ct.MaPhieu = @MaPhieu", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                        tongTien = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE PhieuSuaChua
                          SET TongTien = @TongTien, TrangThai = N'Đã thanh toán'
                          WHERE MaPhieu = @MaPhieu", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return tongTien;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
