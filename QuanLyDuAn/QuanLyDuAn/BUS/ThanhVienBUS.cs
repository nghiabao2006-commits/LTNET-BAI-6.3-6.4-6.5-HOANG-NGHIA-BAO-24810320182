using QuanLyDuAn.DAL;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.BUS
{
    public class ThanhVienBUS
    {
        private readonly ThanhVienDAL dal = new ThanhVienDAL();

        public List<ThanhVien> GetAll()
        {
            return dal.GetAll();
        }

        public void Save(ThanhVien tv, bool isNew)
        {
            if (tv == null)
            {
                throw new Exception("Dữ liệu thành viên không hợp lệ.");
            }
            if (string.IsNullOrWhiteSpace(tv.HoTen))
            {
                throw new Exception("Họ tên không được để trống.");
            }
            if (!string.IsNullOrWhiteSpace(tv.Email) && !tv.Email.Contains("@"))
            {
                throw new Exception("Email chưa đúng định dạng.");
            }

            tv.HoTen = tv.HoTen.Trim();
            tv.Email = tv.Email == null ? "" : tv.Email.Trim();
            tv.ChuyenMon = tv.ChuyenMon == null ? "" : tv.ChuyenMon.Trim();

            if (isNew)
            {
                dal.Insert(tv);
            }
            else
            {
                dal.Update(tv);
            }
        }

        public void Delete(int maThanhVien)
        {
            if (dal.CountAssignments(maThanhVien) > 0)
            {
                throw new Exception("Thành viên đang được phân công công việc nên không thể xóa.");
            }
            dal.Delete(maThanhVien);
        }
    }
}
