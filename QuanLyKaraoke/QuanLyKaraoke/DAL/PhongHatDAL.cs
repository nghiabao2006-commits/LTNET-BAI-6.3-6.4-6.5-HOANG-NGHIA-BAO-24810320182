using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.DAL
{
    public class PhongHatDAL
    {
        public List<PhongHat> GetAll()
        {
            List<PhongHat> danhSach = new List<PhongHat>();
            string sql = @"
                SELECT MaPhong, TenPhong, LoaiPhong, GiaTheoGio, TrangThai
                FROM PhongHat
                ORDER BY MaPhong";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new PhongHat
                    {
                        MaPhong = Convert.ToInt32(reader["MaPhong"]),
                        TenPhong = reader["TenPhong"].ToString(),
                        LoaiPhong = reader["LoaiPhong"] == DBNull.Value ? "" : reader["LoaiPhong"].ToString(),
                        GiaTheoGio = Convert.ToDecimal(reader["GiaTheoGio"]),
                        TrangThai = reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSach;
        }

        // Mở phòng: tạo hóa đơn mới và đổi trạng thái phòng trong cùng một transaction.
        public int MoPhong(int maPhong)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    string trangThai;
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT TrangThai FROM PhongHat WITH (UPDLOCK) WHERE MaPhong = @MaPhong", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                        object ketQua = cmd.ExecuteScalar();
                        if (ketQua == null)
                        {
                            throw new Exception("Không tìm thấy phòng hát.");
                        }
                        trangThai = ketQua.ToString();
                    }

                    if (trangThai != "Trống")
                    {
                        throw new Exception("Phòng này đang được sử dụng.");
                    }

                    int maHD;
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO HoaDon (MaPhong, GioVao, TrangThai)
                          VALUES (@MaPhong, GETDATE(), 0);
                          SELECT CAST(SCOPE_IDENTITY() AS INT);", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                        maHD = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE PhongHat SET TrangThai = N'Đang hát' WHERE MaPhong = @MaPhong", conn, trans))
                    {
                        cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return maHD;
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
