using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.DAL
{
    public class CongViecDAL
    {
        private const string SelectSql = @"
            SELECT cv.MaTask, cv.MaDuAn, cv.TenTask, cv.MoTa, cv.HanNop, cv.DoUuTien, cv.TrangThai,
                   da.TenDuAn,
                   ISNULL(STUFF((SELECT N', ' + tv.HoTen
                                 FROM PhanCong pc
                                 JOIN ThanhVien tv ON tv.MaThanhVien = pc.MaThanhVien
                                 WHERE pc.MaTask = cv.MaTask
                                 FOR XML PATH(N''), TYPE).value(N'.', N'nvarchar(max)'), 1, 2, N''), N'') AS ThanhVien
            FROM CongViec cv
            JOIN DuAn da ON da.MaDuAn = cv.MaDuAn";

        public List<CongViecView> GetByFilter(int? maDuAn, string trangThai)
        {
            List<CongViecView> danhSach = new List<CongViecView>();
            string sql = SelectSql + @"
                WHERE (@MaDuAn IS NULL OR cv.MaDuAn = @MaDuAn)
                  AND (@TrangThai IS NULL OR cv.TrangThai = @TrangThai)
                ORDER BY cv.MaTask";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = (object)maDuAn ?? DBNull.Value;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = string.IsNullOrWhiteSpace(trangThai) ? DBNull.Value : trangThai;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(DocCongViec(reader));
                    }
                }
            }
            return danhSach;
        }

        public CongViecView GetById(int maTask)
        {
            string sql = SelectSql + " WHERE cv.MaTask = @MaTask";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return DocCongViec(reader);
                    }
                }
            }
            return null;
        }

        private CongViecView DocCongViec(SqlDataReader reader)
        {
            return new CongViecView
            {
                MaTask = Convert.ToInt32(reader["MaTask"]),
                MaDuAn = Convert.ToInt32(reader["MaDuAn"]),
                TenTask = reader["TenTask"].ToString(),
                MoTa = reader["MoTa"] == DBNull.Value ? "" : reader["MoTa"].ToString(),
                HanNop = reader["HanNop"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["HanNop"]),
                DoUuTien = reader["DoUuTien"] == DBNull.Value ? "" : reader["DoUuTien"].ToString(),
                TrangThai = reader["TrangThai"] == DBNull.Value ? "" : reader["TrangThai"].ToString(),
                TenDuAn = reader["TenDuAn"].ToString(),
                DanhSachThanhVien = reader["ThanhVien"].ToString()
            };
        }

        public int Insert(CongViec cv)
        {
            string sql = @"INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
                           VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai);
                           SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                GanThamSo(cmd, cv);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(CongViec cv)
        {
            string sql = @"UPDATE CongViec
                           SET MaDuAn = @MaDuAn,
                               TenTask = @TenTask,
                               MoTa = @MoTa,
                               HanNop = @HanNop,
                               DoUuTien = @DoUuTien,
                               TrangThai = @TrangThai
                           WHERE MaTask = @MaTask";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = cv.MaTask;
                GanThamSo(cmd, cv);
                cmd.ExecuteNonQuery();
            }
        }

        private void GanThamSo(SqlCommand cmd, CongViec cv)
        {
            cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = cv.MaDuAn;
            cmd.Parameters.Add("@TenTask", SqlDbType.NVarChar, 200).Value = cv.TenTask;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, -1).Value = string.IsNullOrWhiteSpace(cv.MoTa) ? DBNull.Value : cv.MoTa;
            cmd.Parameters.Add("@HanNop", SqlDbType.DateTime).Value = (object)cv.HanNop ?? DBNull.Value;
            cmd.Parameters.Add("@DoUuTien", SqlDbType.NVarChar, 20).Value = (object)cv.DoUuTien ?? DBNull.Value;
            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = (object)cv.TrangThai ?? DBNull.Value;
        }

        public void UpdateTrangThai(int maTask, string trangThai)
        {
            string sql = "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50).Value = trangThai;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int maTask)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PhanCong WHERE MaTask = @MaTask", conn))
                {
                    cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand("DELETE FROM CongViec WHERE MaTask = @MaTask", conn))
                {
                    cmd.Parameters.Add("@MaTask", SqlDbType.Int).Value = maTask;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
