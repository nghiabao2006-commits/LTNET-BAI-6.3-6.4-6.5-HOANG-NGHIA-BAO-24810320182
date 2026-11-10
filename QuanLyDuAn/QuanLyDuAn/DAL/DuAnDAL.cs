using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.DAL
{
    public class DuAnDAL
    {
        public List<DuAn> GetAll()
        {
            List<DuAn> danhSach = new List<DuAn>();
            string sql = @"SELECT MaDuAn, TenDuAn, NgayBatDau, NgayKetThuc, TrangThai
                           FROM DuAn
                           ORDER BY MaDuAn";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new DuAn
                    {
                        MaDuAn = Convert.ToInt32(reader["MaDuAn"]),
                        TenDuAn = reader["TenDuAn"].ToString(),
                        NgayBatDau = reader["NgayBatDau"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["NgayBatDau"]),
                        NgayKetThuc = reader["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["NgayKetThuc"]),
                        TrangThai = reader["TrangThai"] == DBNull.Value ? "" : reader["TrangThai"].ToString()
                    });
                }
            }
            return danhSach;
        }

        public int Insert(DuAn duAn)
        {
            string sql = @"INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai)
                           VALUES (@TenDuAn, @NgayBatDau, @NgayKetThuc, @TrangThai);
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@TenDuAn", SqlDbType.NVarChar, 150).Value = duAn.TenDuAn;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = (object)duAn.NgayBatDau ?? DBNull.Value;
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = (object)duAn.NgayKetThuc ?? DBNull.Value;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = (object)duAn.TrangThai ?? DBNull.Value;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(DuAn duAn)
        {
            string sql = @"UPDATE DuAn
                           SET TenDuAn = @TenDuAn,
                               NgayBatDau = @NgayBatDau,
                               NgayKetThuc = @NgayKetThuc,
                               TrangThai = @TrangThai
                           WHERE MaDuAn = @MaDuAn";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = duAn.MaDuAn;
                cmd.Parameters.Add("@TenDuAn", SqlDbType.NVarChar, 150).Value = duAn.TenDuAn;
                cmd.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = (object)duAn.NgayBatDau ?? DBNull.Value;
                cmd.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = (object)duAn.NgayKetThuc ?? DBNull.Value;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = (object)duAn.TrangThai ?? DBNull.Value;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int maDuAn)
        {
            string sql = "DELETE FROM DuAn WHERE MaDuAn = @MaDuAn";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = maDuAn;
                cmd.ExecuteNonQuery();
            }
        }

        public int CountTasks(int maDuAn)
        {
            string sql = "SELECT COUNT(*) FROM CongViec WHERE MaDuAn = @MaDuAn";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = maDuAn;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
