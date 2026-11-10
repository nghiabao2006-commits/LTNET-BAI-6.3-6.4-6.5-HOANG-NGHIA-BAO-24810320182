using QuanLyDuAn.DAL;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.BUS
{
    public class PhanCongBUS
    {
        private readonly PhanCongDAL dal = new PhanCongDAL();
        private readonly ThanhVienDAL thanhVienDAL = new ThanhVienDAL();

        public List<ThanhVien> GetAllMembers()
        {
            return thanhVienDAL.GetAll();
        }

        public List<PhanCong> GetByTask(int maTask)
        {
            return dal.GetByTask(maTask);
        }

        public List<int> GetMemberIds(int maTask)
        {
            return dal.GetMemberIds(maTask);
        }

        public void SaveAssignments(int maTask, List<int> danhSachMaThanhVien)
        {
            if (maTask <= 0)
            {
                throw new Exception("Chưa chọn công việc để phân công.");
            }
            if (danhSachMaThanhVien == null || danhSachMaThanhVien.Count == 0)
            {
                throw new Exception("Vui lòng chọn ít nhất một thành viên.");
            }
            dal.SaveAssignments(maTask, danhSachMaThanhVien);
        }
    }
}
