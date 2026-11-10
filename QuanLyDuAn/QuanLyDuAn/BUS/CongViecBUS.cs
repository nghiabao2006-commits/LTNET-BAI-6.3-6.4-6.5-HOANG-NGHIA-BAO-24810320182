using QuanLyDuAn.DAL;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.BUS
{
    public class CongViecBUS
    {
        private readonly CongViecDAL dal = new CongViecDAL();

        public static readonly string[] TrangThaiHopLe = { "To Do", "In Progress", "Review", "Done" };
        public static readonly string[] DoUuTienHopLe = { "Cao", "Trung bình", "Thấp" };

        public List<CongViecView> GetByFilter(int? maDuAn, string trangThai)
        {
            return dal.GetByFilter(maDuAn, trangThai);
        }

        public CongViecView GetById(int maTask)
        {
            return dal.GetById(maTask);
        }

        public int Save(CongViec cv, bool isNew)
        {
            if (cv == null)
            {
                throw new Exception("Dữ liệu công việc không hợp lệ.");
            }
            if (cv.MaDuAn <= 0)
            {
                throw new Exception("Vui lòng chọn dự án cho công việc.");
            }
            if (string.IsNullOrWhiteSpace(cv.TenTask))
            {
                throw new Exception("Tên công việc không được để trống.");
            }
            if (!TrangThaiHopLe.Contains(cv.TrangThai))
            {
                throw new Exception("Trạng thái công việc không hợp lệ.");
            }

            cv.TenTask = cv.TenTask.Trim();
            if (isNew)
            {
                return dal.Insert(cv);
            }

            dal.Update(cv);
            return cv.MaTask;
        }

        public void UpdateStatus(int maTask, string trangThai)
        {
            if (!TrangThaiHopLe.Contains(trangThai))
            {
                throw new Exception("Trạng thái công việc không hợp lệ.");
            }
            dal.UpdateTrangThai(maTask, trangThai);
        }

        public void Delete(int maTask)
        {
            dal.Delete(maTask);
        }
    }
}
