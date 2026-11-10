namespace QuanLyDuAn.GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDuAn = new System.Windows.Forms.TabPage();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.colMaDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDuAn = new System.Windows.Forms.GroupBox();
            this.lblMaDuAn = new System.Windows.Forms.Label();
            this.txtMaDuAn = new System.Windows.Forms.TextBox();
            this.lblTenDuAn = new System.Windows.Forms.Label();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThaiDuAn = new System.Windows.Forms.Label();
            this.cboTrangThaiDuAn = new System.Windows.Forms.ComboBox();
            this.btnThemDuAn = new System.Windows.Forms.Button();
            this.btnSuaDuAn = new System.Windows.Forms.Button();
            this.btnXoaDuAn = new System.Windows.Forms.Button();
            this.btnLamMoiDuAn = new System.Windows.Forms.Button();
            this.tabCongViec = new System.Windows.Forms.TabPage();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.colMaTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDuAnCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCVInput = new System.Windows.Forms.Panel();
            this.lblCVTen = new System.Windows.Forms.Label();
            this.txtCVTen = new System.Windows.Forms.TextBox();
            this.lblCVDuAn = new System.Windows.Forms.Label();
            this.cboCVDuAn = new System.Windows.Forms.ComboBox();
            this.lblCVMoTa = new System.Windows.Forms.Label();
            this.txtCVMoTa = new System.Windows.Forms.TextBox();
            this.lblCVHanNop = new System.Windows.Forms.Label();
            this.dtpCVHanNop = new System.Windows.Forms.DateTimePicker();
            this.lblCVUuTien = new System.Windows.Forms.Label();
            this.cboCVUuTien = new System.Windows.Forms.ComboBox();
            this.lblCVTrangThai = new System.Windows.Forms.Label();
            this.cboCVTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThemCV = new System.Windows.Forms.Button();
            this.btnSuaCV = new System.Windows.Forms.Button();
            this.btnXoaCV = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.lblCVHDSD = new System.Windows.Forms.Label();
            this.panelLoc = new System.Windows.Forms.Panel();
            this.lblLocDuAn = new System.Windows.Forms.Label();
            this.cboLocDuAn = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.tabKanban = new System.Windows.Forms.TabPage();
            this.tableKanban = new System.Windows.Forms.TableLayoutPanel();
            this.grpToDo = new System.Windows.Forms.GroupBox();
            this.flowToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.grpInProgress = new System.Windows.Forms.GroupBox();
            this.flowInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.grpReview = new System.Windows.Forms.GroupBox();
            this.flowReview = new System.Windows.Forms.FlowLayoutPanel();
            this.grpDone = new System.Windows.Forms.GroupBox();
            this.flowDone = new System.Windows.Forms.FlowLayoutPanel();
            this.panelKanbanTop = new System.Windows.Forms.Panel();
            this.lblKanbanDuAn = new System.Windows.Forms.Label();
            this.cboKanbanDuAn = new System.Windows.Forms.ComboBox();
            this.btnKanbanRefresh = new System.Windows.Forms.Button();
            this.lblKanbanGhiChu = new System.Windows.Forms.Label();
            this.tabThanhVien = new System.Windows.Forms.TabPage();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.colMaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThanhVien = new System.Windows.Forms.GroupBox();
            this.lblTVMa = new System.Windows.Forms.Label();
            this.lblTVHoTen = new System.Windows.Forms.Label();
            this.txtTVHoTen = new System.Windows.Forms.TextBox();
            this.lblTVEmail = new System.Windows.Forms.Label();
            this.txtTVEmail = new System.Windows.Forms.TextBox();
            this.lblTVChuyenMon = new System.Windows.Forms.Label();
            this.txtTVChuyenMon = new System.Windows.Forms.TextBox();
            this.btnThemTV = new System.Windows.Forms.Button();
            this.btnSuaTV = new System.Windows.Forms.Button();
            this.btnXoaTV = new System.Windows.Forms.Button();
            this.btnLamMoiTV = new System.Windows.Forms.Button();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.splitBaoCao = new System.Windows.Forms.SplitContainer();
            this.grpTreHan = new System.Windows.Forms.GroupBox();
            this.dgvTreHan = new System.Windows.Forms.DataGridView();
            this.colTreMaTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreTenTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreHanNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreSoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.colTKTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTKTyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBaoCaoTop = new System.Windows.Forms.Panel();
            this.btnTreHan = new System.Windows.Forms.Button();
            this.lblBCDuAn = new System.Windows.Forms.Label();
            this.cboBCDuAn = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTyLeTong = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabDuAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.grpDuAn.SuspendLayout();
            this.tabCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.panelCVInput.SuspendLayout();
            this.panelLoc.SuspendLayout();
            this.tabKanban.SuspendLayout();
            this.tableKanban.SuspendLayout();
            this.grpToDo.SuspendLayout();
            this.grpInProgress.SuspendLayout();
            this.grpReview.SuspendLayout();
            this.grpDone.SuspendLayout();
            this.panelKanbanTop.SuspendLayout();
            this.tabThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.grpThanhVien.SuspendLayout();
            this.tabBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBaoCao)).BeginInit();
            this.splitBaoCao.Panel1.SuspendLayout();
            this.splitBaoCao.Panel2.SuspendLayout();
            this.splitBaoCao.SuspendLayout();
            this.grpTreHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreHan)).BeginInit();
            this.grpThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.panelBaoCaoTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDuAn);
            this.tabMain.Controls.Add(this.tabCongViec);
            this.tabMain.Controls.Add(this.tabKanban);
            this.tabMain.Controls.Add(this.tabThanhVien);
            this.tabMain.Controls.Add(this.tabBaoCao);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1160, 700);
            this.tabMain.TabIndex = 0;
            // 
            // tabDuAn
            // 
            this.tabDuAn.Controls.Add(this.dgvDuAn);
            this.tabDuAn.Controls.Add(this.grpDuAn);
            this.tabDuAn.Location = new System.Drawing.Point(4, 27);
            this.tabDuAn.Name = "tabDuAn";
            this.tabDuAn.Padding = new System.Windows.Forms.Padding(3);
            this.tabDuAn.Size = new System.Drawing.Size(1152, 669);
            this.tabDuAn.TabIndex = 0;
            this.tabDuAn.Text = "Dự án";
            this.tabDuAn.UseVisualStyleBackColor = true;
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.AllowUserToAddRows = false;
            this.dgvDuAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDuAn,
            this.colTenDuAn,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTrangThaiDA});
            this.dgvDuAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuAn.Location = new System.Drawing.Point(3, 153);
            this.dgvDuAn.MultiSelect = false;
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.ReadOnly = true;
            this.dgvDuAn.RowHeadersVisible = false;
            this.dgvDuAn.RowTemplate.Height = 25;
            this.dgvDuAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuAn.Size = new System.Drawing.Size(1146, 513);
            this.dgvDuAn.TabIndex = 1;
            this.dgvDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellClick);
            // 
            // colMaDuAn
            // 
            this.colMaDuAn.DataPropertyName = "MaDuAn";
            this.colMaDuAn.FillWeight = 12F;
            this.colMaDuAn.HeaderText = "Mã dự án";
            this.colMaDuAn.Name = "colMaDuAn";
            // 
            // colTenDuAn
            // 
            this.colTenDuAn.DataPropertyName = "TenDuAn";
            this.colTenDuAn.FillWeight = 45F;
            this.colTenDuAn.HeaderText = "Tên dự án";
            this.colTenDuAn.Name = "colTenDuAn";
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.DataPropertyName = "NgayBatDau";
            this.colNgayBatDau.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colNgayBatDau.FillWeight = 15F;
            this.colNgayBatDau.HeaderText = "Ngày bắt đầu";
            this.colNgayBatDau.Name = "colNgayBatDau";
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.colNgayKetThuc.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colNgayKetThuc.FillWeight = 15F;
            this.colNgayKetThuc.HeaderText = "Ngày kết thúc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            // 
            // colTrangThaiDA
            // 
            this.colTrangThaiDA.DataPropertyName = "TrangThai";
            this.colTrangThaiDA.FillWeight = 15F;
            this.colTrangThaiDA.HeaderText = "Trạng thái";
            this.colTrangThaiDA.Name = "colTrangThaiDA";
            // 
            // grpDuAn
            // 
            this.grpDuAn.Controls.Add(this.lblMaDuAn);
            this.grpDuAn.Controls.Add(this.txtMaDuAn);
            this.grpDuAn.Controls.Add(this.lblTenDuAn);
            this.grpDuAn.Controls.Add(this.txtTenDuAn);
            this.grpDuAn.Controls.Add(this.lblNgayBatDau);
            this.grpDuAn.Controls.Add(this.dtpNgayBatDau);
            this.grpDuAn.Controls.Add(this.lblNgayKetThuc);
            this.grpDuAn.Controls.Add(this.dtpNgayKetThuc);
            this.grpDuAn.Controls.Add(this.lblTrangThaiDuAn);
            this.grpDuAn.Controls.Add(this.cboTrangThaiDuAn);
            this.grpDuAn.Controls.Add(this.btnThemDuAn);
            this.grpDuAn.Controls.Add(this.btnSuaDuAn);
            this.grpDuAn.Controls.Add(this.btnXoaDuAn);
            this.grpDuAn.Controls.Add(this.btnLamMoiDuAn);
            this.grpDuAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDuAn.Location = new System.Drawing.Point(3, 3);
            this.grpDuAn.Name = "grpDuAn";
            this.grpDuAn.Size = new System.Drawing.Size(1146, 150);
            this.grpDuAn.TabIndex = 0;
            this.grpDuAn.TabStop = false;
            this.grpDuAn.Text = "Thông tin dự án";
            // 
            // lblMaDuAn
            // 
            this.lblMaDuAn.AutoSize = true;
            this.lblMaDuAn.Location = new System.Drawing.Point(18, 32);
            this.lblMaDuAn.Name = "lblMaDuAn";
            this.lblMaDuAn.Size = new System.Drawing.Size(58, 19);
            this.lblMaDuAn.TabIndex = 0;
            this.lblMaDuAn.Text = "Mã dự án";
            // 
            // txtMaDuAn
            // 
            this.txtMaDuAn.Location = new System.Drawing.Point(110, 29);
            this.txtMaDuAn.Name = "txtMaDuAn";
            this.txtMaDuAn.ReadOnly = true;
            this.txtMaDuAn.Size = new System.Drawing.Size(70, 25);
            this.txtMaDuAn.TabIndex = 1;
            // 
            // lblTenDuAn
            // 
            this.lblTenDuAn.AutoSize = true;
            this.lblTenDuAn.Location = new System.Drawing.Point(200, 32);
            this.lblTenDuAn.Name = "lblTenDuAn";
            this.lblTenDuAn.Size = new System.Drawing.Size(64, 19);
            this.lblTenDuAn.TabIndex = 2;
            this.lblTenDuAn.Text = "Tên dự án";
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Location = new System.Drawing.Point(285, 29);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(330, 25);
            this.txtTenDuAn.TabIndex = 3;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(18, 72);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(84, 19);
            this.lblNgayBatDau.TabIndex = 4;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(110, 68);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(160, 25);
            this.dtpNgayBatDau.TabIndex = 5;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(295, 72);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(90, 19);
            this.lblNgayKetThuc.TabIndex = 6;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(395, 68);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(160, 25);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // lblTrangThaiDuAn
            // 
            this.lblTrangThaiDuAn.AutoSize = true;
            this.lblTrangThaiDuAn.Location = new System.Drawing.Point(580, 72);
            this.lblTrangThaiDuAn.Name = "lblTrangThaiDuAn";
            this.lblTrangThaiDuAn.Size = new System.Drawing.Size(66, 19);
            this.lblTrangThaiDuAn.TabIndex = 8;
            this.lblTrangThaiDuAn.Text = "Trạng thái";
            // 
            // cboTrangThaiDuAn
            // 
            this.cboTrangThaiDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiDuAn.FormattingEnabled = true;
            this.cboTrangThaiDuAn.Location = new System.Drawing.Point(660, 68);
            this.cboTrangThaiDuAn.Name = "cboTrangThaiDuAn";
            this.cboTrangThaiDuAn.Size = new System.Drawing.Size(180, 25);
            this.cboTrangThaiDuAn.TabIndex = 9;
            // 
            // btnThemDuAn
            // 
            this.btnThemDuAn.Location = new System.Drawing.Point(110, 108);
            this.btnThemDuAn.Name = "btnThemDuAn";
            this.btnThemDuAn.Size = new System.Drawing.Size(100, 32);
            this.btnThemDuAn.TabIndex = 10;
            this.btnThemDuAn.Text = "Thêm";
            this.btnThemDuAn.UseVisualStyleBackColor = true;
            this.btnThemDuAn.Click += new System.EventHandler(this.btnThemDuAn_Click);
            // 
            // btnSuaDuAn
            // 
            this.btnSuaDuAn.Location = new System.Drawing.Point(220, 108);
            this.btnSuaDuAn.Name = "btnSuaDuAn";
            this.btnSuaDuAn.Size = new System.Drawing.Size(100, 32);
            this.btnSuaDuAn.TabIndex = 11;
            this.btnSuaDuAn.Text = "Sửa";
            this.btnSuaDuAn.UseVisualStyleBackColor = true;
            this.btnSuaDuAn.Click += new System.EventHandler(this.btnSuaDuAn_Click);
            // 
            // btnXoaDuAn
            // 
            this.btnXoaDuAn.Location = new System.Drawing.Point(330, 108);
            this.btnXoaDuAn.Name = "btnXoaDuAn";
            this.btnXoaDuAn.Size = new System.Drawing.Size(100, 32);
            this.btnXoaDuAn.TabIndex = 12;
            this.btnXoaDuAn.Text = "Xóa";
            this.btnXoaDuAn.UseVisualStyleBackColor = true;
            this.btnXoaDuAn.Click += new System.EventHandler(this.btnXoaDuAn_Click);
            // 
            // btnLamMoiDuAn
            // 
            this.btnLamMoiDuAn.Location = new System.Drawing.Point(440, 108);
            this.btnLamMoiDuAn.Name = "btnLamMoiDuAn";
            this.btnLamMoiDuAn.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoiDuAn.TabIndex = 13;
            this.btnLamMoiDuAn.Text = "Làm mới";
            this.btnLamMoiDuAn.UseVisualStyleBackColor = true;
            this.btnLamMoiDuAn.Click += new System.EventHandler(this.btnLamMoiDuAn_Click);
            // 
            // tabCongViec
            // 
            this.tabCongViec.Controls.Add(this.dgvCongViec);
            this.tabCongViec.Controls.Add(this.panelCVInput);
            this.tabCongViec.Controls.Add(this.panelLoc);
            this.tabCongViec.Location = new System.Drawing.Point(4, 27);
            this.tabCongViec.Name = "tabCongViec";
            this.tabCongViec.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongViec.Size = new System.Drawing.Size(1152, 669);
            this.tabCongViec.TabIndex = 1;
            this.tabCongViec.Text = "Công việc";
            this.tabCongViec.UseVisualStyleBackColor = true;
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.AllowUserToAddRows = false;
            this.dgvCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongViec.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTask,
            this.colTenTask,
            this.colTenDuAnCV,
            this.colHanNop,
            this.colUuTien,
            this.colTrangThaiCV,
            this.colThanhVien});
            this.dgvCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongViec.Location = new System.Drawing.Point(3, 58);
            this.dgvCongViec.MultiSelect = false;
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.ReadOnly = true;
            this.dgvCongViec.RowHeadersVisible = false;
            this.dgvCongViec.RowTemplate.Height = 25;
            this.dgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongViec.Size = new System.Drawing.Size(818, 608);
            this.dgvCongViec.TabIndex = 0;
            this.dgvCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongViec_CellClick);
            // 
            // colMaTask
            // 
            this.colMaTask.DataPropertyName = "MaTask";
            this.colMaTask.FillWeight = 9F;
            this.colMaTask.HeaderText = "Mã";
            this.colMaTask.Name = "colMaTask";
            // 
            // colTenTask
            // 
            this.colTenTask.DataPropertyName = "TenTask";
            this.colTenTask.FillWeight = 35F;
            this.colTenTask.HeaderText = "Tên công việc";
            this.colTenTask.Name = "colTenTask";
            // 
            // colTenDuAnCV
            // 
            this.colTenDuAnCV.DataPropertyName = "TenDuAn";
            this.colTenDuAnCV.FillWeight = 20F;
            this.colTenDuAnCV.HeaderText = "Dự án";
            this.colTenDuAnCV.Name = "colTenDuAnCV";
            // 
            // colHanNop
            // 
            this.colHanNop.DataPropertyName = "HanNop";
            this.colHanNop.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colHanNop.FillWeight = 12F;
            this.colHanNop.HeaderText = "Hạn nộp";
            this.colHanNop.Name = "colHanNop";
            // 
            // colUuTien
            // 
            this.colUuTien.DataPropertyName = "DoUuTien";
            this.colUuTien.FillWeight = 10F;
            this.colUuTien.HeaderText = "Ưu tiên";
            this.colUuTien.Name = "colUuTien";
            // 
            // colTrangThaiCV
            // 
            this.colTrangThaiCV.DataPropertyName = "TrangThai";
            this.colTrangThaiCV.FillWeight = 12F;
            this.colTrangThaiCV.HeaderText = "Trạng thái";
            this.colTrangThaiCV.Name = "colTrangThaiCV";
            // 
            // colThanhVien
            // 
            this.colThanhVien.DataPropertyName = "DanhSachThanhVien";
            this.colThanhVien.FillWeight = 25F;
            this.colThanhVien.HeaderText = "Thành viên";
            this.colThanhVien.Name = "colThanhVien";
            // 
            // panelCVInput
            // 
            this.panelCVInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCVInput.Controls.Add(this.lblCVTen);
            this.panelCVInput.Controls.Add(this.txtCVTen);
            this.panelCVInput.Controls.Add(this.lblCVDuAn);
            this.panelCVInput.Controls.Add(this.cboCVDuAn);
            this.panelCVInput.Controls.Add(this.lblCVMoTa);
            this.panelCVInput.Controls.Add(this.txtCVMoTa);
            this.panelCVInput.Controls.Add(this.lblCVHanNop);
            this.panelCVInput.Controls.Add(this.dtpCVHanNop);
            this.panelCVInput.Controls.Add(this.lblCVUuTien);
            this.panelCVInput.Controls.Add(this.cboCVUuTien);
            this.panelCVInput.Controls.Add(this.lblCVTrangThai);
            this.panelCVInput.Controls.Add(this.cboCVTrangThai);
            this.panelCVInput.Controls.Add(this.btnThemCV);
            this.panelCVInput.Controls.Add(this.btnSuaCV);
            this.panelCVInput.Controls.Add(this.btnXoaCV);
            this.panelCVInput.Controls.Add(this.btnPhanCong);
            this.panelCVInput.Controls.Add(this.btnCapNhatTrangThai);
            this.panelCVInput.Controls.Add(this.lblCVHDSD);
            this.panelCVInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCVInput.Location = new System.Drawing.Point(821, 58);
            this.panelCVInput.Name = "panelCVInput";
            this.panelCVInput.Size = new System.Drawing.Size(328, 608);
            this.panelCVInput.TabIndex = 1;
            // 
            // lblCVTen
            // 
            this.lblCVTen.AutoSize = true;
            this.lblCVTen.Location = new System.Drawing.Point(10, 14);
            this.lblCVTen.Name = "lblCVTen";
            this.lblCVTen.Size = new System.Drawing.Size(97, 19);
            this.lblCVTen.TabIndex = 0;
            this.lblCVTen.Text = "Tên công việc";
            // 
            // txtCVTen
            // 
            this.txtCVTen.Location = new System.Drawing.Point(10, 36);
            this.txtCVTen.Name = "txtCVTen";
            this.txtCVTen.Size = new System.Drawing.Size(300, 25);
            this.txtCVTen.TabIndex = 1;
            // 
            // lblCVDuAn
            // 
            this.lblCVDuAn.AutoSize = true;
            this.lblCVDuAn.Location = new System.Drawing.Point(10, 74);
            this.lblCVDuAn.Name = "lblCVDuAn";
            this.lblCVDuAn.Size = new System.Drawing.Size(50, 19);
            this.lblCVDuAn.TabIndex = 2;
            this.lblCVDuAn.Text = "Dự án";
            // 
            // cboCVDuAn
            // 
            this.cboCVDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVDuAn.FormattingEnabled = true;
            this.cboCVDuAn.Location = new System.Drawing.Point(10, 96);
            this.cboCVDuAn.Name = "cboCVDuAn";
            this.cboCVDuAn.Size = new System.Drawing.Size(300, 25);
            this.cboCVDuAn.TabIndex = 3;
            // 
            // lblCVMoTa
            // 
            this.lblCVMoTa.AutoSize = true;
            this.lblCVMoTa.Location = new System.Drawing.Point(10, 134);
            this.lblCVMoTa.Name = "lblCVMoTa";
            this.lblCVMoTa.Size = new System.Drawing.Size(48, 19);
            this.lblCVMoTa.TabIndex = 4;
            this.lblCVMoTa.Text = "Mô tả";
            // 
            // txtCVMoTa
            // 
            this.txtCVMoTa.Location = new System.Drawing.Point(10, 156);
            this.txtCVMoTa.Multiline = true;
            this.txtCVMoTa.Name = "txtCVMoTa";
            this.txtCVMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCVMoTa.Size = new System.Drawing.Size(300, 80);
            this.txtCVMoTa.TabIndex = 5;
            // 
            // lblCVHanNop
            // 
            this.lblCVHanNop.AutoSize = true;
            this.lblCVHanNop.Location = new System.Drawing.Point(10, 250);
            this.lblCVHanNop.Name = "lblCVHanNop";
            this.lblCVHanNop.Size = new System.Drawing.Size(61, 19);
            this.lblCVHanNop.TabIndex = 6;
            this.lblCVHanNop.Text = "Hạn nộp";
            // 
            // dtpCVHanNop
            // 
            this.dtpCVHanNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCVHanNop.Location = new System.Drawing.Point(10, 272);
            this.dtpCVHanNop.Name = "dtpCVHanNop";
            this.dtpCVHanNop.ShowCheckBox = true;
            this.dtpCVHanNop.Size = new System.Drawing.Size(300, 25);
            this.dtpCVHanNop.TabIndex = 7;
            // 
            // lblCVUuTien
            // 
            this.lblCVUuTien.AutoSize = true;
            this.lblCVUuTien.Location = new System.Drawing.Point(10, 310);
            this.lblCVUuTien.Name = "lblCVUuTien";
            this.lblCVUuTien.Size = new System.Drawing.Size(56, 19);
            this.lblCVUuTien.TabIndex = 8;
            this.lblCVUuTien.Text = "Ưu tiên";
            // 
            // cboCVUuTien
            // 
            this.cboCVUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVUuTien.FormattingEnabled = true;
            this.cboCVUuTien.Location = new System.Drawing.Point(10, 332);
            this.cboCVUuTien.Name = "cboCVUuTien";
            this.cboCVUuTien.Size = new System.Drawing.Size(140, 25);
            this.cboCVUuTien.TabIndex = 9;
            // 
            // lblCVTrangThai
            // 
            this.lblCVTrangThai.AutoSize = true;
            this.lblCVTrangThai.Location = new System.Drawing.Point(165, 310);
            this.lblCVTrangThai.Name = "lblCVTrangThai";
            this.lblCVTrangThai.Size = new System.Drawing.Size(66, 19);
            this.lblCVTrangThai.TabIndex = 10;
            this.lblCVTrangThai.Text = "Trạng thái";
            // 
            // cboCVTrangThai
            // 
            this.cboCVTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVTrangThai.FormattingEnabled = true;
            this.cboCVTrangThai.Location = new System.Drawing.Point(165, 332);
            this.cboCVTrangThai.Name = "cboCVTrangThai";
            this.cboCVTrangThai.Size = new System.Drawing.Size(145, 25);
            this.cboCVTrangThai.TabIndex = 11;
            // 
            // btnThemCV
            // 
            this.btnThemCV.Location = new System.Drawing.Point(10, 380);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(140, 32);
            this.btnThemCV.TabIndex = 12;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.UseVisualStyleBackColor = true;
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Location = new System.Drawing.Point(165, 380);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(145, 32);
            this.btnSuaCV.TabIndex = 13;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.UseVisualStyleBackColor = true;
            this.btnSuaCV.Click += new System.EventHandler(this.btnSuaCV_Click);
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Location = new System.Drawing.Point(10, 422);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(140, 32);
            this.btnXoaCV.TabIndex = 14;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.UseVisualStyleBackColor = true;
            this.btnXoaCV.Click += new System.EventHandler(this.btnXoaCV_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(165, 422);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(145, 32);
            this.btnPhanCong.TabIndex = 15;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(10, 464);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(300, 32);
            this.btnCapNhatTrangThai.TabIndex = 16;
            this.btnCapNhatTrangThai.Text = "Cập nhật trạng thái";
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = true;
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            // 
            // lblCVHDSD
            // 
            this.lblCVHDSD.ForeColor = System.Drawing.Color.Gray;
            this.lblCVHDSD.Location = new System.Drawing.Point(10, 510);
            this.lblCVHDSD.Name = "lblCVHDSD";
            this.lblCVHDSD.Size = new System.Drawing.Size(300, 50);
            this.lblCVHDSD.TabIndex = 17;
            this.lblCVHDSD.Text = "Chọn một dòng trong danh sách để sửa, phân công hoặc đổi trạng thái.";
            // 
            // panelLoc
            // 
            this.panelLoc.Controls.Add(this.lblLocDuAn);
            this.panelLoc.Controls.Add(this.cboLocDuAn);
            this.panelLoc.Controls.Add(this.lblLocTrangThai);
            this.panelLoc.Controls.Add(this.cboLocTrangThai);
            this.panelLoc.Controls.Add(this.btnLoc);
            this.panelLoc.Controls.Add(this.btnBoLoc);
            this.panelLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoc.Location = new System.Drawing.Point(3, 3);
            this.panelLoc.Name = "panelLoc";
            this.panelLoc.Size = new System.Drawing.Size(1146, 55);
            this.panelLoc.TabIndex = 2;
            // 
            // lblLocDuAn
            // 
            this.lblLocDuAn.AutoSize = true;
            this.lblLocDuAn.Location = new System.Drawing.Point(10, 18);
            this.lblLocDuAn.Name = "lblLocDuAn";
            this.lblLocDuAn.Size = new System.Drawing.Size(50, 19);
            this.lblLocDuAn.TabIndex = 0;
            this.lblLocDuAn.Text = "Dự án";
            // 
            // cboLocDuAn
            // 
            this.cboLocDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocDuAn.FormattingEnabled = true;
            this.cboLocDuAn.Location = new System.Drawing.Point(68, 15);
            this.cboLocDuAn.Name = "cboLocDuAn";
            this.cboLocDuAn.Size = new System.Drawing.Size(240, 25);
            this.cboLocDuAn.TabIndex = 1;
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Location = new System.Drawing.Point(330, 18);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(66, 19);
            this.lblLocTrangThai.TabIndex = 2;
            this.lblLocTrangThai.Text = "Trạng thái";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(404, 15);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(160, 25);
            this.cboLocTrangThai.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(585, 12);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 32);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(685, 12);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(90, 32);
            this.btnBoLoc.TabIndex = 5;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // tabKanban
            // 
            this.tabKanban.Controls.Add(this.tableKanban);
            this.tabKanban.Controls.Add(this.panelKanbanTop);
            this.tabKanban.Location = new System.Drawing.Point(4, 27);
            this.tabKanban.Name = "tabKanban";
            this.tabKanban.Padding = new System.Windows.Forms.Padding(3);
            this.tabKanban.Size = new System.Drawing.Size(1152, 669);
            this.tabKanban.TabIndex = 2;
            this.tabKanban.Text = "Kanban";
            this.tabKanban.UseVisualStyleBackColor = true;
            // 
            // tableKanban
            // 
            this.tableKanban.ColumnCount = 4;
            this.tableKanban.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableKanban.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableKanban.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableKanban.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableKanban.Controls.Add(this.grpToDo, 0, 0);
            this.tableKanban.Controls.Add(this.grpInProgress, 1, 0);
            this.tableKanban.Controls.Add(this.grpReview, 2, 0);
            this.tableKanban.Controls.Add(this.grpDone, 3, 0);
            this.tableKanban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableKanban.Location = new System.Drawing.Point(3, 53);
            this.tableKanban.Name = "tableKanban";
            this.tableKanban.RowCount = 1;
            this.tableKanban.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableKanban.Size = new System.Drawing.Size(1146, 613);
            this.tableKanban.TabIndex = 0;
            // 
            // grpToDo
            // 
            this.grpToDo.Controls.Add(this.flowToDo);
            this.grpToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpToDo.Location = new System.Drawing.Point(3, 3);
            this.grpToDo.Name = "grpToDo";
            this.grpToDo.Padding = new System.Windows.Forms.Padding(5);
            this.grpToDo.Size = new System.Drawing.Size(280, 607);
            this.grpToDo.TabIndex = 0;
            this.grpToDo.TabStop = false;
            this.grpToDo.Text = "To Do";
            // 
            // flowToDo
            // 
            this.flowToDo.AutoScroll = true;
            this.flowToDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.flowToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowToDo.Location = new System.Drawing.Point(5, 23);
            this.flowToDo.Name = "flowToDo";
            this.flowToDo.Padding = new System.Windows.Forms.Padding(3);
            this.flowToDo.Size = new System.Drawing.Size(270, 579);
            this.flowToDo.TabIndex = 0;
            this.flowToDo.WrapContents = false;
            // 
            // grpInProgress
            // 
            this.grpInProgress.Controls.Add(this.flowInProgress);
            this.grpInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInProgress.Location = new System.Drawing.Point(289, 3);
            this.grpInProgress.Name = "grpInProgress";
            this.grpInProgress.Padding = new System.Windows.Forms.Padding(5);
            this.grpInProgress.Size = new System.Drawing.Size(280, 607);
            this.grpInProgress.TabIndex = 1;
            this.grpInProgress.TabStop = false;
            this.grpInProgress.Text = "In Progress";
            // 
            // flowInProgress
            // 
            this.flowInProgress.AutoScroll = true;
            this.flowInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.flowInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInProgress.Location = new System.Drawing.Point(5, 23);
            this.flowInProgress.Name = "flowInProgress";
            this.flowInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.flowInProgress.Size = new System.Drawing.Size(270, 579);
            this.flowInProgress.TabIndex = 0;
            this.flowInProgress.WrapContents = false;
            // 
            // grpReview
            // 
            this.grpReview.Controls.Add(this.flowReview);
            this.grpReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReview.Location = new System.Drawing.Point(575, 3);
            this.grpReview.Name = "grpReview";
            this.grpReview.Padding = new System.Windows.Forms.Padding(5);
            this.grpReview.Size = new System.Drawing.Size(280, 607);
            this.grpReview.TabIndex = 2;
            this.grpReview.TabStop = false;
            this.grpReview.Text = "Review";
            // 
            // flowReview
            // 
            this.flowReview.AutoScroll = true;
            this.flowReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.flowReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowReview.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowReview.Location = new System.Drawing.Point(5, 23);
            this.flowReview.Name = "flowReview";
            this.flowReview.Padding = new System.Windows.Forms.Padding(3);
            this.flowReview.Size = new System.Drawing.Size(270, 579);
            this.flowReview.TabIndex = 0;
            this.flowReview.WrapContents = false;
            // 
            // grpDone
            // 
            this.grpDone.Controls.Add(this.flowDone);
            this.grpDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDone.Location = new System.Drawing.Point(861, 3);
            this.grpDone.Name = "grpDone";
            this.grpDone.Padding = new System.Windows.Forms.Padding(5);
            this.grpDone.Size = new System.Drawing.Size(282, 607);
            this.grpDone.TabIndex = 3;
            this.grpDone.TabStop = false;
            this.grpDone.Text = "Done";
            // 
            // flowDone
            // 
            this.flowDone.AutoScroll = true;
            this.flowDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.flowDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDone.Location = new System.Drawing.Point(5, 23);
            this.flowDone.Name = "flowDone";
            this.flowDone.Padding = new System.Windows.Forms.Padding(3);
            this.flowDone.Size = new System.Drawing.Size(272, 579);
            this.flowDone.TabIndex = 0;
            this.flowDone.WrapContents = false;
            // 
            // panelKanbanTop
            // 
            this.panelKanbanTop.Controls.Add(this.lblKanbanDuAn);
            this.panelKanbanTop.Controls.Add(this.cboKanbanDuAn);
            this.panelKanbanTop.Controls.Add(this.btnKanbanRefresh);
            this.panelKanbanTop.Controls.Add(this.lblKanbanGhiChu);
            this.panelKanbanTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKanbanTop.Location = new System.Drawing.Point(3, 3);
            this.panelKanbanTop.Name = "panelKanbanTop";
            this.panelKanbanTop.Size = new System.Drawing.Size(1146, 50);
            this.panelKanbanTop.TabIndex = 1;
            // 
            // lblKanbanDuAn
            // 
            this.lblKanbanDuAn.AutoSize = true;
            this.lblKanbanDuAn.Location = new System.Drawing.Point(10, 15);
            this.lblKanbanDuAn.Name = "lblKanbanDuAn";
            this.lblKanbanDuAn.Size = new System.Drawing.Size(50, 19);
            this.lblKanbanDuAn.TabIndex = 0;
            this.lblKanbanDuAn.Text = "Dự án";
            // 
            // cboKanbanDuAn
            // 
            this.cboKanbanDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKanbanDuAn.FormattingEnabled = true;
            this.cboKanbanDuAn.Location = new System.Drawing.Point(68, 12);
            this.cboKanbanDuAn.Name = "cboKanbanDuAn";
            this.cboKanbanDuAn.Size = new System.Drawing.Size(280, 25);
            this.cboKanbanDuAn.TabIndex = 1;
            this.cboKanbanDuAn.SelectedIndexChanged += new System.EventHandler(this.cboKanbanDuAn_SelectedIndexChanged);
            // 
            // btnKanbanRefresh
            // 
            this.btnKanbanRefresh.Location = new System.Drawing.Point(365, 9);
            this.btnKanbanRefresh.Name = "btnKanbanRefresh";
            this.btnKanbanRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnKanbanRefresh.TabIndex = 2;
            this.btnKanbanRefresh.Text = "Làm mới";
            this.btnKanbanRefresh.UseVisualStyleBackColor = true;
            this.btnKanbanRefresh.Click += new System.EventHandler(this.btnKanbanRefresh_Click);
            // 
            // lblKanbanGhiChu
            // 
            this.lblKanbanGhiChu.AutoSize = true;
            this.lblKanbanGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblKanbanGhiChu.Location = new System.Drawing.Point(495, 15);
            this.lblKanbanGhiChu.Name = "lblKanbanGhiChu";
            this.lblKanbanGhiChu.Size = new System.Drawing.Size(290, 19);
            this.lblKanbanGhiChu.TabIndex = 3;
            this.lblKanbanGhiChu.Text = "Mỗi cột tương ứng với một trạng thái công việc.";
            // 
            // tabThanhVien
            // 
            this.tabThanhVien.Controls.Add(this.dgvThanhVien);
            this.tabThanhVien.Controls.Add(this.grpThanhVien);
            this.tabThanhVien.Location = new System.Drawing.Point(4, 27);
            this.tabThanhVien.Name = "tabThanhVien";
            this.tabThanhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanhVien.Size = new System.Drawing.Size(1152, 669);
            this.tabThanhVien.TabIndex = 3;
            this.tabThanhVien.Text = "Thành viên";
            this.tabThanhVien.UseVisualStyleBackColor = true;
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTV,
            this.colHoTen,
            this.colEmail,
            this.colChuyenMon});
            this.dgvThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanhVien.Location = new System.Drawing.Point(3, 143);
            this.dgvThanhVien.MultiSelect = false;
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.RowHeadersVisible = false;
            this.dgvThanhVien.RowTemplate.Height = 25;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(1146, 523);
            this.dgvThanhVien.TabIndex = 1;
            this.dgvThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhVien_CellClick);
            // 
            // colMaTV
            // 
            this.colMaTV.DataPropertyName = "MaThanhVien";
            this.colMaTV.FillWeight = 15F;
            this.colMaTV.HeaderText = "Mã";
            this.colMaTV.Name = "colMaTV";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 30F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.FillWeight = 35F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colChuyenMon
            // 
            this.colChuyenMon.DataPropertyName = "ChuyenMon";
            this.colChuyenMon.FillWeight = 20F;
            this.colChuyenMon.HeaderText = "Chuyên môn";
            this.colChuyenMon.Name = "colChuyenMon";
            // 
            // grpThanhVien
            // 
            this.grpThanhVien.Controls.Add(this.lblTVMa);
            this.grpThanhVien.Controls.Add(this.lblTVHoTen);
            this.grpThanhVien.Controls.Add(this.txtTVHoTen);
            this.grpThanhVien.Controls.Add(this.lblTVEmail);
            this.grpThanhVien.Controls.Add(this.txtTVEmail);
            this.grpThanhVien.Controls.Add(this.lblTVChuyenMon);
            this.grpThanhVien.Controls.Add(this.txtTVChuyenMon);
            this.grpThanhVien.Controls.Add(this.btnThemTV);
            this.grpThanhVien.Controls.Add(this.btnSuaTV);
            this.grpThanhVien.Controls.Add(this.btnXoaTV);
            this.grpThanhVien.Controls.Add(this.btnLamMoiTV);
            this.grpThanhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThanhVien.Location = new System.Drawing.Point(3, 3);
            this.grpThanhVien.Name = "grpThanhVien";
            this.grpThanhVien.Size = new System.Drawing.Size(1146, 140);
            this.grpThanhVien.TabIndex = 0;
            this.grpThanhVien.TabStop = false;
            this.grpThanhVien.Text = "Thông tin thành viên";
            // 
            // lblTVMa
            // 
            this.lblTVMa.AutoSize = true;
            this.lblTVMa.ForeColor = System.Drawing.Color.Gray;
            this.lblTVMa.Location = new System.Drawing.Point(18, 95);
            this.lblTVMa.Name = "lblTVMa";
            this.lblTVMa.Size = new System.Drawing.Size(112, 19);
            this.lblTVMa.TabIndex = 6;
            this.lblTVMa.Text = "Mã thành viên: --";
            // 
            // lblTVHoTen
            // 
            this.lblTVHoTen.AutoSize = true;
            this.lblTVHoTen.Location = new System.Drawing.Point(18, 32);
            this.lblTVHoTen.Name = "lblTVHoTen";
            this.lblTVHoTen.Size = new System.Drawing.Size(48, 19);
            this.lblTVHoTen.TabIndex = 0;
            this.lblTVHoTen.Text = "Họ tên";
            // 
            // txtTVHoTen
            // 
            this.txtTVHoTen.Location = new System.Drawing.Point(90, 29);
            this.txtTVHoTen.Name = "txtTVHoTen";
            this.txtTVHoTen.Size = new System.Drawing.Size(220, 25);
            this.txtTVHoTen.TabIndex = 1;
            // 
            // lblTVEmail
            // 
            this.lblTVEmail.AutoSize = true;
            this.lblTVEmail.Location = new System.Drawing.Point(335, 32);
            this.lblTVEmail.Name = "lblTVEmail";
            this.lblTVEmail.Size = new System.Drawing.Size(39, 19);
            this.lblTVEmail.TabIndex = 2;
            this.lblTVEmail.Text = "Email";
            // 
            // txtTVEmail
            // 
            this.txtTVEmail.Location = new System.Drawing.Point(395, 29);
            this.txtTVEmail.Name = "txtTVEmail";
            this.txtTVEmail.Size = new System.Drawing.Size(250, 25);
            this.txtTVEmail.TabIndex = 3;
            // 
            // lblTVChuyenMon
            // 
            this.lblTVChuyenMon.AutoSize = true;
            this.lblTVChuyenMon.Location = new System.Drawing.Point(670, 32);
            this.lblTVChuyenMon.Name = "lblTVChuyenMon";
            this.lblTVChuyenMon.Size = new System.Drawing.Size(78, 19);
            this.lblTVChuyenMon.TabIndex = 4;
            this.lblTVChuyenMon.Text = "Chuyên môn";
            // 
            // txtTVChuyenMon
            // 
            this.txtTVChuyenMon.Location = new System.Drawing.Point(760, 29);
            this.txtTVChuyenMon.Name = "txtTVChuyenMon";
            this.txtTVChuyenMon.Size = new System.Drawing.Size(230, 25);
            this.txtTVChuyenMon.TabIndex = 5;
            // 
            // btnThemTV
            // 
            this.btnThemTV.Location = new System.Drawing.Point(90, 60);
            this.btnThemTV.Name = "btnThemTV";
            this.btnThemTV.Size = new System.Drawing.Size(100, 32);
            this.btnThemTV.TabIndex = 7;
            this.btnThemTV.Text = "Thêm";
            this.btnThemTV.UseVisualStyleBackColor = true;
            this.btnThemTV.Click += new System.EventHandler(this.btnThemTV_Click);
            // 
            // btnSuaTV
            // 
            this.btnSuaTV.Location = new System.Drawing.Point(200, 60);
            this.btnSuaTV.Name = "btnSuaTV";
            this.btnSuaTV.Size = new System.Drawing.Size(100, 32);
            this.btnSuaTV.TabIndex = 8;
            this.btnSuaTV.Text = "Sửa";
            this.btnSuaTV.UseVisualStyleBackColor = true;
            this.btnSuaTV.Click += new System.EventHandler(this.btnSuaTV_Click);
            // 
            // btnXoaTV
            // 
            this.btnXoaTV.Location = new System.Drawing.Point(310, 60);
            this.btnXoaTV.Name = "btnXoaTV";
            this.btnXoaTV.Size = new System.Drawing.Size(100, 32);
            this.btnXoaTV.TabIndex = 9;
            this.btnXoaTV.Text = "Xóa";
            this.btnXoaTV.UseVisualStyleBackColor = true;
            this.btnXoaTV.Click += new System.EventHandler(this.btnXoaTV_Click);
            // 
            // btnLamMoiTV
            // 
            this.btnLamMoiTV.Location = new System.Drawing.Point(420, 60);
            this.btnLamMoiTV.Name = "btnLamMoiTV";
            this.btnLamMoiTV.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoiTV.TabIndex = 10;
            this.btnLamMoiTV.Text = "Làm mới";
            this.btnLamMoiTV.UseVisualStyleBackColor = true;
            this.btnLamMoiTV.Click += new System.EventHandler(this.btnLamMoiTV_Click);
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.splitBaoCao);
            this.tabBaoCao.Controls.Add(this.panelBaoCaoTop);
            this.tabBaoCao.Location = new System.Drawing.Point(4, 27);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(1152, 669);
            this.tabBaoCao.TabIndex = 4;
            this.tabBaoCao.Text = "Báo cáo";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // splitBaoCao
            // 
            this.splitBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBaoCao.Location = new System.Drawing.Point(3, 53);
            this.splitBaoCao.Name = "splitBaoCao";
            this.splitBaoCao.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBaoCao.Panel1
            // 
            this.splitBaoCao.Panel1.Controls.Add(this.grpTreHan);
            // 
            // splitBaoCao.Panel2
            // 
            this.splitBaoCao.Panel2.Controls.Add(this.grpThongKe);
            this.splitBaoCao.Size = new System.Drawing.Size(1146, 613);
            this.splitBaoCao.SplitterDistance = 300;
            this.splitBaoCao.TabIndex = 0;
            // 
            // grpTreHan
            // 
            this.grpTreHan.Controls.Add(this.dgvTreHan);
            this.grpTreHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTreHan.Location = new System.Drawing.Point(0, 0);
            this.grpTreHan.Name = "grpTreHan";
            this.grpTreHan.Size = new System.Drawing.Size(1146, 300);
            this.grpTreHan.TabIndex = 0;
            this.grpTreHan.TabStop = false;
            this.grpTreHan.Text = "Danh sách công việc trễ hạn (SqlDataReader)";
            // 
            // dgvTreHan
            // 
            this.dgvTreHan.AllowUserToAddRows = false;
            this.dgvTreHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreHan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTreHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreHan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTreMaTask,
            this.colTreTenTask,
            this.colTreDuAn,
            this.colTreHanNop,
            this.colTreUuTien,
            this.colTreTrangThai,
            this.colTreSoNgay});
            this.dgvTreHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreHan.Location = new System.Drawing.Point(3, 21);
            this.dgvTreHan.Name = "dgvTreHan";
            this.dgvTreHan.ReadOnly = true;
            this.dgvTreHan.RowHeadersVisible = false;
            this.dgvTreHan.RowTemplate.Height = 25;
            this.dgvTreHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreHan.Size = new System.Drawing.Size(1140, 276);
            this.dgvTreHan.TabIndex = 0;
            // 
            // colTreMaTask
            // 
            this.colTreMaTask.DataPropertyName = "MaTask";
            this.colTreMaTask.FillWeight = 8F;
            this.colTreMaTask.HeaderText = "Mã";
            this.colTreMaTask.Name = "colTreMaTask";
            // 
            // colTreTenTask
            // 
            this.colTreTenTask.DataPropertyName = "TenTask";
            this.colTreTenTask.FillWeight = 30F;
            this.colTreTenTask.HeaderText = "Tên công việc";
            this.colTreTenTask.Name = "colTreTenTask";
            // 
            // colTreDuAn
            // 
            this.colTreDuAn.DataPropertyName = "TenDuAn";
            this.colTreDuAn.FillWeight = 20F;
            this.colTreDuAn.HeaderText = "Dự án";
            this.colTreDuAn.Name = "colTreDuAn";
            // 
            // colTreHanNop
            // 
            this.colTreHanNop.DataPropertyName = "HanNop";
            this.colTreHanNop.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colTreHanNop.FillWeight = 12F;
            this.colTreHanNop.HeaderText = "Hạn nộp";
            this.colTreHanNop.Name = "colTreHanNop";
            // 
            // colTreUuTien
            // 
            this.colTreUuTien.DataPropertyName = "DoUuTien";
            this.colTreUuTien.FillWeight = 10F;
            this.colTreUuTien.HeaderText = "Ưu tiên";
            this.colTreUuTien.Name = "colTreUuTien";
            // 
            // colTreTrangThai
            // 
            this.colTreTrangThai.DataPropertyName = "TrangThai";
            this.colTreTrangThai.FillWeight = 10F;
            this.colTreTrangThai.HeaderText = "Trạng thái";
            this.colTreTrangThai.Name = "colTreTrangThai";
            // 
            // colTreSoNgay
            // 
            this.colTreSoNgay.DataPropertyName = "SoNgayTre";
            this.colTreSoNgay.FillWeight = 10F;
            this.colTreSoNgay.HeaderText = "Số ngày trễ";
            this.colTreSoNgay.Name = "colTreSoNgay";
            // 
            // grpThongKe
            // 
            this.grpThongKe.Controls.Add(this.dgvThongKe);
            this.grpThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongKe.Location = new System.Drawing.Point(0, 0);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(1146, 309);
            this.grpThongKe.TabIndex = 0;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "Tỷ lệ hoàn thành của từng thành viên (GROUP BY)";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTKTen,
            this.colTKTong,
            this.colTKDone,
            this.colTKTyLe});
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(3, 21);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowTemplate.Height = 25;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1140, 285);
            this.dgvThongKe.TabIndex = 0;
            // 
            // colTKTen
            // 
            this.colTKTen.DataPropertyName = "HoTen";
            this.colTKTen.FillWeight = 40F;
            this.colTKTen.HeaderText = "Thành viên";
            this.colTKTen.Name = "colTKTen";
            // 
            // colTKTong
            // 
            this.colTKTong.DataPropertyName = "TongTask";
            this.colTKTong.FillWeight = 20F;
            this.colTKTong.HeaderText = "Tổng công việc";
            this.colTKTong.Name = "colTKTong";
            // 
            // colTKDone
            // 
            this.colTKDone.DataPropertyName = "DaHoanThanh";
            this.colTKDone.FillWeight = 20F;
            this.colTKDone.HeaderText = "Đã hoàn thành";
            this.colTKDone.Name = "colTKDone";
            // 
            // colTKTyLe
            // 
            this.colTKTyLe.DataPropertyName = "TyLeHoanThanh";
            this.colTKTyLe.DefaultCellStyle.Format = "0.0\\%";
            this.colTKTyLe.FillWeight = 20F;
            this.colTKTyLe.HeaderText = "Tỷ lệ";
            this.colTKTyLe.Name = "colTKTyLe";
            // 
            // panelBaoCaoTop
            // 
            this.panelBaoCaoTop.Controls.Add(this.btnTreHan);
            this.panelBaoCaoTop.Controls.Add(this.lblBCDuAn);
            this.panelBaoCaoTop.Controls.Add(this.cboBCDuAn);
            this.panelBaoCaoTop.Controls.Add(this.btnThongKe);
            this.panelBaoCaoTop.Controls.Add(this.lblTyLeTong);
            this.panelBaoCaoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaoCaoTop.Location = new System.Drawing.Point(3, 3);
            this.panelBaoCaoTop.Name = "panelBaoCaoTop";
            this.panelBaoCaoTop.Size = new System.Drawing.Size(1146, 50);
            this.panelBaoCaoTop.TabIndex = 1;
            // 
            // btnTreHan
            // 
            this.btnTreHan.Location = new System.Drawing.Point(10, 9);
            this.btnTreHan.Name = "btnTreHan";
            this.btnTreHan.Size = new System.Drawing.Size(160, 32);
            this.btnTreHan.TabIndex = 0;
            this.btnTreHan.Text = "Công việc trễ hạn";
            this.btnTreHan.UseVisualStyleBackColor = true;
            this.btnTreHan.Click += new System.EventHandler(this.btnTreHan_Click);
            // 
            // lblBCDuAn
            // 
            this.lblBCDuAn.AutoSize = true;
            this.lblBCDuAn.Location = new System.Drawing.Point(195, 15);
            this.lblBCDuAn.Name = "lblBCDuAn";
            this.lblBCDuAn.Size = new System.Drawing.Size(50, 19);
            this.lblBCDuAn.TabIndex = 1;
            this.lblBCDuAn.Text = "Dự án";
            // 
            // cboBCDuAn
            // 
            this.cboBCDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBCDuAn.FormattingEnabled = true;
            this.cboBCDuAn.Location = new System.Drawing.Point(253, 12);
            this.cboBCDuAn.Name = "cboBCDuAn";
            this.cboBCDuAn.Size = new System.Drawing.Size(250, 25);
            this.cboBCDuAn.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(520, 9);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 32);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTyLeTong
            // 
            this.lblTyLeTong.AutoSize = true;
            this.lblTyLeTong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTyLeTong.Location = new System.Drawing.Point(650, 15);
            this.lblTyLeTong.Name = "lblTyLeTong";
            this.lblTyLeTong.Size = new System.Drawing.Size(220, 20);
            this.lblTyLeTong.TabIndex = 4;
            this.lblTyLeTong.Text = "Tỷ lệ hoàn thành dự án: --";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý công việc và tiến độ dự án";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabDuAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.grpDuAn.ResumeLayout(false);
            this.grpDuAn.PerformLayout();
            this.tabCongViec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.panelCVInput.ResumeLayout(false);
            this.panelCVInput.PerformLayout();
            this.panelLoc.ResumeLayout(false);
            this.panelLoc.PerformLayout();
            this.tabKanban.ResumeLayout(false);
            this.tableKanban.ResumeLayout(false);
            this.grpToDo.ResumeLayout(false);
            this.grpInProgress.ResumeLayout(false);
            this.grpReview.ResumeLayout(false);
            this.grpDone.ResumeLayout(false);
            this.panelKanbanTop.ResumeLayout(false);
            this.panelKanbanTop.PerformLayout();
            this.tabThanhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.grpThanhVien.ResumeLayout(false);
            this.grpThanhVien.PerformLayout();
            this.tabBaoCao.ResumeLayout(false);
            this.splitBaoCao.Panel1.ResumeLayout(false);
            this.splitBaoCao.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBaoCao)).EndInit();
            this.splitBaoCao.ResumeLayout(false);
            this.grpTreHan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreHan)).EndInit();
            this.grpThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.panelBaoCaoTop.ResumeLayout(false);
            this.panelBaoCaoTop.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDuAn;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiDA;
        private System.Windows.Forms.GroupBox grpDuAn;
        private System.Windows.Forms.Label lblMaDuAn;
        private System.Windows.Forms.TextBox txtMaDuAn;
        private System.Windows.Forms.Label lblTenDuAn;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblTrangThaiDuAn;
        private System.Windows.Forms.ComboBox cboTrangThaiDuAn;
        private System.Windows.Forms.Button btnThemDuAn;
        private System.Windows.Forms.Button btnSuaDuAn;
        private System.Windows.Forms.Button btnXoaDuAn;
        private System.Windows.Forms.Button btnLamMoiDuAn;
        private System.Windows.Forms.TabPage tabCongViec;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDuAnCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanNop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhVien;
        private System.Windows.Forms.Panel panelCVInput;
        private System.Windows.Forms.Label lblCVTen;
        private System.Windows.Forms.TextBox txtCVTen;
        private System.Windows.Forms.Label lblCVDuAn;
        private System.Windows.Forms.ComboBox cboCVDuAn;
        private System.Windows.Forms.Label lblCVMoTa;
        private System.Windows.Forms.TextBox txtCVMoTa;
        private System.Windows.Forms.Label lblCVHanNop;
        private System.Windows.Forms.DateTimePicker dtpCVHanNop;
        private System.Windows.Forms.Label lblCVUuTien;
        private System.Windows.Forms.ComboBox cboCVUuTien;
        private System.Windows.Forms.Label lblCVTrangThai;
        private System.Windows.Forms.ComboBox cboCVTrangThai;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.Button btnSuaCV;
        private System.Windows.Forms.Button btnXoaCV;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Label lblCVHDSD;
        private System.Windows.Forms.Panel panelLoc;
        private System.Windows.Forms.Label lblLocDuAn;
        private System.Windows.Forms.ComboBox cboLocDuAn;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.TabPage tabKanban;
        private System.Windows.Forms.TableLayoutPanel tableKanban;
        private System.Windows.Forms.GroupBox grpToDo;
        private System.Windows.Forms.FlowLayoutPanel flowToDo;
        private System.Windows.Forms.GroupBox grpInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowInProgress;
        private System.Windows.Forms.GroupBox grpReview;
        private System.Windows.Forms.FlowLayoutPanel flowReview;
        private System.Windows.Forms.GroupBox grpDone;
        private System.Windows.Forms.FlowLayoutPanel flowDone;
        private System.Windows.Forms.Panel panelKanbanTop;
        private System.Windows.Forms.Label lblKanbanDuAn;
        private System.Windows.Forms.ComboBox cboKanbanDuAn;
        private System.Windows.Forms.Button btnKanbanRefresh;
        private System.Windows.Forms.Label lblKanbanGhiChu;
        private System.Windows.Forms.TabPage tabThanhVien;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenMon;
        private System.Windows.Forms.GroupBox grpThanhVien;
        private System.Windows.Forms.Label lblTVMa;
        private System.Windows.Forms.Label lblTVHoTen;
        private System.Windows.Forms.TextBox txtTVHoTen;
        private System.Windows.Forms.Label lblTVEmail;
        private System.Windows.Forms.TextBox txtTVEmail;
        private System.Windows.Forms.Label lblTVChuyenMon;
        private System.Windows.Forms.TextBox txtTVChuyenMon;
        private System.Windows.Forms.Button btnThemTV;
        private System.Windows.Forms.Button btnSuaTV;
        private System.Windows.Forms.Button btnXoaTV;
        private System.Windows.Forms.Button btnLamMoiTV;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.SplitContainer splitBaoCao;
        private System.Windows.Forms.GroupBox grpTreHan;
        private System.Windows.Forms.DataGridView dgvTreHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreMaTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreTenTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreHanNop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreUuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreSoNgay;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTKTyLe;
        private System.Windows.Forms.Panel panelBaoCaoTop;
        private System.Windows.Forms.Button btnTreHan;
        private System.Windows.Forms.Label lblBCDuAn;
        private System.Windows.Forms.ComboBox cboBCDuAn;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTyLeTong;
    }
}
