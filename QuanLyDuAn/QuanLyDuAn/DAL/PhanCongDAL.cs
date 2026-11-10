using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.DAL
{
    public class PhanCongDAL
    {
        public List<PhanCong> GetByTask(int maTask)
        {
            List<PhanCong> danhSach = new List<PhanCong>();
            string sql = @"SELECT pc.MaTask, pc.MaThanhVien, pc.NgayGiao, tv.HoTen
                           FROM PhanCong pc
                           JOIN ThanhVien tv ON tv.MaThanhVien = pc.MaThanhVien
                           WHERE pc.MaTask = @MaTask
                           ORDER BY tv.HoTen";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new PhanCong
                        {
                            MaTask = Convert.ToInt32(reader["MaTask"]),
                            MaThanhVien = Convert.ToInt32(reader["MaThanhVien"]),
                            NgayGiao = Convert.ToDateTime(reader["NgayGiao"]),
                            HoTen = reader["HoTen"].ToString()
                        });
                    }
                }
            }
            return danhSach;
        }

        public List<int> GetMemberIds(int maTask)
        {
            List<int> danhSach = new List<int>();
            string sql = "SELECT MaThanhVien FROM PhanCong WHERE MaTask = @MaTask";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(Convert.ToInt32(reader["MaThanhVien"]));
                    }
                }
            }
            return danhSach;
        }

        // Xóa phân công cũ và thêm lại danh sách mới trong cùng một transaction.
        public void SaveAssignments(int maTask, List<int> danhSachMaThanhVien)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM PhanCong WHERE MaTask = @MaTask", conn, trans))
                    {
                        cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                        cmd.ExecuteNonQuery();
                    }

                    foreach (int maThanhVien in danhSachMaThanhVien)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES (@MaTask, @MaThanhVien, GETDATE())",
                            conn, trans))
                        {
                            cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                            cmd.Parameters.Add("@MaThanhVien", SqlDbType.Int).Value = maThanhVien;
                            cmd.ExecuteNonQuery();
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
