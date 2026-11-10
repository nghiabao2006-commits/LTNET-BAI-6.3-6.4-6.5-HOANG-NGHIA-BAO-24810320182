using System.ComponentModel;
using QuanLyGarage.BUS;
using QuanLyGarage.DTO;

namespace QuanLyGarage.GUI
{
    public partial class MainForm : Form
    {
        private readonly XeBUS xeBUS = new XeBUS();
        private readonly PhuTungBUS phuTungBUS = new PhuTungBUS();
        private readonly PhieuSuaChuaBUS phieuBUS = new PhieuSuaChuaBUS();

        private readonly BindingList<ChiTietSuaChua> chiTietTam = new BindingList<ChiTietSuaChua>();
        private List<PhuTung> danhSachPhuTung = new List<PhuTung>();

        private XeView xeDangChonDanhMuc;
        private XeView xeDangChonPhieu;
        private int? maPhuTungDangChon;
        private int? maPhieuDangChon;

        public MainForm()
        {
            InitializeComponent();

            dgvXe.AutoGenerateColumns = false;
            dgvXe2.AutoGenerateColumns = false;
            dgvPhuTung.AutoGenerateColumns = false;
            dgvPhieu.AutoGenerateColumns = false;
            dgvChiTietPhieu.AutoGenerateColumns = false;
            dgvChiTietTam.AutoGenerateColumns = false;

            dgvChiTietTam.DataSource = chiTietTam;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachXe();
                LoadDanhSachPhuTung();
                LoadDanhSachPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Xe

        private void LoadDanhSachXe()
        {
            List<XeView> danhSach = xeBUS.GetAll();
            dgvXe.DataSource = danhSach;
            dgvXe2.DataSource = danhSach;
            xeDangChonDanhMuc = null;
            LamMoiThongTinXe();
        }

        private void LamMoiThongTinXe()
        {
            txtMaKHXe.Text = "";
            txtTenKHXe.Text = "";
            txtDienThoaiXe.Text = "";
            txtDiaChiXe.Text = "";
            txtHieuXe.Text = "";
            txtBienSoXe.Text = "";
            numNamSX.Value = 2020;
        }

        private void btnTimXe_Click(object sender, EventArgs e)
        {
            try
            {
                XeView xe = xeBUS.FindByPlate(txtTimBienSo.Text);
                if (xe == null)
                {
                    lblKetQuaXe.ForeColor = Color.Firebrick;
                    lblKetQuaXe.Text = "Không tìm thấy xe có biển số \"" + txtTimBienSo.Text.Trim() + "\".";
                    return;
                }

                lblKetQuaXe.ForeColor = Color.DimGray;
                lblKetQuaXe.Text = "Biển số: " + xe.BienSo
                    + "   |   Hiệu xe: " + xe.HieuXe
                    + "   |   Năm sản xuất: " + xe.NamSanXuat
                    + "\nChủ xe: " + xe.TenKH
                    + "   |   Điện thoại: " + xe.DienThoai
                    + "   |   Địa chỉ: " + xe.DiaChi;

                foreach (DataGridViewRow row in dgvXe.Rows)
                {
                    if (row.DataBoundItem is XeView item && item.BienSo == xe.BienSo)
                    {
                        row.Selected = true;
                        dgvXe.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            XeView xe = dgvXe.Rows[e.RowIndex].DataBoundItem as XeView;
            if (xe == null)
            {
                return;
            }

            txtTimBienSo.Text = xe.BienSo;
            btnTimXe_Click(null, null);
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            try
            {
                Xe xe = new Xe
                {
                    BienSo = txtMoiBienSo.Text,
                    HieuXe = txtMoiHieuXe.Text,
                    NamSanXuat = (int)numMoiNamSX.Value
                };

                KhachHang khachHang = new KhachHang
                {
                    TenKH = txtMoiTenKH.Text,
                    DienThoai = txtMoiDienThoai.Text,
                    DiaChi = txtMoiDiaChi.Text
                };

                xeBUS.Add(xe, khachHang);

                MessageBox.Show("Đã thêm xe " + xe.BienSo + " và chủ xe " + khachHang.TenKH + ".",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachXe();

                txtMoiBienSo.Text = "";
                txtMoiTenKH.Text = "";
                txtMoiDienThoai.Text = "";
                txtMoiDiaChi.Text = "";
                txtMoiHieuXe.Text = "";
                numMoiNamSX.Value = 2020;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvXe2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            XeView xe = dgvXe2.Rows[e.RowIndex].DataBoundItem as XeView;
            if (xe == null)
            {
                return;
            }

            xeDangChonDanhMuc = xe;
            txtMaKHXe.Text = xe.MaKH.ToString();
            txtTenKHXe.Text = xe.TenKH;
            txtDienThoaiXe.Text = xe.DienThoai;
            txtDiaChiXe.Text = xe.DiaChi;
            txtHieuXe.Text = xe.HieuXe;
            numNamSX.Value = xe.NamSanXuat >= 1900 ? xe.NamSanXuat : 2020;
            txtBienSoXe.Text = xe.BienSo;
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            if (xeDangChonDanhMuc == null)
            {
                MessageBox.Show("Vui lòng chọn xe cần sửa trong danh sách.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Xe xe = new Xe
                {
                    BienSo = xeDangChonDanhMuc.BienSo,
                    MaKH = xeDangChonDanhMuc.MaKH,
                    HieuXe = txtHieuXe.Text,
                    NamSanXuat = (int)numNamSX.Value
                };

                KhachHang khachHang = new KhachHang
                {
                    MaKH = xeDangChonDanhMuc.MaKH,
                    TenKH = txtTenKHXe.Text,
                    DienThoai = txtDienThoaiXe.Text,
                    DiaChi = txtDiaChiXe.Text
                };

                xeBUS.Update(xe, khachHang);

                MessageBox.Show("Đã cập nhật thông tin xe " + xe.BienSo + ".",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (xeDangChonDanhMuc == null)
            {
                MessageBox.Show("Vui lòng chọn xe cần xóa trong danh sách.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa xe " + xeDangChonDanhMuc.BienSo + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                xeBUS.Delete(xeDangChonDanhMuc.BienSo);
                MessageBox.Show("Đã xóa xe.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiXe_Click(object sender, EventArgs e)
        {
            dgvXe2.ClearSelection();
            LamMoiThongTinXe();
        }

        #endregion

        #region Phu tung

        private void LoadDanhSachPhuTung()
        {
            danhSachPhuTung = phuTungBUS.GetAll();

            dgvPhuTung.DataSource = null;
            dgvPhuTung.DataSource = danhSachPhuTung;

            cboPhuTung.DataSource = null;
            cboPhuTung.DataSource = danhSachPhuTung;
            cboPhuTung.DisplayMember = "ThongTinHienThi";
            cboPhuTung.ValueMember = "MaPhuTung";

            maPhuTungDangChon = null;
            LamMoiThongTinPhuTung();
        }

        private void LamMoiThongTinPhuTung()
        {
            maPhuTungDangChon = null;
            lblMaPhuTung.Text = "Mã phụ tùng: --";
            txtTenPhuTungPT.Text = "";
            numDonGia.Value = 0;
            numSoLuongTon.Value = 0;
        }

        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            PhuTung phuTung = dgvPhuTung.Rows[e.RowIndex].DataBoundItem as PhuTung;
            if (phuTung == null)
            {
                return;
            }

            maPhuTungDangChon = phuTung.MaPhuTung;
            lblMaPhuTung.Text = "Mã phụ tùng: " + phuTung.MaPhuTung;
            txtTenPhuTungPT.Text = phuTung.TenPhuTung;
            numDonGia.Value = phuTung.DonGia;
            numSoLuongTon.Value = phuTung.SoLuongTon;
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            try
            {
                PhuTung phuTung = new PhuTung
                {
                    TenPhuTung = txtTenPhuTungPT.Text,
                    DonGia = numDonGia.Value,
                    SoLuongTon = (int)numSoLuongTon.Value
                };

                phuTungBUS.Save(phuTung, true);

                MessageBox.Show("Đã thêm phụ tùng " + phuTung.TenPhuTung + ".",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachPhuTung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaPT_Click(object sender, EventArgs e)
        {
            if (maPhuTungDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PhuTung phuTung = new PhuTung
                {
                    MaPhuTung = maPhuTungDangChon.Value,
                    TenPhuTung = txtTenPhuTungPT.Text,
                    DonGia = numDonGia.Value,
                    SoLuongTon = (int)numSoLuongTon.Value
                };

                phuTungBUS.Save(phuTung, false);

                MessageBox.Show("Đã cập nhật phụ tùng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachPhuTung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            if (maPhuTungDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa phụ tùng \"" + txtTenPhuTungPT.Text.Trim() + "\"?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                phuTungBUS.Delete(maPhuTungDangChon.Value);
                MessageBox.Show("Đã xóa phụ tùng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhuTung();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiPT_Click(object sender, EventArgs e)
        {
            dgvPhuTung.ClearSelection();
            LamMoiThongTinPhuTung();
        }

        #endregion

        #region Phieu sua chua

        private void LoadDanhSachPhieu()
        {
            dgvPhieu.DataSource = phieuBUS.GetAll();
            dgvChiTietPhieu.DataSource = null;
            lblChiTietPhieu.Text = "Chi tiết phiếu đang chọn";
            btnThanhToan.Enabled = false;
            maPhieuDangChon = null;
        }

        private void btnTimXePhieu_Click(object sender, EventArgs e)
        {
            try
            {
                XeView xe = xeBUS.FindByPlate(txtBienSoPhieu.Text);
                if (xe == null)
                {
                    xeDangChonPhieu = null;
                    lblXePhieu.ForeColor = Color.Firebrick;
                    lblXePhieu.Text = "Không tìm thấy xe có biển số này.";
                    return;
                }

                xeDangChonPhieu = xe;
                lblXePhieu.ForeColor = Color.DimGray;
                lblXePhieu.Text = xe.BienSo + " - " + xe.HieuXe + " - Chủ xe: " + xe.TenKH;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemPhuTungVaoPhieu_Click(object sender, EventArgs e)
        {
            PhuTung phuTung = cboPhuTung.SelectedItem as PhuTung;
            if (phuTung == null)
            {
                MessageBox.Show("Vui lòng chọn phụ tùng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuong = (int)numSoLuongPhieu.Value;
            if (soLuong > phuTung.SoLuongTon)
            {
                MessageBox.Show("Phụ tùng \"" + phuTung.TenPhuTung + "\" chỉ còn "
                    + phuTung.SoLuongTon + " trong kho.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chiTietTam.Any(x => x.MaPhuTung == phuTung.MaPhuTung))
            {
                MessageBox.Show("Phụ tùng này đã có trong phiếu. Hãy xóa dòng cũ nếu muốn nhập lại.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chiTietTam.Add(new ChiTietSuaChua
            {
                MaPhuTung = phuTung.MaPhuTung,
                TenPhuTung = phuTung.TenPhuTung,
                DonGia = phuTung.DonGia,
                SoLuong = soLuong,
                TienCong = numTienCong.Value
            });

            CapNhatTongTamTinh();
            numSoLuongPhieu.Value = 1;
        }

        private void btnXoaDongChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietTam.CurrentRow == null)
            {
                return;
            }

            ChiTietSuaChua chiTiet = dgvChiTietTam.CurrentRow.DataBoundItem as ChiTietSuaChua;
            if (chiTiet == null)
            {
                return;
            }

            chiTietTam.Remove(chiTiet);
            CapNhatTongTamTinh();
        }

        private void CapNhatTongTamTinh()
        {
            decimal tong = 0;
            foreach (ChiTietSuaChua chiTiet in chiTietTam)
            {
                tong += chiTiet.ThanhTien;
            }

            lblTongTamTinh.Text = "Tổng tạm tính: " + tong.ToString("N0") + " đ";
        }

        private void btnHoanTatPhieu_Click(object sender, EventArgs e)
        {
            if (xeDangChonPhieu == null)
            {
                MessageBox.Show("Vui lòng tìm xe theo biển số trước khi lập phiếu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (chiTietTam.Count == 0)
            {
                MessageBox.Show("Phiếu sửa chữa phải có ít nhất một phụ tùng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Hoàn tất phiếu sửa chữa cho xe " + xeDangChonPhieu.BienSo
                + "?\nPhụ tùng sẽ được trừ khỏi kho ngay sau khi lưu.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int maPhieu = phieuBUS.CreateInvoice(
                    xeDangChonPhieu.BienSo, txtNoiDungSua.Text, chiTietTam.ToList());

                MessageBox.Show("Đã tạo phiếu sửa chữa số " + maPhieu
                    + " và trừ phụ tùng trong kho.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LamMoiPhieu();
                LoadDanhSachPhuTung();
                LoadDanhSachPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoiPhieu()
        {
            xeDangChonPhieu = null;
            txtBienSoPhieu.Text = "";
            txtNoiDungSua.Text = "";
            lblXePhieu.ForeColor = Color.DimGray;
            lblXePhieu.Text = "Nhập biển số và bấm Tìm xe.";
            chiTietTam.Clear();
            CapNhatTongTamTinh();
            numSoLuongPhieu.Value = 1;
            numTienCong.Value = 50000;
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            PhieuSuaChua phieu = dgvPhieu.Rows[e.RowIndex].DataBoundItem as PhieuSuaChua;
            if (phieu == null)
            {
                return;
            }

            try
            {
                maPhieuDangChon = phieu.MaPhieu;
                dgvChiTietPhieu.DataSource = phieuBUS.GetDetails(phieu.MaPhieu);
                lblChiTietPhieu.Text = "Chi tiết phiếu #" + phieu.MaPhieu + " - " + phieu.TrangThai;
                btnThanhToan.Enabled = phieu.TrangThai == "Đã hoàn thành";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maPhieuDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Xác nhận thanh toán phiếu số " + maPhieuDangChon.Value + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                decimal tongTien = phieuBUS.Pay(maPhieuDangChon.Value);

                MessageBox.Show("Đã thanh toán phiếu số " + maPhieuDangChon.Value
                    + ".\nTổng tiền: " + tongTien.ToString("N0") + " đ",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSachPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
