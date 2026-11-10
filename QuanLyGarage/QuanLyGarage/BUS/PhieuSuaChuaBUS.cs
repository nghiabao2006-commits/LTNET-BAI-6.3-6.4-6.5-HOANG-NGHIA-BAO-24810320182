using QuanLyGarage.DAL;
using QuanLyGarage.DTO;

namespace QuanLyGarage.BUS
{
    public class PhieuSuaChuaBUS
    {
        private readonly PhieuSuaChuaDAL dal = new PhieuSuaChuaDAL();

        public List<PhieuSuaChua> GetAll()
        {
            return dal.GetAll();
        }

        public List<ChiTietSuaChua> GetDetails(int maPhieu)
        {
            return dal.GetDetails(maPhieu);
        }

        public int CreateInvoice(string bienSo, string noiDung, List<ChiTietSuaChua> chiTiet)
        {
            if (string.IsNullOrWhiteSpace(bienSo))
            {
                throw new Exception("Vui lòng nhập biển số xe.");
            }
            if (chiTiet == null || chiTiet.Count == 0)
            {
                throw new Exception("Phiếu sửa chữa phải có ít nhất một phụ tùng.");
            }
            if (chiTiet.Any(x => x.SoLuong <= 0))
            {
                throw new Exception("Số lượng phụ tùng phải lớn hơn 0.");
            }

            return dal.CreateInvoice(bienSo.Trim(), noiDung == null ? "" : noiDung.Trim(), chiTiet);
        }

        public decimal Pay(int maPhieu)
        {
            if (maPhieu <= 0)
            {
                throw new Exception("Vui lòng chọn phiếu sửa chữa cần thanh toán.");
            }
            return dal.Pay(maPhieu);
        }
    }
}
