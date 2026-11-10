using QuanLyDuAn.DAL;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.BUS
{
    public class DuAnBUS
    {
        private readonly DuAnDAL dal = new DuAnDAL();

        public List<DuAn> GetAll()
        {
            return dal.GetAll();
        }

        public int Save(DuAn duAn, bool isNew)
        {
            if (duAn == null)
            {
                throw new Exception("Dữ liệu dự án không hợp lệ.");
            }
            if (string.IsNullOrWhiteSpace(duAn.TenDuAn))
            {
                throw new Exception("Tên dự án không được để trống.");
            }
            if (duAn.NgayBatDau.HasValue && duAn.NgayKetThuc.HasValue
                && duAn.NgayKetThuc.Value.Date < duAn.NgayBatDau.Value.Date)
            {
                throw new Exception("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
            }

            duAn.TenDuAn = duAn.TenDuAn.Trim();
            if (isNew)
            {
                return dal.Insert(duAn);
            }

            dal.Update(duAn);
            return duAn.MaDuAn;
        }

        public void Delete(int maDuAn)
        {
            if (dal.CountTasks(maDuAn) > 0)
            {
                throw new Exception("Dự án đang có công việc nên không thể xóa.");
            }
            dal.Delete(maDuAn);
        }
    }
}
