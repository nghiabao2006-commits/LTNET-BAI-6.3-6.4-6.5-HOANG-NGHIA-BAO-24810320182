namespace QuanLyKaraoke.DTO
{
    public class DichVu
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }
        public int TonKho { get; set; }

        public string ThongTinHienThi
        {
            get
            {
                return TenDV + " - " + DonGia.ToString("N0") + " đ (còn " + TonKho + ")";
            }
        }
    }
}
