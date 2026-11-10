using System.Data;
using QuanLyKaraoke.DAL;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();

        public List<HoaDon> GetAll()
        {
            return dal.GetAll();
        }

        public HoaDon GetDangMo(int maPhong)
        {
            return dal.GetDangMo(maPhong);
        }

        public DataTable GetChiTietTable(int maHD)
        {
            return dal.GetChiTietTable(maHD);
        }

        public void GoiDichVu(int maHD, int maDV, int soLuong)
        {
            if (maHD <= 0)
            {
                throw new Exception("Phòng chưa được mở hóa đơn.");
            }
            if (maDV <= 0)
            {
                throw new Exception("Vui lòng chọn dịch vụ.");
            }
            if (soLuong <= 0)
            {
                throw new Exception("Số lượng dịch vụ phải lớn hơn 0.");
            }

            dal.GoiDichVu(maHD, maDV, soLuong);
        }

        public HoaDon ThanhToan(int maHD)
        {
            if (maHD <= 0)
            {
                throw new Exception("Vui lòng chọn phòng đang hát để thanh toán.");
            }
            return dal.ThanhToan(maHD);
        }
    }
}
