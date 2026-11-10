using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.DAL
{
    public class ThanhVienDAL
    {
        public List<ThanhVien> GetAll()
        {
            List<ThanhVien> danhSach = new List<ThanhVien>();
            string sql = "SELECT MaThanhVien, HoTen, Email, ChuyenMon FROM ThanhVien ORDER BY HoTen";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new ThanhVien
                    {
                        MaThanhVien = Convert.ToInt32(reader["MaThanhVien"]),
                        HoTen = reader["HoTen"].ToString(),
                        Email = reader["Email"] == DBNull.Value ? "" : reader["Email"].ToString(),
                        ChuyenMon = reader["ChuyenMon"] == DBNull.Value ? "" : reader["ChuyenMon"].ToString()
                    });
                }
            }
            return danhSach;
        }

        public int Insert(ThanhVien tv)
        {
            string sql = @"INSERT INTO ThanhVien (HoTen, Email, ChuyenMon)
                           VALUES (@HoTen, @Email, @ChuyenMon);
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = tv.HoTen;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = string.IsNullOrWhiteSpace(tv.Email) ? DBNull.Value : tv.Email;
                cmd.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(tv.ChuyenMon) ? DBNull.Value : tv.ChuyenMon;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(ThanhVien tv)
        {
            string sql = @"UPDATE ThanhVien
                           SET HoTen = @HoTen, Email = @Email, ChuyenMon = @ChuyenMon
                           WHERE MaThanhVien = @MaThanhVien";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaThanhVien", SqlDbType.Int).Value = tv.MaThanhVien;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = tv.HoTen;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = string.IsNullOrWhiteSpace(tv.Email) ? DBNull.Value : tv.Email;
                cmd.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(tv.ChuyenMon) ? DBNull.Value : tv.ChuyenMon;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int maThanhVien)
        {
            string sql = "DELETE FROM ThanhVien WHERE MaThanhVien = @MaThanhVien";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaThanhVien", SqlDbType.Int).Value = maThanhVien;
                cmd.ExecuteNonQuery();
            }
        }

        public int CountAssignments(int maThanhVien)
        {
            string sql = "SELECT COUNT(*) FROM PhanCong WHERE MaThanhVien = @MaThanhVien";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaThanhVien", SqlDbType.Int).Value = maThanhVien;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
