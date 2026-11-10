namespace QuanLyKaraoke.DTO
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime? GioRa { get; set; }
        public decimal TongTienPhong { get; set; }
        public decimal TongTienDichVu { get; set; }
        public bool TrangThai { get; set; }

        public string TrangThaiText
        {
            get { return TrangThai ? "Đã thanh toán" : "Đang hát"; }
        }

        public decimal TongCong
        {
            get { return TongTienPhong + TongTienDichVu; }
        }
    }
}
