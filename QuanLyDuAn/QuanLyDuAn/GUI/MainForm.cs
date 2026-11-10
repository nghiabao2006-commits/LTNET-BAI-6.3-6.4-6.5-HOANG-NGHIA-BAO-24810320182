using QuanLyDuAn.BUS;
using QuanLyDuAn.DTO;

namespace QuanLyDuAn.GUI
{
    public partial class MainForm : Form
    {
        private readonly DuAnBUS duAnBUS = new DuAnBUS();
        private readonly ThanhVienBUS thanhVienBUS = new ThanhVienBUS();
        private readonly CongViecBUS congViecBUS = new CongViecBUS();
        private readonly BaoCaoBUS baoCaoBUS = new BaoCaoBUS();

        private List<DuAn> danhSachDuAn = new List<DuAn>();
        private int maTaskDangChon = 0;
        private int maThanhVienDangChon = 0;
        private bool dangTaiDuLieu = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            KhoiTaoComboBox();
            TaiDuLieu();
        }

        private void KhoiTaoComboBox()
        {
            cboTrangThaiDuAn.Items.AddRange(new object[] { "Đang chạy", "Hoàn thành", "Tạm dừng" });
            cboTrangThaiDuAn.SelectedIndex = 0;

            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "To Do", "In Progress", "Review", "Done" });
            cboLocTrangThai.SelectedIndex = 0;

            cboCVUuTien.Items.AddRange(CongViecBUS.DoUuTienHopLe);
            cboCVUuTien.SelectedIndex = 1;

            cboCVTrangThai.Items.AddRange(CongViecBUS.TrangThaiHopLe);
            cboCVTrangThai.SelectedIndex = 0;
        }

        private void TaiDuLieu()
        {
            try
            {
                dangTaiDuLieu = true;

                danhSachDuAn = duAnBUS.GetAll();
                dgvDuAn.DataSource = danhSachDuAn;

                List<DuAn> dsLoc = new List<DuAn>();
                dsLoc.Add(new DuAn { MaDuAn = 0, TenDuAn = "Tất cả dự án" });
                dsLoc.AddRange(danhSachDuAn);

                GanDuLieuCombo(cboLocDuAn, dsLoc);
                GanDuLieuCombo(cboCVDuAn, danhSachDuAn);
                GanDuLieuCombo(cboKanbanDuAn, danhSachDuAn);
                GanDuLieuCombo(cboBCDuAn, danhSachDuAn);

                LoadThanhVien();
                LoadCongViec();

                dangTaiDuLieu = false;

                LoadKanban();
            }
            catch (Exception ex)
            {
                dangTaiDuLieu = false;
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GanDuLieuCombo(ComboBox cbo, List<DuAn> danhSach)
        {
            cbo.DisplayMember = "TenDuAn";
            cbo.ValueMember = "MaDuAn";
            cbo.DataSource = new List<DuAn>(danhSach);
        }

        private void LoadThanhVien()
        {
            dgvThanhVien.DataSource = thanhVienBUS.GetAll();
        }

        private void LoadCongViec()
        {
            int maDuAn = LayMaDuAn(cboLocDuAn);
            string trangThai = cboLocTrangThai.Text == "Tất cả" ? null : cboLocTrangThai.Text;

            dgvCongViec.DataSource = congViecBUS.GetByFilter(
                maDuAn > 0 ? maDuAn : (int?)null, trangThai);
        }

        private int LayMaDuAn(ComboBox cbo)
        {
            if (cbo.SelectedValue == null)
            {
                return 0;
            }
            int maDuAn;
            return int.TryParse(cbo.SelectedValue.ToString(), out maDuAn) ? maDuAn : 0;
        }

        // ------------------------- DỰ ÁN -------------------------

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            try
            {
                DuAn duAn = LayDuAnTuGiaoDien();
                duAnBUS.Save(duAn, true);
                LamMoiDuAn();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaDuAn_Click(object sender, EventArgs e)
        {
            try
            {
                int maDuAn;
                if (!int.TryParse(txtMaDuAn.Text, out maDuAn))
                {
                    MessageBox.Show("Vui lòng chọn dự án cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DuAn duAn = LayDuAnTuGiaoDien();
                duAn.MaDuAn = maDuAn;
                duAnBUS.Save(duAn, false);
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDuAn_Click(object sender, EventArgs e)
        {
            try
            {
                int maDuAn;
                if (!int.TryParse(txtMaDuAn.Text, out maDuAn))
                {
                    MessageBox.Show("Vui lòng chọn dự án cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn xóa dự án này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traLoi == DialogResult.Yes)
                {
                    duAnBUS.Delete(maDuAn);
                    LamMoiDuAn();
                    TaiDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiDuAn_Click(object sender, EventArgs e)
        {
            LamMoiDuAn();
        }

        private DuAn LayDuAnTuGiaoDien()
        {
            return new DuAn
            {
                TenDuAn = txtTenDuAn.Text.Trim(),
                NgayBatDau = dtpNgayBatDau.Value.Date,
                NgayKetThuc = dtpNgayKetThuc.Value.Date,
                TrangThai = cboTrangThaiDuAn.Text
            };
        }

        private void LamMoiDuAn()
        {
            txtMaDuAn.Text = "";
            txtTenDuAn.Clear();
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddMonths(1);
            cboTrangThaiDuAn.SelectedIndex = 0;
            dgvDuAn.ClearSelection();
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DuAn duAn = dgvDuAn.Rows[e.RowIndex].DataBoundItem as DuAn;
            if (duAn == null)
            {
                return;
            }

            txtMaDuAn.Text = duAn.MaDuAn.ToString();
            txtTenDuAn.Text = duAn.TenDuAn;
            if (duAn.NgayBatDau.HasValue)
            {
                dtpNgayBatDau.Value = duAn.NgayBatDau.Value;
            }
            if (duAn.NgayKetThuc.HasValue)
            {
                dtpNgayKetThuc.Value = duAn.NgayKetThuc.Value;
            }
            cboTrangThaiDuAn.Text = duAn.TrangThai;
        }

        // ----------------------- CÔNG VIỆC ------------------------

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCongViec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            cboLocDuAn.SelectedIndex = 0;
            cboLocTrangThai.SelectedIndex = 0;
            btnLoc_Click(sender, e);
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            try
            {
                CongViec cv = LayCongViecTuGiaoDien();
                congViecBUS.Save(cv, true);
                LamMoiCongViec();
                LoadCongViec();
                LoadKanban();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            try
            {
                if (maTaskDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn công việc cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CongViec cv = LayCongViecTuGiaoDien();
                cv.MaTask = maTaskDangChon;
                congViecBUS.Save(cv, false);
                LamMoiCongViec();
                LoadCongViec();
                LoadKanban();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            try
            {
                if (maTaskDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn công việc cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn xóa công việc này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traLoi == DialogResult.Yes)
                {
                    congViecBUS.Delete(maTaskDangChon);
                    LamMoiCongViec();
                    LoadCongViec();
                    LoadKanban();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (maTaskDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn công việc cần phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CongViecView cv = dgvCongViec.CurrentRow == null
                    ? null
                    : dgvCongViec.CurrentRow.DataBoundItem as CongViecView;

                using (FormPhanCong form = new FormPhanCong(maTaskDangChon, cv == null ? "" : cv.TenTask))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadCongViec();
                        LoadKanban();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            try
            {
                if (maTaskDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn công việc cần đổi trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                congViecBUS.UpdateStatus(maTaskDangChon, cboCVTrangThai.Text);
                LoadCongViec();
                LoadKanban();
                MessageBox.Show("Đã cập nhật trạng thái công việc.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private CongViec LayCongViecTuGiaoDien()
        {
            return new CongViec
            {
                MaDuAn = LayMaDuAn(cboCVDuAn),
                TenTask = txtCVTen.Text.Trim(),
                MoTa = txtCVMoTa.Text.Trim(),
                HanNop = dtpCVHanNop.Checked ? dtpCVHanNop.Value : (DateTime?)null,
                DoUuTien = cboCVUuTien.Text,
                TrangThai = cboCVTrangThai.Text
            };
        }

        private void LamMoiCongViec()
        {
            maTaskDangChon = 0;
            txtCVTen.Clear();
            txtCVMoTa.Clear();
            dtpCVHanNop.Value = DateTime.Today.AddDays(7);
            dtpCVHanNop.Checked = true;
            cboCVUuTien.SelectedIndex = 1;
            cboCVTrangThai.SelectedIndex = 0;
            dgvCongViec.ClearSelection();
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            CongViecView cv = dgvCongViec.Rows[e.RowIndex].DataBoundItem as CongViecView;
            if (cv == null)
            {
                return;
            }

            maTaskDangChon = cv.MaTask;
            txtCVTen.Text = cv.TenTask;
            txtCVMoTa.Text = cv.MoTa;
            cboCVDuAn.SelectedValue = cv.MaDuAn;
            if (cv.HanNop.HasValue)
            {
                dtpCVHanNop.Value = cv.HanNop.Value;
                dtpCVHanNop.Checked = true;
            }
            else
            {
                dtpCVHanNop.Checked = false;
            }
            cboCVUuTien.Text = cv.DoUuTien;
            cboCVTrangThai.Text = cv.TrangThai;
        }

        // ------------------------ KANBAN -------------------------

        private void LoadKanban()
        {
            flowToDo.Controls.Clear();
            flowInProgress.Controls.Clear();
            flowReview.Controls.Clear();
            flowDone.Controls.Clear();

            int maDuAn = LayMaDuAn(cboKanbanDuAn);
            if (maDuAn <= 0)
            {
                CapNhatTieuDeKanban(0, 0, 0, 0);
                return;
            }

            List<CongViecView> danhSach = congViecBUS.GetByFilter(maDuAn, null);
            foreach (CongViecView cv in danhSach)
            {
                if (cv.TrangThai == "To Do")
                {
                    ThemTheKanban(flowToDo, cv);
                }
                else if (cv.TrangThai == "In Progress")
                {
                    ThemTheKanban(flowInProgress, cv);
                }
                else if (cv.TrangThai == "Review")
                {
                    ThemTheKanban(flowReview, cv);
                }
                else if (cv.TrangThai == "Done")
                {
                    ThemTheKanban(flowDone, cv);
                }
            }

            CapNhatTieuDeKanban(
                flowToDo.Controls.Count,
                flowInProgress.Controls.Count,
                flowReview.Controls.Count,
                flowDone.Controls.Count);
        }

        private void CapNhatTieuDeKanban(int toDo, int inProgress, int review, int done)
        {
            grpToDo.Text = "To Do (" + toDo + ")";
            grpInProgress.Text = "In Progress (" + inProgress + ")";
            grpReview.Text = "Review (" + review + ")";
            grpDone.Text = "Done (" + done + ")";
        }

        private void ThemTheKanban(FlowLayoutPanel flow, CongViecView cv)
        {
            Panel the = new Panel();
            the.Width = 240;
            the.Height = 105;
            the.BackColor = Color.White;
            the.BorderStyle = BorderStyle.FixedSingle;
            the.Margin = new Padding(3);

            Label lblTen = new Label();
            lblTen.Text = cv.TenTask;
            lblTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTen.Location = new Point(6, 6);
            lblTen.Size = new Size(226, 36);
            lblTen.AutoEllipsis = true;

            Label lblUuTien = new Label();
            lblUuTien.Text = "Ưu tiên: " + cv.DoUuTien;
            lblUuTien.Location = new Point(6, 47);
            lblUuTien.AutoSize = true;

            Label lblHanNop = new Label();
            lblHanNop.Text = "Hạn nộp: " + (cv.HanNop.HasValue ? cv.HanNop.Value.ToString("dd/MM/yyyy") : "Chưa có");
            lblHanNop.Location = new Point(6, 65);
            lblHanNop.AutoSize = true;

            Label lblThanhVien = new Label();
            lblThanhVien.Text = string.IsNullOrWhiteSpace(cv.DanhSachThanhVien) ? "Chưa phân công" : cv.DanhSachThanhVien;
            lblThanhVien.Location = new Point(6, 83);
            lblThanhVien.Size = new Size(226, 18);
            lblThanhVien.AutoEllipsis = true;
            lblThanhVien.ForeColor = Color.DimGray;

            the.Controls.Add(lblTen);
            the.Controls.Add(lblUuTien);
            the.Controls.Add(lblHanNop);
            the.Controls.Add(lblThanhVien);
            flow.Controls.Add(the);
        }

        private void cboKanbanDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dangTaiDuLieu)
            {
                LoadKanban();
            }
        }

        private void btnKanbanRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadKanban();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------- THÀNH VIÊN -----------------------

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhVien tv = LayThanhVienTuGiaoDien();
                thanhVienBUS.Save(tv, true);
                LamMoiThanhVien();
                LoadThanhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSuaTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (maThanhVienDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn thành viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ThanhVien tv = LayThanhVienTuGiaoDien();
                tv.MaThanhVien = maThanhVienDangChon;
                thanhVienBUS.Save(tv, false);
                LamMoiThanhVien();
                LoadThanhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (maThanhVienDangChon <= 0)
                {
                    MessageBox.Show("Vui lòng chọn thành viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult traLoi = MessageBox.Show("Bạn có chắc muốn xóa thành viên này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traLoi == DialogResult.Yes)
                {
                    thanhVienBUS.Delete(maThanhVienDangChon);
                    LamMoiThanhVien();
                    LoadThanhVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoiTV_Click(object sender, EventArgs e)
        {
            LamMoiThanhVien();
        }

        private ThanhVien LayThanhVienTuGiaoDien()
        {
            return new ThanhVien
            {
                HoTen = txtTVHoTen.Text.Trim(),
                Email = txtTVEmail.Text.Trim(),
                ChuyenMon = txtTVChuyenMon.Text.Trim()
            };
        }

        private void LamMoiThanhVien()
        {
            maThanhVienDangChon = 0;
            lblTVMa.Text = "Mã thành viên: --";
            txtTVHoTen.Clear();
            txtTVEmail.Clear();
            txtTVChuyenMon.Clear();
            dgvThanhVien.ClearSelection();
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            ThanhVien tv = dgvThanhVien.Rows[e.RowIndex].DataBoundItem as ThanhVien;
            if (tv == null)
            {
                return;
            }

            maThanhVienDangChon = tv.MaThanhVien;
            lblTVMa.Text = "Mã thành viên: " + tv.MaThanhVien;
            txtTVHoTen.Text = tv.HoTen;
            txtTVEmail.Text = tv.Email;
            txtTVChuyenMon.Text = tv.ChuyenMon;
        }

        // ------------------------ BÁO CÁO ------------------------

        private void btnTreHan_Click(object sender, EventArgs e)
        {
            try
            {
                List<CongViecTreHan> danhSach = baoCaoBUS.GetOverdue();
                dgvTreHan.DataSource = danhSach;
                grpTreHan.Text = "Danh sách công việc trễ hạn (SqlDataReader) - " + danhSach.Count + " công việc";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                int maDuAn = LayMaDuAn(cboBCDuAn);
                if (maDuAn <= 0)
                {
                    MessageBox.Show("Vui lòng chọn dự án cần thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvThongKe.DataSource = baoCaoBUS.GetStatistics(maDuAn);
                decimal tyLe = baoCaoBUS.GetCompletionRate(maDuAn);
                lblTyLeTong.Text = "Tỷ lệ hoàn thành dự án: " + tyLe.ToString("0.0") + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
