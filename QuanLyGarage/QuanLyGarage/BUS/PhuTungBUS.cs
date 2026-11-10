using QuanLyGarage.DAL;
using QuanLyGarage.DTO;

namespace QuanLyGarage.BUS
{
    public class PhuTungBUS
    {
        private readonly PhuTungDAL dal = new PhuTungDAL();

        public List<PhuTung> GetAll()
        {
            return dal.GetAll();
        }

        public void Save(PhuTung phuTung, bool isNew)
        {
            if (phuTung == null)
            {
                throw new Exception("Dữ liệu phụ tùng không hợp lệ.");
            }
            if (string.IsNullOrWhiteSpace(phuTung.TenPhuTung))
            {
                throw new Exception("Tên phụ tùng không được để trống.");
            }
            if (phuTung.DonGia < 0 || phuTung.SoLuongTon < 0)
            {
                throw new Exception("Đơn giá và số lượng tồn không được âm.");
            }

            phuTung.TenPhuTung = phuTung.TenPhuTung.Trim();
            if (isNew)
            {
                dal.Insert(phuTung);
            }
            else
            {
                dal.Update(phuTung);
            }
        }

        public void Delete(int maPhuTung)
        {
            if (dal.CountUsage(maPhuTung) > 0)
            {
                throw new Exception("Phụ tùng đã được dùng trong phiếu sửa chữa nên không thể xóa.");
            }
            dal.Delete(maPhuTung);
        }
    }
}
