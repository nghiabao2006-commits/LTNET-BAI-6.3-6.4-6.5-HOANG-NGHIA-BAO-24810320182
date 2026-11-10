using System.Data;
using QuanLyKaraoke.BUS;
using QuanLyKaraoke.DTO;

namespace QuanLyKaraoke.GUI
{
    public partial class MainForm : Form
    {
        private readonly PhongHatBUS phongBUS = new PhongHatBUS();
        private readonly DichVuBUS dichVuBUS = new DichVuBUS();
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();

        private List<PhongHat> danhSachPhong = new List<PhongHat>();
        private PhongHat phongDangChon;
        private HoaDon hoaDonDangChon;

        public MainForm()
        {
            InitializeComponent();

            dgvDichVuDaGoi.AutoGenerateColumns = false;
            dgvHoaDon.AutoGenerateColumns = false;
            dgvChiTietHoaDon.AutoGenerateColumns = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachDichVu();
                LoadSoDoPhong();
                LoadDanhSachHoaDon();
                XoaPhongDangChon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region So do phong

        private void LoadSoDoPhong()
        {
            danhSachPhong = phongBUS.GetAll();
            flowPhong.Controls.Clear();

            foreach (PhongHat phong in danhSachPhong)
            {
                Button nut = new Button();
                nut.Width = 165;
                nut.Height = 95;
                nut.Margin = new Padding(8);
                nut.FlatStyle = FlatStyle.Flat;
                nut.UseVisualStyleBackColor = false;
                nut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                nut.TextAlign = ContentAlignment.MiddleCenter;
                nut.BackColor = phong.TrangThai == "Trống" ? Color.LightGreen : Color.LightCoral;
                nut.Text = phong.TenPhong + "\n" + phong.LoaiPhong
                    + " - " + phong.GiaTheoGio.ToString("N0") + " đ/giờ\n" + phong.TrangThai;
                nut.Tag = phong;
                nut.Click += PhongButton_Click;
                flowPhong.Controls.Add(nut);
            }
        }

        private void PhongButton_Click(object sender, EventArgs e)
        {
            Button nut = sender as Button;
            if (nut == null || nut.Tag == null)
            {
                return;
            }

            PhongHat phong = nut.Tag as PhongHat;
            ChonPhong(phong.MaPhong);
        }

        private void ChonPhong(int maPhong)
        {
            PhongHat phong = danhSachPhong.FirstOrDefault(x => x.MaPhong == maPhong);
            if (phong == null)
            {
                return;
            }

            phongDangChon = phong;
            hoaDonDangChon = null;

            lblPhongChon.Text = phong.TenPhong;
            lblThongTinPhong.Text = "Loại phòng: " + phong.LoaiPhong
                + "   |   Giá: " + phong.GiaTheoGio.ToString("N0") + " đ/giờ"
                + "\nTrạng thái: " + phong.TrangThai;
            btnMoPhong.Enabled = phong.TrangThai == "Trống";

            if (!phong.DangHat)
            {
                lblGioVao.Text = "Phòng đang trống, bấm Mở phòng để bắt đầu hát.";
                dgvDichVuDaGoi.DataSource = null;
                btnThanhToan.Enabled = false;
                BatGoiDichVu(false);
                HienThiTien(0, 0);
                return;
            }

            try
            {
                hoaDonDangChon = hoaDonBUS.GetDangMo(phong.MaPhong);
                if (hoaDonDangChon == null)
                {
                    lblGioVao.Text = "Phòng đang hát nhưng không tìm thấy hóa đơn mở.";
                    dgvDichVuDaGoi.DataSource = null;
                    btnThanhToan.Enabled = false;
                    BatGoiDichVu(false);
                    HienThiTien(0, 0);
                    return;
                }

                int soPhut = Math.Max(0, (int)(DateTime.Now - hoaDonDangChon.GioVao).TotalMinutes);
                lblGioVao.Text = "Giờ vào: " + hoaDonDangChon.GioVao.ToString("dd/MM/yyyy HH:mm")
                    + "   |   Đã hát: " + soPhut + " phút";

                dgvDichVuDaGoi.DataSource = hoaDonBUS.GetChiTietTable(hoaDonDangChon.MaHD);
                btnThanhToan.Enabled = true;
                BatGoiDichVu(true);
                CapNhatTienPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatTienPhong()
        {
            if (phongDangChon == null || hoaDonDangChon == null)
            {
                HienThiTien(0, 0);
                return;
            }

            double soPhut = (DateTime.Now - hoaDonDangChon.GioVao).TotalMinutes;
            int soGio = (int)Math.Ceiling(soPhut / 60.0);
            if (soGio < 1)
            {
                soGio = 1;
            }

            decimal tienPhong = soGio * phongDangChon.GiaTheoGio;
            HienThiTien(tienPhong, hoaDonDangChon.TongTienDichVu, soGio);
        }

        private void HienThiTien(decimal tienPhong, decimal tienDichVu)
        {
            HienThiTien(tienPhong, tienDichVu, 0);
        }

        private void HienThiTien(decimal tienPhong, decimal tienDichVu, int soGio)
        {
            lblTongDichVu.Text = "Tiền dịch vụ: " + tienDichVu.ToString("N0") + " đ";
            lblTienPhong.Text = soGio > 0
                ? "Tiền phòng (" + soGio + " giờ): " + tienPhong.ToString("N0") + " đ"
                : "Tiền phòng: " + tienPhong.ToString("N0") + " đ";
            lblTongCong.Text = "Tổng cộng: " + (tienPhong + tienDichVu).ToString("N0") + " đ";
        }

        private void XoaPhongDangChon()
        {
            phongDangChon = null;
            hoaDonDangChon = null;
            lblPhongChon.Text = "Chưa chọn phòng";
            lblThongTinPhong.Text = "Chọn một phòng trên sơ đồ để xem thông tin.";
            lblGioVao.Text = "";
            btnMoPhong.Enabled = false;
            btnThanhToan.Enabled = false;
            BatGoiDichVu(false);
            dgvDichVuDaGoi.DataSource = null;
            HienThiTien(0, 0);
        }

        private void BatGoiDichVu(bool bat)
        {
            cboDichVu.Enabled = bat;
            numSoLuongDV.Enabled = bat;
            btnGoiDichVu.Enabled = bat;
        }

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null || phongDangChon.DangHat)
            {
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Mở phòng " + phongDangChon.TenPhong + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            int maPhong = phongDangChon.MaPhong;

            try
            {
                int maHD = phongBUS.MoPhong(maPhong);
                MessageBox.Show("Đã mở phòng " + phongDangChon.TenPhong
                    + ".\nHóa đơn số " + maHD + " đã được tạo.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSoDoPhong();
                ChonPhong(maPhong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Dich vu

        private void LoadDanhSachDichVu()
        {
            List<DichVu> danhSach = dichVuBUS.GetAll();
            cboDichVu.DataSource = null;
            cboDichVu.DataSource = danhSach;
            cboDichVu.DisplayMember = "ThongTinHienThi";
            cboDichVu.ValueMember = "MaDV";
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DichVu dichVu = cboDichVu.SelectedItem as DichVu;
            lblTonKhoDV.Text = dichVu == null
                ? "Tồn kho: --"
                : "Tồn kho: " + dichVu.TonKho;
        }

        private void btnGoiDichVu_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null || hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phòng đang hát trước khi gọi dịch vụ.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DichVu dichVu = cboDichVu.SelectedItem as DichVu;
            if (dichVu == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                hoaDonBUS.GoiDichVu(hoaDonDangChon.MaHD, dichVu.MaDV, (int)numSoLuongDV.Value);

                ChonPhong(phongDangChon.MaPhong);
                numSoLuongDV.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Thanh toan

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null || hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phòng đang hát cần thanh toán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Thanh toán và trả phòng " + phongDangChon.TenPhong + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
            {
                return;
            }

            try
            {
                HoaDon ketQuaThanhToan = hoaDonBUS.ThanhToan(hoaDonDangChon.MaHD);

                MessageBox.Show(
                    "Đã thanh toán hóa đơn số " + ketQuaThanhToan.MaHD
                    + "\nPhòng: " + ketQuaThanhToan.TenPhong
                    + "\nGiờ vào: " + ketQuaThanhToan.GioVao.ToString("dd/MM/yyyy HH:mm")
                    + "  -  Giờ ra: " + ketQuaThanhToan.GioRa.Value.ToString("dd/MM/yyyy HH:mm")
                    + "\nTiền phòng: " + ketQuaThanhToan.TongTienPhong.ToString("N0") + " đ"
                    + "\nTiền dịch vụ: " + ketQuaThanhToan.TongTienDichVu.ToString("N0") + " đ"
                    + "\nTổng cộng: " + ketQuaThanhToan.TongCong.ToString("N0") + " đ",
                    "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSoDoPhong();
                LoadDanhSachHoaDon();
                XoaPhongDangChon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Hoa don

        private void LoadDanhSachHoaDon()
        {
            dgvHoaDon.DataSource = hoaDonBUS.GetAll();
            dgvChiTietHoaDon.DataSource = null;
            grpChiTietHoaDon.Text = "Chi tiết dịch vụ của hóa đơn";
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            HoaDon hoaDon = dgvHoaDon.Rows[e.RowIndex].DataBoundItem as HoaDon;
            if (hoaDon == null)
            {
                return;
            }

            try
            {
                dgvChiTietHoaDon.DataSource = hoaDonBUS.GetChiTietTable(hoaDon.MaHD);
                grpChiTietHoaDon.Text = "Chi tiết dịch vụ - Hóa đơn số " + hoaDon.MaHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLaiHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachHoaDon();
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
