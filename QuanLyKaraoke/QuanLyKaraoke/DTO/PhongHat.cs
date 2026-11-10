namespace QuanLyKaraoke.DTO
{
    public class PhongHat
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public decimal GiaTheoGio { get; set; }
        public string TrangThai { get; set; }

        public bool DangHat
        {
            get { return TrangThai == "Đang hát"; }
        }
    }
}
