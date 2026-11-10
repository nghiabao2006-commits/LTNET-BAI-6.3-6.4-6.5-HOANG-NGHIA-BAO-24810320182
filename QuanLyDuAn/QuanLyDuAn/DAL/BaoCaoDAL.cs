using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.DAL
{
    public class BaoCaoDAL
    {
        // Yêu cầu: dùng SqlDataReader để đọc danh sách công việc trễ hạn.
        public List<CongViecTreHan> GetOverdue()
        {
            List<CongViecTreHan> danhSach = new List<CongViecTreHan>();
            string sql = @"
                SELECT cv.MaTask, cv.TenTask, da.TenDuAn, cv.HanNop, cv.DoUuTien, cv.TrangThai,
                       DATEDIFF(DAY, cv.HanNop, GETDATE()) AS SoNgayTre
                FROM CongViec cv
                JOIN DuAn da ON da.MaDuAn = cv.MaDuAn
                WHERE cv.HanNop IS NOT NULL
                  AND cv.HanNop < GETDATE()
                  AND cv.TrangThai <> N'Done'
                ORDER BY cv.HanNop";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new CongViecTreHan
                    {
                        MaTask = Convert.ToInt32(reader["MaTask"]),
                        TenTask = reader["TenTask"].ToString(),
                        TenDuAn = reader["TenDuAn"].ToString(),
                        HanNop = Convert.ToDateTime(reader["HanNop"]),
                        DoUuTien = reader["DoUuTien"] == DBNull.Value ? "" : reader["DoUuTien"].ToString(),
                        TrangThai = reader["TrangThai"] == DBNull.Value ? "" : reader["TrangThai"].ToString(),
                        SoNgayTre = Convert.ToInt32(reader["SoNgayTre"])
                    });
                }
            }
            return danhSach;
        }

        // Yêu cầu: thống kê tỷ lệ hoàn thành theo từng thành viên bằng GROUP BY.
        public List<ThongKeThanhVien> GetStatistics(int maDuAn)
        {
            List<ThongKeThanhVien> danhSach = new List<ThongKeThanhVien>();
            string sql = @"
                SELECT tv.MaThanhVien, tv.HoTen,
                       COUNT(pc.MaTask) AS TongTask,
                       SUM(CASE WHEN cv.TrangThai = N'Done' THEN 1 ELSE 0 END) AS DaHoanThanh,
                       CAST(SUM(CASE WHEN cv.TrangThai = N'Done' THEN 1 ELSE 0 END) * 100.0
                            / COUNT(pc.MaTask) AS DECIMAL(5,1)) AS TyLe
                FROM ThanhVien tv
                JOIN PhanCong pc ON pc.MaThanhVien = tv.MaThanhVien
                JOIN CongViec cv ON cv.MaTask = pc.MaTask
                WHERE cv.MaDuAn = @MaDuAn
                GROUP BY tv.MaThanhVien, tv.HoTen
                ORDER BY TyLe DESC, tv.HoTen";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = maDuAn;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        danhSach.Add(new ThongKeThanhVien
                        {
                            MaThanhVien = Convert.ToInt32(reader["MaThanhVien"]),
                            HoTen = reader["HoTen"].ToString(),
                            TongTask = Convert.ToInt32(reader["TongTask"]),
                            DaHoanThanh = Convert.ToInt32(reader["DaHoanThanh"]),
                            TyLeHoanThanh = Convert.ToDecimal(reader["TyLe"])
                        });
                    }
                }
            }
            return danhSach;
        }

        // Yêu cầu: dùng ExecuteScalar để lấy tỷ lệ hoàn thành chung của dự án.
        public decimal GetCompletionRate(int maDuAn)
        {
            string sql = @"
                SELECT CAST(ISNULL(
                         SUM(CASE WHEN TrangThai = N'Done' THEN 1 ELSE 0 END) * 100.0
                         / NULLIF(COUNT(*), 0), 0) AS DECIMAL(5,1))
                FROM CongViec
                WHERE MaDuAn = @MaDuAn";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaDuAn", SqlDbType.Int).Value = maDuAn;
                object ketQua = cmd.ExecuteScalar();
                return ketQua == null || ketQua == DBNull.Value ? 0 : Convert.ToDecimal(ketQua);
            }
        }
    }
}
