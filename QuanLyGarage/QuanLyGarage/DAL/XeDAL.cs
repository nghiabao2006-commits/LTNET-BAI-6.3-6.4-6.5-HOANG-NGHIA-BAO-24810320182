using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyGarage.DTO;

namespace QuanLyGarage.DAL
{
    public class XeDAL
    {
        public List<XeView> GetAll()
        {
            List<XeView> danhSach = new List<XeView>();
            string sql = @"
                SELECT x.BienSo, x.MaKH, x.HieuXe, x.NamSanXuat,
                       kh.TenKH, kh.DienThoai, kh.DiaChi
                FROM Xe x
                JOIN KhachHang kh ON kh.MaKH = x.MaKH
                ORDER BY x.BienSo";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(DocXe(reader));
                }
            }
            return danhSach;
        }

        // Tra cứu biển số bằng SqlParameter.
        public XeView FindByPlate(string bienSo)
        {
            string sql = @"
                SELECT x.BienSo, x.MaKH, x.HieuXe, x.NamSanXuat,
                       kh.TenKH, kh.DienThoai, kh.DiaChi
                FROM Xe x
                JOIN KhachHang kh ON kh.MaKH = x.MaKH
                WHERE x.BienSo = @BienSo";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DocXe(reader);
                    }
                }
            }
            return null;
        }

        private XeView DocXe(SqlDataReader reader)
        {
            return new XeView
            {
                BienSo = reader["BienSo"].ToString(),
                MaKH = Convert.ToInt32(reader["MaKH"]),
                HieuXe = reader["HieuXe"] == DBNull.Value ? "" : reader["HieuXe"].ToString(),
                NamSanXuat = reader["NamSanXuat"] == DBNull.Value ? 0 : Convert.ToInt32(reader["NamSanXuat"]),
                TenKH = reader["TenKH"].ToString(),
                DienThoai = reader["DienThoai"] == DBNull.Value ? "" : reader["DienThoai"].ToString(),
                DiaChi = reader["DiaChi"] == DBNull.Value ? "" : reader["DiaChi"].ToString()
            };
        }

        // Thêm chủ xe và xe trong cùng một transaction.
        public void Add(Xe xe, KhachHang khachHang)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int maKH;
                    string sqlKH = @"
                        INSERT INTO KhachHang (TenKH, DienThoai, DiaChi)
                        VALUES (@TenKH, @DienThoai, @DiaChi);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(sqlKH, conn, trans))
                    {
                        cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = khachHang.TenKH;
                        cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value =
                            string.IsNullOrWhiteSpace(khachHang.DienThoai) ? DBNull.Value : khachHang.DienThoai;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value =
                            string.IsNullOrWhiteSpace(khachHang.DiaChi) ? DBNull.Value : khachHang.DiaChi;
                        maKH = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string sqlXe = @"INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat)
                                     VALUES (@BienSo, @MaKH, @HieuXe, @NamSanXuat)";

                    using (SqlCommand cmd = new SqlCommand(sqlXe, conn, trans))
                    {
                        cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = xe.BienSo;
                        cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;
                        cmd.Parameters.Add("@HieuXe", SqlDbType.NVarChar, 50).Value =
                            string.IsNullOrWhiteSpace(xe.HieuXe) ? DBNull.Value : xe.HieuXe;
                        cmd.Parameters.Add("@NamSanXuat", SqlDbType.Int).Value =
                            xe.NamSanXuat > 0 ? xe.NamSanXuat : (object)DBNull.Value;
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

        public void Update(Xe xe, KhachHang khachHang)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    string sqlKH = @"UPDATE KhachHang
                                     SET TenKH = @TenKH, DienThoai = @DienThoai, DiaChi = @DiaChi
                                     WHERE MaKH = @MaKH";

                    using (SqlCommand cmd = new SqlCommand(sqlKH, conn, trans))
                    {
                        cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = khachHang.MaKH;
                        cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = khachHang.TenKH;
                        cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value =
                            string.IsNullOrWhiteSpace(khachHang.DienThoai) ? DBNull.Value : khachHang.DienThoai;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value =
                            string.IsNullOrWhiteSpace(khachHang.DiaChi) ? DBNull.Value : khachHang.DiaChi;
                        cmd.ExecuteNonQuery();
                    }

                    string sqlXe = @"UPDATE Xe
                                     SET HieuXe = @HieuXe, NamSanXuat = @NamSanXuat
                                     WHERE BienSo = @BienSo";

                    using (SqlCommand cmd = new SqlCommand(sqlXe, conn, trans))
                    {
                        cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = xe.BienSo;
                        cmd.Parameters.Add("@HieuXe", SqlDbType.NVarChar, 50).Value =
                            string.IsNullOrWhiteSpace(xe.HieuXe) ? DBNull.Value : xe.HieuXe;
                        cmd.Parameters.Add("@NamSanXuat", SqlDbType.Int).Value =
                            xe.NamSanXuat > 0 ? xe.NamSanXuat : (object)DBNull.Value;
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

        public int CountInvoices(string bienSo)
        {
            string sql = "SELECT COUNT(*) FROM PhieuSuaChua WHERE BienSo = @BienSo";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Delete(string bienSo)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int maKH;

                    using (SqlCommand cmd = new SqlCommand("SELECT MaKH FROM Xe WHERE BienSo = @BienSo", conn, trans))
                    {
                        cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;
                        object ketQua = cmd.ExecuteScalar();
                        if (ketQua == null)
                        {
                            throw new Exception("Không tìm thấy xe cần xóa.");
                        }
                        maKH = Convert.ToInt32(ketQua);
                    }

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Xe WHERE BienSo = @BienSo", conn, trans))
                    {
                        cmd.Parameters.Add("@BienSo", SqlDbType.VarChar, 20).Value = bienSo;
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Xe WHERE MaKH = @MaKH", conn, trans))
                    {
                        cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;
                        int conXeKhac = Convert.ToInt32(cmd.ExecuteScalar());
                        if (conXeKhac == 0)
                        {
                            using (SqlCommand xoaKH = new SqlCommand("DELETE FROM KhachHang WHERE MaKH = @MaKH", conn, trans))
                            {
                                xoaKH.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;
                                xoaKH.ExecuteNonQuery();
                            }
                        }
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
    }
}
