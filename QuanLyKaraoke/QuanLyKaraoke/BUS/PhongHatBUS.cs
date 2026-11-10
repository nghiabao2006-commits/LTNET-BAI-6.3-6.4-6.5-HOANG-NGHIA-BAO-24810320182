using QuanLyKaraoke.DAL;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.BUS
{
    public class PhongHatBUS
    {
        private readonly PhongHatDAL dal = new PhongHatDAL();

        public List<PhongHat> GetAll()
        {
            return dal.GetAll();
        }

        public int MoPhong(int maPhong)
        {
            if (maPhong <= 0)
            {
                throw new Exception("Vui lòng chọn phòng cần mở.");
            }
            return dal.MoPhong(maPhong);
        }
    }
}
