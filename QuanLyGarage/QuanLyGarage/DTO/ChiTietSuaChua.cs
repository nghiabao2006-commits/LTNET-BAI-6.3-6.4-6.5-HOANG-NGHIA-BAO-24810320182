namespace QuanLyGarage.DTO
{
    public class ChiTietSuaChua
    {
        public int MaPhieu { get; set; }
        public int MaPhuTung { get; set; }
        public int SoLuong { get; set; }
        public decimal TienCong { get; set; }
        public string TenPhuTung { get; set; }
        public decimal DonGia { get; set; }

        public decimal ThanhTien
        {
            get
            {
                return SoLuong * DonGia + TienCong;
            }
        }
    }
}
