using Microsoft.Data.SqlClient;

namespace QuanLyGarage.DAL
{
    // Tự tạo CSDL và dữ liệu mẫu ở lần chạy đầu tiên để không phải chạy script thủ công.
    public static class DatabaseInitializer
    {
        public static void EnsureCreated()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(DbHelper.ConnectionString);
            string tenCsdl = builder.InitialCatalog;

            SqlConnectionStringBuilder master = new SqlConnectionStringBuilder(builder.ConnectionString);
            master.InitialCatalog = "master";

            using (SqlConnection conn = new SqlConnection(master.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    @"IF DB_ID(@TenCSDL) IS NULL
                      BEGIN
                          DECLARE @Sql NVARCHAR(MAX) = N'CREATE DATABASE ' + QUOTENAME(@TenCSDL);
                          EXEC(@Sql);
                      END", conn))
                {
                    cmd.Parameters.AddWithValue("@TenCSDL", tenCsdl);
                    cmd.ExecuteNonQuery();
                }
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                foreach (string sql in Scripts)
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 60;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static readonly string[] Scripts =
        {
            @"IF OBJECT_ID(N'dbo.KhachHang', N'U') IS NULL
              CREATE TABLE dbo.KhachHang
              (
                  MaKH       INT IDENTITY(1,1) PRIMARY KEY,
                  TenKH      NVARCHAR(100) NOT NULL,
                  DienThoai  VARCHAR(15) NULL UNIQUE,
                  DiaChi     NVARCHAR(200) NULL
              );",

            @"IF OBJECT_ID(N'dbo.Xe', N'U') IS NULL
              CREATE TABLE dbo.Xe
              (
                  BienSo      VARCHAR(20) PRIMARY KEY,
                  MaKH        INT NOT NULL,
                  HieuXe      NVARCHAR(50) NULL,
                  NamSanXuat  INT NULL,
                  CONSTRAINT FK_Xe_KhachHang FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH)
              );",

            @"IF OBJECT_ID(N'dbo.PhuTung', N'U') IS NULL
              CREATE TABLE dbo.PhuTung
              (
                  MaPhuTung   INT IDENTITY(1,1) PRIMARY KEY,
                  TenPhuTung  NVARCHAR(150) NOT NULL,
                  DonGia      DECIMAL(18,2) NOT NULL CONSTRAINT DF_PhuTung_DonGia DEFAULT 0,
                  SoLuongTon  INT NOT NULL CONSTRAINT DF_PhuTung_SoLuongTon DEFAULT 0,
                  CONSTRAINT CK_PhuTung_SoLuongTon CHECK (SoLuongTon >= 0)
              );",

            @"IF OBJECT_ID(N'dbo.PhieuSuaChua', N'U') IS NULL
              CREATE TABLE dbo.PhieuSuaChua
              (
                  MaPhieu     INT IDENTITY(1,1) PRIMARY KEY,
                  BienSo      VARCHAR(20) NOT NULL,
                  NgayNhan    DATETIME NOT NULL CONSTRAINT DF_PhieuSuaChua_NgayNhan DEFAULT GETDATE(),
                  NoiDungSua  NVARCHAR(MAX) NULL,
                  TongTien    DECIMAL(18,2) NOT NULL CONSTRAINT DF_PhieuSuaChua_TongTien DEFAULT 0,
                  TrangThai   NVARCHAR(30) NULL,
                  CONSTRAINT FK_PhieuSuaChua_Xe FOREIGN KEY (BienSo) REFERENCES dbo.Xe(BienSo)
              );",

            @"IF OBJECT_ID(N'dbo.ChiTietSuaChua', N'U') IS NULL
              CREATE TABLE dbo.ChiTietSuaChua
              (
                  MaPhieu     INT NOT NULL,
                  MaPhuTung   INT NOT NULL,
                  SoLuong     INT NOT NULL,
                  TienCong    DECIMAL(18,2) NOT NULL CONSTRAINT DF_ChiTietSuaChua_TienCong DEFAULT 0,
                  CONSTRAINT PK_ChiTietSuaChua PRIMARY KEY (MaPhieu, MaPhuTung),
                  CONSTRAINT FK_ChiTietSuaChua_Phieu FOREIGN KEY (MaPhieu) REFERENCES dbo.PhieuSuaChua(MaPhieu),
                  CONSTRAINT FK_ChiTietSuaChua_PhuTung FOREIGN KEY (MaPhuTung) REFERENCES dbo.PhuTung(MaPhuTung),
                  CONSTRAINT CK_ChiTietSuaChua_SoLuong CHECK (SoLuong > 0)
              );",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang)
              INSERT INTO dbo.KhachHang (TenKH, DienThoai, DiaChi) VALUES
                  (N'Nguyễn Văn Hùng', '0901234567', N'12 Nguyễn Trãi, Quận 1, TP.HCM'),
                  (N'Trần Thị Mai',    '0912345678', N'45 Lê Lợi, Quận 3, TP.HCM'),
                  (N'Lê Quốc Bảo',     '0987654321', N'78 Trần Phú, Hà Đông, Hà Nội');",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.Xe)
              INSERT INTO dbo.Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES
                  ('51A-123.45', 1, N'Toyota',  2020),
                  ('30F-678.90', 2, N'Honda',   2018),
                  ('43C-246.80', 3, N'VinFast', 2022);",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.PhuTung)
              INSERT INTO dbo.PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES
                  (N'Dầu máy 5W-30 (4L)',         450000, 20),
                  (N'Lọc dầu động cơ',            150000, 30),
                  (N'Má phanh trước',             850000, 10),
                  (N'Bugi iridium',               120000, 50),
                  (N'Lốp Michelin 205/55R16',    2450000,  8),
                  (N'Ắc quy 12V 60Ah',           1850000,  5),
                  (N'Gạt mưa',                    250000, 15),
                  (N'Nước làm mát',                90000, 25);",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.PhieuSuaChua)
              INSERT INTO dbo.PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) VALUES
                  ('51A-123.45', '2026-11-08 09:00', N'Thay dầu máy, lọc dầu và kiểm tra tổng quát.', 700000,  N'Đã hoàn thành'),
                  ('30F-678.90', '2026-11-09 14:30', N'Thay má phanh trước, kiểm tra hệ thống phanh.', 1900000, N'Đang sửa'),
                  ('43C-246.80', '2026-11-05 08:15', N'Thay ắc quy và gạt mưa.',                       2500000, N'Đã thanh toán');",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.ChiTietSuaChua)
              INSERT INTO dbo.ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES
                  (1, 1, 1, 60000),
                  (1, 2, 1, 40000),
                  (2, 3, 2, 200000),
                  (3, 6, 1, 100000),
                  (3, 7, 2, 50000);"
        };
    }
}
