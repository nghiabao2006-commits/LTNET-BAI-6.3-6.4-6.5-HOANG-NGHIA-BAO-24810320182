using System.Configuration;
using Microsoft.Data.SqlClient;

namespace QuanLyGarage.DAL
{
    public static class DbHelper
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = TimChuoiKetNoi();
                }
                return _connectionString;
            }
        }

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // Thử lần lượt các SQL Server thường gặp để giảng viên chạy được trên máy khác.
        private static string TimChuoiKetNoi()
        {
            ConnectionStringSettings cauHinh = ConfigurationManager.ConnectionStrings["GarageDB"];
            if (cauHinh == null)
            {
                throw new Exception("Chưa có chuỗi kết nối GarageDB trong App.config.");
            }

            SqlConnectionStringBuilder mau = new SqlConnectionStringBuilder(cauHinh.ConnectionString);
            string[] danhSachMayChu =
            {
                mau.DataSource,
                @"(localdb)\MSSQLLocalDB",
                ".",
                @".\SQLEXPRESS"
            };

            string thongBaoLoi = "";
            foreach (string mayChu in danhSachMayChu.Distinct(StringComparer.OrdinalIgnoreCase))
            {
                try
                {
                    SqlConnectionStringBuilder thu = new SqlConnectionStringBuilder(mau.ConnectionString);
                    thu.DataSource = mayChu;
                    thu.InitialCatalog = "master";
                    thu.ConnectTimeout = 5;

                    using (SqlConnection conn = new SqlConnection(thu.ConnectionString))
                    {
                        conn.Open();
                    }

                    SqlConnectionStringBuilder ketQua = new SqlConnectionStringBuilder(mau.ConnectionString);
                    ketQua.DataSource = mayChu;
                    ketQua.TrustServerCertificate = true;
                    return ketQua.ConnectionString;
                }
                catch (Exception ex)
                {
                    thongBaoLoi += mayChu + ": " + ex.Message + Environment.NewLine;
                }
            }

            throw new Exception("Không kết nối được SQL Server. Kiểm tra lại App.config.\n" + thongBaoLoi);
        }
    }
}
