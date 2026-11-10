using Microsoft.Data.SqlClient;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.DAL
{
    public class DichVuDAL
    {
        public List<DichVu> GetAll()
        {
            List<DichVu> danhSach = new List<DichVu>();
            string sql = @"
                SELECT MaDV, TenDV, DonGia, TonKho
                FROM DichVu
                ORDER BY TenDV";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new DichVu
                    {
                        MaDV = Convert.ToInt32(reader["MaDV"]),
                        TenDV = reader["TenDV"].ToString(),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        TonKho = Convert.ToInt32(reader["TonKho"])
                    });
                }
            }
            return danhSach;
        }
    }
}
