namespace QuanLyDuAn.DTO
{
    // Dùng để hiển thị công việc kèm tên dự án và tên thành viên được phân công.
    public class CongViecView
    {
        public int MaTask { get; set; }
        public int MaDuAn { get; set; }
        public string TenTask { get; set; }
        public string MoTa { get; set; }
        public DateTime? HanNop { get; set; }
        public string DoUuTien { get; set; }
        public string TrangThai { get; set; }
        public string TenDuAn { get; set; }
        public string DanhSachThanhVien { get; set; }
    }
}
