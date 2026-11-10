namespace QuanLyGarage.DTO
{
    public class PhuTung
    {
        public int MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }

        public string ThongTinHienThi
        {
            get
            {
                return TenPhuTung + " - " + DonGia.ToString("N0") + " đ (tồn " + SoLuongTon + ")";
            }
        }
    }
}
