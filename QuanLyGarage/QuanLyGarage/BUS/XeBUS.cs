using Microsoft.Data.SqlClient;
using QuanLyGarage.DAL;
using QuanLyGarage.DTO;

namespace QuanLyGarage.BUS
{
    public class XeBUS
    {
        private readonly XeDAL dal = new XeDAL();

        public List<XeView> GetAll()
        {
            return dal.GetAll();
        }

        public XeView FindByPlate(string bienSo)
        {
            if (string.IsNullOrWhiteSpace(bienSo))
            {
                throw new Exception("Vui lòng nhập biển số xe.");
            }
            return dal.FindByPlate(bienSo.Trim());
        }

        public void Add(Xe xe, KhachHang khachHang)
        {
            KiemTraThongTin(xe, khachHang);

            try
            {
                dal.Add(xe, khachHang);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new Exception("Biển số xe hoặc số điện thoại đã tồn tại.");
            }
        }

        public void Update(Xe xe, KhachHang khachHang)
        {
            KiemTraThongTin(xe, khachHang);

            try
            {
                dal.Update(xe, khachHang);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new Exception("Số điện thoại đã được dùng cho chủ xe khác.");
            }
        }

        public void Delete(string bienSo)
        {
            if (dal.CountInvoices(bienSo) > 0)
            {
                throw new Exception("Xe đã có phiếu sửa chữa nên không thể xóa.");
            }
            dal.Delete(bienSo);
        }

        private void KiemTraThongTin(Xe xe, KhachHang khachHang)
        {
            if (string.IsNullOrWhiteSpace(xe.BienSo))
            {
                throw new Exception("Biển số xe không được để trống.");
            }
            if (string.IsNullOrWhiteSpace(khachHang.TenKH))
            {
                throw new Exception("Tên chủ xe không được để trống.");
            }
            if (xe.NamSanXuat > 0 && (xe.NamSanXuat < 1900 || xe.NamSanXuat > DateTime.Now.Year + 1))
            {
                throw new Exception("Năm sản xuất không hợp lệ.");
            }

            xe.BienSo = xe.BienSo.Trim().ToUpper();
            khachHang.TenKH = khachHang.TenKH.Trim();
            khachHang.DienThoai = khachHang.DienThoai == null ? "" : khachHang.DienThoai.Trim();
            khachHang.DiaChi = khachHang.DiaChi == null ? "" : khachHang.DiaChi.Trim();
            xe.HieuXe = xe.HieuXe == null ? "" : xe.HieuXe.Trim();
        }
    }
}
