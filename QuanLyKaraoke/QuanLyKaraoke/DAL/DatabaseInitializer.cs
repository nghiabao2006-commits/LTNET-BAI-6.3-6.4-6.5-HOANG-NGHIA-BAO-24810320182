using Microsoft.Data.SqlClient;

namespace QuanLyKaraoke.DAL
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
            @"IF OBJECT_ID(N'dbo.PhongHat', N'U') IS NULL
              CREATE TABLE dbo.PhongHat
              (
                  MaPhong     INT IDENTITY(1,1) PRIMARY KEY,
                  TenPhong    NVARCHAR(50) NOT NULL,
                  LoaiPhong   NVARCHAR(30) NULL,
                  GiaTheoGio  DECIMAL(18,2) NOT NULL CONSTRAINT DF_PhongHat_GiaTheoGio DEFAULT 0,
                  TrangThai   NVARCHAR(20) NOT NULL CONSTRAINT DF_PhongHat_TrangThai DEFAULT N'Trống'
              );",

            @"IF OBJECT_ID(N'dbo.DichVu', N'U') IS NULL
              CREATE TABLE dbo.DichVu
              (
                  MaDV    INT IDENTITY(1,1) PRIMARY KEY,
                  TenDV   NVARCHAR(100) NOT NULL,
                  DonGia  DECIMAL(18,2) NOT NULL CONSTRAINT DF_DichVu_DonGia DEFAULT 0,
                  TonKho  INT NOT NULL CONSTRAINT DF_DichVu_TonKho DEFAULT 0,
                  CONSTRAINT CK_DichVu_TonKho CHECK (TonKho >= 0)
              );",

            @"IF OBJECT_ID(N'dbo.HoaDon', N'U') IS NULL
              CREATE TABLE dbo.HoaDon
              (
                  MaHD            INT IDENTITY(1,1) PRIMARY KEY,
                  MaPhong         INT NOT NULL,
                  GioVao          DATETIME NOT NULL,
                  GioRa           DATETIME NULL,
                  TongTienPhong   DECIMAL(18,2) NOT NULL CONSTRAINT DF_HoaDon_TongTienPhong DEFAULT 0,
                  TongTienDichVu  DECIMAL(18,2) NOT NULL CONSTRAINT DF_HoaDon_TongTienDichVu DEFAULT 0,
                  TrangThai       BIT NOT NULL CONSTRAINT DF_HoaDon_TrangThai DEFAULT 0,
                  CONSTRAINT FK_HoaDon_PhongHat FOREIGN KEY (MaPhong) REFERENCES dbo.PhongHat(MaPhong)
              );",

            @"IF OBJECT_ID(N'dbo.ChiTietDichVu', N'U') IS NULL
              CREATE TABLE dbo.ChiTietDichVu
              (
                  MaHD     INT NOT NULL,
                  MaDV     INT NOT NULL,
                  SoLuong  INT NOT NULL,
                  DonGia   DECIMAL(18,2) NOT NULL,
                  CONSTRAINT PK_ChiTietDichVu PRIMARY KEY (MaHD, MaDV),
                  CONSTRAINT FK_ChiTietDichVu_HoaDon FOREIGN KEY (MaHD) REFERENCES dbo.HoaDon(MaHD),
                  CONSTRAINT FK_ChiTietDichVu_DichVu FOREIGN KEY (MaDV) REFERENCES dbo.DichVu(MaDV),
                  CONSTRAINT CK_ChiTietDichVu_SoLuong CHECK (SoLuong > 0)
              );",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.PhongHat)
              INSERT INTO dbo.PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
                  (N'Phòng VIP 01',      N'VIP',     200000, N'Đang hát'),
                  (N'Phòng VIP 02',      N'VIP',     200000, N'Trống'),
                  (N'Phòng Thường 01',   N'Thường',  120000, N'Trống'),
                  (N'Phòng Thường 02',   N'Thường',  120000, N'Trống'),
                  (N'Phòng Thường 03',   N'Thường',  120000, N'Trống'),
                  (N'Phòng Thường 04',   N'Thường',  120000, N'Trống');",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.DichVu)
              INSERT INTO dbo.DichVu (TenDV, DonGia, TonKho) VALUES
                  (N'Bia Heineken',   35000, 100),
                  (N'Bia Tiger',      32000,  80),
                  (N'Coca-Cola',      20000, 120),
                  (N'Nước suối',      15000, 150),
                  (N'Trái cây dĩa',  150000,  30),
                  (N'Khô gà',         90000,  40),
                  (N'Bắp rang',       50000,  50),
                  (N'Đá lạnh',        10000, 200);",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.HoaDon)
              INSERT INTO dbo.HoaDon (MaPhong, GioVao, GioRa, TongTienPhong, TongTienDichVu, TrangThai) VALUES
                  (1, DATEADD(HOUR, -1, GETDATE()), NULL, 0, 220000, 0),
                  (2, '2026-11-09 19:00', '2026-11-09 22:00', 600000, 64000, 1);",

            @"IF NOT EXISTS (SELECT 1 FROM dbo.ChiTietDichVu)
              INSERT INTO dbo.ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) VALUES
                  (1, 1, 2, 35000),
                  (1, 5, 1, 150000),
                  (2, 2, 2, 32000);"
        };
    }
}
