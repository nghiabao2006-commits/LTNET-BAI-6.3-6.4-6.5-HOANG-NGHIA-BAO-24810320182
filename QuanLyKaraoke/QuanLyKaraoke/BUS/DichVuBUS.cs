using QuanLyKaraoke.DAL;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.BUS
{
    public class DichVuBUS
    {
        private readonly DichVuDAL dal = new DichVuDAL();

        public List<DichVu> GetAll()
        {
            return dal.GetAll();
        }
    }
}
