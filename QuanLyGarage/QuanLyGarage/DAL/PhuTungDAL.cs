using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyGarage.DTO;

namespace QuanLyGarage.DAL
{
    public class PhuTungDAL
    {
        public List<PhuTung> GetAll()
        {
            List<PhuTung> danhSach = new List<PhuTung>();
            string sql = "SELECT MaPhuTung, TenPhuTung, DonGia, SoLuongTon FROM PhuTung ORDER BY TenPhuTung";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    danhSach.Add(new PhuTung
                    {
                        MaPhuTung = Convert.ToInt32(reader["MaPhuTung"]),
                        TenPhuTung = reader["TenPhuTung"].ToString(),
                        DonGia = Convert.ToDecimal(reader["DonGia"]),
                        SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                    });
                }
            }
            return danhSach;
        }

        public void Insert(PhuTung pt)
        {
            string sql = @"INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon)
                           VALUES (@TenPhuTung, @DonGia, @SoLuongTon)";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@TenPhuTung", SqlDbType.NVarChar, 150).Value = pt.TenPhuTung;
                cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = pt.DonGia;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = pt.SoLuongTon;
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(PhuTung pt)
        {
            string sql = @"UPDATE PhuTung
                           SET TenPhuTung = @TenPhuTung, DonGia = @DonGia, SoLuongTon = @SoLuongTon
                           WHERE MaPhuTung = @MaPhuTung";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = pt.MaPhuTung;
                cmd.Parameters.Add("@TenPhuTung", SqlDbType.NVarChar, 150).Value = pt.TenPhuTung;
                cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = pt.DonGia;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = pt.SoLuongTon;
                cmd.ExecuteNonQuery();
            }
        }

        public int CountUsage(int maPhuTung)
        {
            string sql = "SELECT COUNT(*) FROM ChiTietSuaChua WHERE MaPhuTung = @MaPhuTung";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = maPhuTung;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Delete(int maPhuTung)
        {
            string sql = "DELETE FROM PhuTung WHERE MaPhuTung = @MaPhuTung";

            using (SqlConnection conn = DbHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaPhuTung", SqlDbType.Int).Value = maPhuTung;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
