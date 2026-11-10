/* =============================================================
   BÀI 6.3: HỆ THỐNG QUẢN LÝ CÔNG VIỆC & TIẾN ĐỘ DỰ ÁN
   Cơ sở dữ liệu: ProjectTaskDB
   Cách dùng: mở file này bằng SQL Server Management Studio và Execute
   ============================================================= */

IF DB_ID(N'ProjectTaskDB') IS NULL
BEGIN
    CREATE DATABASE ProjectTaskDB;
END
GO

USE ProjectTaskDB;
GO

/* ------------------------- Bảng Dự án ------------------------- */
IF OBJECT_ID(N'dbo.DuAn', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DuAn
    (
        MaDuAn      INT IDENTITY(1,1) PRIMARY KEY,
        TenDuAn     NVARCHAR(150) NOT NULL,
        NgayBatDau  DATETIME NULL,
        NgayKetThuc DATETIME NULL,
        TrangThai   NVARCHAR(50) NULL
    );
END
GO

/* ----------------------- Bảng Thành viên ---------------------- */
IF OBJECT_ID(N'dbo.ThanhVien', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ThanhVien
    (
        MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
        HoTen       NVARCHAR(100) NOT NULL,
        Email       VARCHAR(100) NULL UNIQUE,
        ChuyenMon   NVARCHAR(100) NULL
    );
END
GO

/* ------------------------ Bảng Công việc ---------------------- */
IF OBJECT_ID(N'dbo.CongViec', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CongViec
    (
        MaTask     INT IDENTITY(1,1) PRIMARY KEY,
        MaDuAn     INT NOT NULL,
        TenTask    NVARCHAR(200) NOT NULL,
        MoTa       NVARCHAR(MAX) NULL,
        HanNop     DATETIME NULL,
        DoUuTien   NVARCHAR(20) NULL,
        TrangThai  NVARCHAR(50) NULL,
        CONSTRAINT FK_CongViec_DuAn FOREIGN KEY (MaDuAn) REFERENCES dbo.DuAn(MaDuAn)
    );
END
GO

/* ---------------------- Bảng Phân công ------------------------ */
IF OBJECT_ID(N'dbo.PhanCong', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PhanCong
    (
        MaTask      INT NOT NULL,
        MaThanhVien INT NOT NULL,
        NgayGiao    DATETIME NOT NULL CONSTRAINT DF_PhanCong_NgayGiao DEFAULT GETDATE(),
        CONSTRAINT PK_PhanCong PRIMARY KEY (MaTask, MaThanhVien),
        CONSTRAINT FK_PhanCong_CongViec FOREIGN KEY (MaTask) REFERENCES dbo.CongViec(MaTask),
        CONSTRAINT FK_PhanCong_ThanhVien FOREIGN KEY (MaThanhVien) REFERENCES dbo.ThanhVien(MaThanhVien)
    );
END
GO

/* ========================= DỮ LIỆU MẪU ========================= */
IF NOT EXISTS (SELECT 1 FROM dbo.DuAn)
BEGIN
    INSERT INTO dbo.DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES
        (N'Website bán hàng',       '2026-09-01', '2026-12-31', N'Đang chạy'),
        (N'Ứng dụng quản lý kho',   '2026-08-15', '2026-11-30', N'Đang chạy'),
        (N'Landing page sự kiện',   '2026-06-01', '2026-08-30', N'Hoàn thành'),
        (N'App đặt lịch khám',      '2026-10-01', '2027-01-31', N'Tạm dừng');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.ThanhVien)
BEGIN
    INSERT INTO dbo.ThanhVien (HoTen, Email, ChuyenMon) VALUES
        (N'Nguyễn Văn An',   'an.nguyen@example.com',   N'Backend'),
        (N'Trần Thị Bình',   'binh.tran@example.com',   N'Frontend'),
        (N'Lê Minh Cường',   'cuong.le@example.com',    N'Kiểm thử (QA)'),
        (N'Phạm Thu Dung',   'dung.pham@example.com',   N'Thiết kế UI/UX'),
        (N'Hoàng Anh Tuấn',  'tuan.hoang@example.com',  N'Phân tích nghiệp vụ');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.CongViec)
BEGIN
    INSERT INTO dbo.CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) VALUES
        (1, N'Thiết kế cơ sở dữ liệu',        N'Thiết kế các bảng và quan hệ cho website bán hàng.', '2026-09-10', N'Cao',       N'Done'),
        (1, N'Xây dựng API đăng nhập',        N'API đăng nhập, đăng xuất và cấp token.',             '2026-10-05', N'Cao',       N'Done'),
        (1, N'Giao diện trang chủ',           N'Dựng giao diện trang chủ và thanh menu.',            '2026-11-20', N'Trung bình', N'In Progress'),
        (1, N'Trang chi tiết sản phẩm',       N'Hiển thị thông tin, hình ảnh và nút thêm giỏ hàng.', '2026-11-25', N'Trung bình', N'To Do'),
        (1, N'Kiểm thử chức năng giỏ hàng',   N'Kiểm thử thêm, sửa, xóa sản phẩm trong giỏ hàng.',   '2026-11-15', N'Cao',       N'Review'),
        (1, N'Viết tài liệu hướng dẫn',       N'Tài liệu sử dụng hệ thống cho khách hàng.',          '2026-12-10', N'Thấp',      N'To Do'),
        (2, N'Khảo sát quy trình kho',        N'Ghi nhận quy trình nhập, xuất và kiểm kê kho.',      '2026-09-01', N'Trung bình', N'Done'),
        (2, N'Chức năng nhập kho',            N'Lập phiếu nhập kho và cập nhật số lượng tồn.',       '2026-10-20', N'Cao',       N'In Progress'),
        (2, N'Báo cáo tồn kho',               N'Thống kê hàng tồn theo từng kho và nhóm hàng.',      '2026-11-30', N'Trung bình', N'To Do'),
        (2, N'Phân quyền người dùng',         N'Phân quyền thủ kho, kế toán và quản lý.',            '2026-10-30', N'Cao',       N'Review'),
        (3, N'Thiết kế banner sự kiện',       N'Thiết kế banner cho trang giới thiệu sự kiện.',      '2026-08-10', N'Trung bình', N'Done'),
        (3, N'Đăng ký nhận thông tin',        N'Form đăng ký email nhận thông tin sự kiện.',         '2026-08-20', N'Thấp',      N'Done'),
        (4, N'Phân tích yêu cầu',             N'Thu thập yêu cầu đặt lịch khám của phòng khám.',     '2026-11-05', N'Cao',       N'To Do'),
        (4, N'Thiết kế luồng đặt lịch',       N'Thiết kế luồng chọn bác sĩ, ngày và giờ khám.',      '2026-12-15', N'Trung bình', N'To Do');
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.PhanCong)
BEGIN
    INSERT INTO dbo.PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES
        (1, 1, '2026-09-02'), (2, 1, '2026-09-15'), (2, 2, '2026-09-15'),
        (3, 2, '2026-10-10'), (3, 4, '2026-10-10'), (4, 2, '2026-10-20'),
        (5, 3, '2026-11-01'), (5, 1, '2026-11-01'), (6, 4, '2026-11-05'),
        (7, 5, '2026-08-16'), (8, 1, '2026-09-20'), (8, 3, '2026-09-20'),
        (9, 5, '2026-10-25'), (10, 1, '2026-10-01'), (11, 4, '2026-06-10'),
        (12, 2, '2026-07-01'), (13, 5, '2026-10-02'), (14, 4, '2026-10-20'),
        (14, 5, '2026-10-20');
END
GO
