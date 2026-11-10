namespace QuanLyGarage.GUI
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
            this.tabTiepNhan = new System.Windows.Forms.TabPage();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.colXeBienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXeHieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXeNamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXeTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXeDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXeDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThemXe = new System.Windows.Forms.GroupBox();
            this.lblMoiBienSo = new System.Windows.Forms.Label();
            this.txtMoiBienSo = new System.Windows.Forms.TextBox();
            this.lblMoiTenKH = new System.Windows.Forms.Label();
            this.txtMoiTenKH = new System.Windows.Forms.TextBox();
            this.lblMoiDienThoai = new System.Windows.Forms.Label();
            this.txtMoiDienThoai = new System.Windows.Forms.TextBox();
            this.lblMoiDiaChi = new System.Windows.Forms.Label();
            this.txtMoiDiaChi = new System.Windows.Forms.TextBox();
            this.lblMoiHieuXe = new System.Windows.Forms.Label();
            this.txtMoiHieuXe = new System.Windows.Forms.TextBox();
            this.lblMoiNamSX = new System.Windows.Forms.Label();
            this.numMoiNamSX = new System.Windows.Forms.NumericUpDown();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.lblMoiGhiChu = new System.Windows.Forms.Label();
            this.grpTraCuu = new System.Windows.Forms.GroupBox();
            this.lblTimBienSo = new System.Windows.Forms.Label();
            this.txtTimBienSo = new System.Windows.Forms.TextBox();
            this.btnTimXe = new System.Windows.Forms.Button();
            this.lblKetQuaXe = new System.Windows.Forms.Label();
            this.tabXe = new System.Windows.Forms.TabPage();
            this.dgvXe2 = new System.Windows.Forms.DataGridView();
            this.colXe2BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXe2HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXe2NamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXe2TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXe2DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXe2DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpXeInput = new System.Windows.Forms.GroupBox();
            this.lblMaKHXe = new System.Windows.Forms.Label();
            this.txtMaKHXe = new System.Windows.Forms.TextBox();
            this.lblTenKHXe = new System.Windows.Forms.Label();
            this.txtTenKHXe = new System.Windows.Forms.TextBox();
            this.lblDienThoaiXe = new System.Windows.Forms.Label();
            this.txtDienThoaiXe = new System.Windows.Forms.TextBox();
            this.lblDiaChiXe = new System.Windows.Forms.Label();
            this.txtDiaChiXe = new System.Windows.Forms.TextBox();
            this.lblHieuXe = new System.Windows.Forms.Label();
            this.txtHieuXe = new System.Windows.Forms.TextBox();
            this.lblNamSX = new System.Windows.Forms.Label();
            this.numNamSX = new System.Windows.Forms.NumericUpDown();
            this.lblBienSoXe = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.lblGhiChuXe = new System.Windows.Forms.Label();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnLamMoiXe = new System.Windows.Forms.Button();
            this.tabPhuTung = new System.Windows.Forms.TabPage();
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.colMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPhuTung = new System.Windows.Forms.GroupBox();
            this.lblMaPhuTung = new System.Windows.Forms.Label();
            this.lblTenPhuTung = new System.Windows.Forms.Label();
            this.txtTenPhuTungPT = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.numSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.btnSuaPT = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.btnLamMoiPT = new System.Windows.Forms.Button();
            this.tabPhieu = new System.Windows.Forms.TabPage();
            this.grpDanhSachPhieu = new System.Windows.Forms.GroupBox();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBienSoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKHPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDungPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChiTietPhieu = new System.Windows.Forms.Panel();
            this.dgvChiTietPhieu = new System.Windows.Forms.DataGridView();
            this.colCTTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChiTietPhieu = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grpLapPhieu = new System.Windows.Forms.GroupBox();
            this.lblBienSoPhieu = new System.Windows.Forms.Label();
            this.txtBienSoPhieu = new System.Windows.Forms.TextBox();
            this.btnTimXePhieu = new System.Windows.Forms.Button();
            this.lblXePhieu = new System.Windows.Forms.Label();
            this.lblNoiDungSua = new System.Windows.Forms.Label();
            this.txtNoiDungSua = new System.Windows.Forms.TextBox();
            this.lblChonPhuTung = new System.Windows.Forms.Label();
            this.cboPhuTung = new System.Windows.Forms.ComboBox();
            this.lblSoLuongPhieu = new System.Windows.Forms.Label();
            this.numSoLuongPhieu = new System.Windows.Forms.NumericUpDown();
            this.lblTienCong = new System.Windows.Forms.Label();
            this.numTienCong = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhuTungVaoPhieu = new System.Windows.Forms.Button();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.colTamTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamTienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDongChiTiet = new System.Windows.Forms.Button();
            this.lblTongTamTinh = new System.Windows.Forms.Label();
            this.btnHoanTatPhieu = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.grpThemXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoiNamSX)).BeginInit();
            this.grpTraCuu.SuspendLayout();
            this.tabXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe2)).BeginInit();
            this.grpXeInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSX)).BeginInit();
            this.tabPhuTung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.grpPhuTung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).BeginInit();
            this.tabPhieu.SuspendLayout();
            this.grpDanhSachPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.panelChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).BeginInit();
            this.grpLapPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTiepNhan);
            this.tabMain.Controls.Add(this.tabXe);
            this.tabMain.Controls.Add(this.tabPhuTung);
            this.tabMain.Controls.Add(this.tabPhieu);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1180, 720);
            this.tabMain.TabIndex = 0;
            // 
            // tabTiepNhan
            // 
            this.tabTiepNhan.Controls.Add(this.dgvXe);
            this.tabTiepNhan.Controls.Add(this.grpThemXe);
            this.tabTiepNhan.Controls.Add(this.grpTraCuu);
            this.tabTiepNhan.Location = new System.Drawing.Point(4, 27);
            this.tabTiepNhan.Name = "tabTiepNhan";
            this.tabTiepNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiepNhan.Size = new System.Drawing.Size(1172, 689);
            this.tabTiepNhan.TabIndex = 0;
            this.tabTiepNhan.Text = "Tiếp nhận xe";
            this.tabTiepNhan.UseVisualStyleBackColor = true;
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToAddRows = false;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXeBienSo,
            this.colXeHieuXe,
            this.colXeNamSX,
            this.colXeTenKH,
            this.colXeDienThoai,
            this.colXeDiaChi});
            this.dgvXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXe.Location = new System.Drawing.Point(3, 296);
            this.dgvXe.MultiSelect = false;
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowTemplate.Height = 25;
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(1166, 390);
            this.dgvXe.TabIndex = 2;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // colXeBienSo
            // 
            this.colXeBienSo.DataPropertyName = "BienSo";
            this.colXeBienSo.FillWeight = 15F;
            this.colXeBienSo.HeaderText = "Biển số";
            this.colXeBienSo.Name = "colXeBienSo";
            // 
            // colXeHieuXe
            // 
            this.colXeHieuXe.DataPropertyName = "HieuXe";
            this.colXeHieuXe.FillWeight = 15F;
            this.colXeHieuXe.HeaderText = "Hiệu xe";
            this.colXeHieuXe.Name = "colXeHieuXe";
            // 
            // colXeNamSX
            // 
            this.colXeNamSX.DataPropertyName = "NamSanXuat";
            this.colXeNamSX.FillWeight = 10F;
            this.colXeNamSX.HeaderText = "Năm SX";
            this.colXeNamSX.Name = "colXeNamSX";
            // 
            // colXeTenKH
            // 
            this.colXeTenKH.DataPropertyName = "TenKH";
            this.colXeTenKH.FillWeight = 20F;
            this.colXeTenKH.HeaderText = "Chủ xe";
            this.colXeTenKH.Name = "colXeTenKH";
            // 
            // colXeDienThoai
            // 
            this.colXeDienThoai.DataPropertyName = "DienThoai";
            this.colXeDienThoai.FillWeight = 15F;
            this.colXeDienThoai.HeaderText = "Điện thoại";
            this.colXeDienThoai.Name = "colXeDienThoai";
            // 
            // colXeDiaChi
            // 
            this.colXeDiaChi.DataPropertyName = "DiaChi";
            this.colXeDiaChi.FillWeight = 30F;
            this.colXeDiaChi.HeaderText = "Địa chỉ";
            this.colXeDiaChi.Name = "colXeDiaChi";
            // 
            // grpThemXe
            // 
            this.grpThemXe.Controls.Add(this.lblMoiBienSo);
            this.grpThemXe.Controls.Add(this.txtMoiBienSo);
            this.grpThemXe.Controls.Add(this.lblMoiTenKH);
            this.grpThemXe.Controls.Add(this.txtMoiTenKH);
            this.grpThemXe.Controls.Add(this.lblMoiDienThoai);
            this.grpThemXe.Controls.Add(this.txtMoiDienThoai);
            this.grpThemXe.Controls.Add(this.lblMoiDiaChi);
            this.grpThemXe.Controls.Add(this.txtMoiDiaChi);
            this.grpThemXe.Controls.Add(this.lblMoiHieuXe);
            this.grpThemXe.Controls.Add(this.txtMoiHieuXe);
            this.grpThemXe.Controls.Add(this.lblMoiNamSX);
            this.grpThemXe.Controls.Add(this.numMoiNamSX);
            this.grpThemXe.Controls.Add(this.btnThemXe);
            this.grpThemXe.Controls.Add(this.lblMoiGhiChu);
            this.grpThemXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThemXe.Location = new System.Drawing.Point(3, 126);
            this.grpThemXe.Name = "grpThemXe";
            this.grpThemXe.Size = new System.Drawing.Size(1166, 170);
            this.grpThemXe.TabIndex = 1;
            this.grpThemXe.TabStop = false;
            this.grpThemXe.Text = "Thêm chủ xe và xe mới (khi biển số chưa có)";
            // 
            // lblMoiBienSo
            // 
            this.lblMoiBienSo.AutoSize = true;
            this.lblMoiBienSo.Location = new System.Drawing.Point(15, 32);
            this.lblMoiBienSo.Name = "lblMoiBienSo";
            this.lblMoiBienSo.Size = new System.Drawing.Size(55, 19);
            this.lblMoiBienSo.TabIndex = 0;
            this.lblMoiBienSo.Text = "Biển số";
            // 
            // txtMoiBienSo
            // 
            this.txtMoiBienSo.Location = new System.Drawing.Point(120, 29);
            this.txtMoiBienSo.Name = "txtMoiBienSo";
            this.txtMoiBienSo.Size = new System.Drawing.Size(160, 25);
            this.txtMoiBienSo.TabIndex = 1;
            // 
            // lblMoiTenKH
            // 
            this.lblMoiTenKH.AutoSize = true;
            this.lblMoiTenKH.Location = new System.Drawing.Point(300, 32);
            this.lblMoiTenKH.Name = "lblMoiTenKH";
            this.lblMoiTenKH.Size = new System.Drawing.Size(71, 19);
            this.lblMoiTenKH.TabIndex = 2;
            this.lblMoiTenKH.Text = "Tên chủ xe";
            // 
            // txtMoiTenKH
            // 
            this.txtMoiTenKH.Location = new System.Drawing.Point(400, 29);
            this.txtMoiTenKH.Name = "txtMoiTenKH";
            this.txtMoiTenKH.Size = new System.Drawing.Size(220, 25);
            this.txtMoiTenKH.TabIndex = 3;
            // 
            // lblMoiDienThoai
            // 
            this.lblMoiDienThoai.AutoSize = true;
            this.lblMoiDienThoai.Location = new System.Drawing.Point(640, 32);
            this.lblMoiDienThoai.Name = "lblMoiDienThoai";
            this.lblMoiDienThoai.Size = new System.Drawing.Size(77, 19);
            this.lblMoiDienThoai.TabIndex = 4;
            this.lblMoiDienThoai.Text = "Điện thoại";
            // 
            // txtMoiDienThoai
            // 
            this.txtMoiDienThoai.Location = new System.Drawing.Point(740, 29);
            this.txtMoiDienThoai.Name = "txtMoiDienThoai";
            this.txtMoiDienThoai.Size = new System.Drawing.Size(150, 25);
            this.txtMoiDienThoai.TabIndex = 5;
            // 
            // lblMoiDiaChi
            // 
            this.lblMoiDiaChi.AutoSize = true;
            this.lblMoiDiaChi.Location = new System.Drawing.Point(15, 72);
            this.lblMoiDiaChi.Name = "lblMoiDiaChi";
            this.lblMoiDiaChi.Size = new System.Drawing.Size(51, 19);
            this.lblMoiDiaChi.TabIndex = 6;
            this.lblMoiDiaChi.Text = "Địa chỉ";
            // 
            // txtMoiDiaChi
            // 
            this.txtMoiDiaChi.Location = new System.Drawing.Point(120, 69);
            this.txtMoiDiaChi.Name = "txtMoiDiaChi";
            this.txtMoiDiaChi.Size = new System.Drawing.Size(400, 25);
            this.txtMoiDiaChi.TabIndex = 7;
            // 
            // lblMoiHieuXe
            // 
            this.lblMoiHieuXe.AutoSize = true;
            this.lblMoiHieuXe.Location = new System.Drawing.Point(540, 72);
            this.lblMoiHieuXe.Name = "lblMoiHieuXe";
            this.lblMoiHieuXe.Size = new System.Drawing.Size(58, 19);
            this.lblMoiHieuXe.TabIndex = 8;
            this.lblMoiHieuXe.Text = "Hiệu xe";
            // 
            // txtMoiHieuXe
            // 
            this.txtMoiHieuXe.Location = new System.Drawing.Point(620, 69);
            this.txtMoiHieuXe.Name = "txtMoiHieuXe";
            this.txtMoiHieuXe.Size = new System.Drawing.Size(140, 25);
            this.txtMoiHieuXe.TabIndex = 9;
            // 
            // lblMoiNamSX
            // 
            this.lblMoiNamSX.AutoSize = true;
            this.lblMoiNamSX.Location = new System.Drawing.Point(780, 72);
            this.lblMoiNamSX.Name = "lblMoiNamSX";
            this.lblMoiNamSX.Size = new System.Drawing.Size(40, 19);
            this.lblMoiNamSX.TabIndex = 10;
            this.lblMoiNamSX.Text = "Năm";
            // 
            // numMoiNamSX
            // 
            this.numMoiNamSX.Location = new System.Drawing.Point(860, 69);
            this.numMoiNamSX.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.numMoiNamSX.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numMoiNamSX.Name = "numMoiNamSX";
            this.numMoiNamSX.Size = new System.Drawing.Size(100, 25);
            this.numMoiNamSX.TabIndex = 11;
            this.numMoiNamSX.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // btnThemXe
            // 
            this.btnThemXe.Location = new System.Drawing.Point(120, 112);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(130, 34);
            this.btnThemXe.TabIndex = 12;
            this.btnThemXe.Text = "Thêm xe mới";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // lblMoiGhiChu
            // 
            this.lblMoiGhiChu.AutoSize = true;
            this.lblMoiGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.lblMoiGhiChu.Location = new System.Drawing.Point(265, 120);
            this.lblMoiGhiChu.Name = "lblMoiGhiChu";
            this.lblMoiGhiChu.Size = new System.Drawing.Size(300, 19);
            this.lblMoiGhiChu.TabIndex = 13;
            this.lblMoiGhiChu.Text = "Biển số và số điện thoại không được trùng.";
            // 
            // grpTraCuu
            // 
            this.grpTraCuu.Controls.Add(this.lblTimBienSo);
            this.grpTraCuu.Controls.Add(this.txtTimBienSo);
            this.grpTraCuu.Controls.Add(this.btnTimXe);
            this.grpTraCuu.Controls.Add(this.lblKetQuaXe);
            this.grpTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTraCuu.Location = new System.Drawing.Point(3, 3);
            this.grpTraCuu.Name = "grpTraCuu";
            this.grpTraCuu.Size = new System.Drawing.Size(1166, 123);
            this.grpTraCuu.TabIndex = 0;
            this.grpTraCuu.TabStop = false;
            this.grpTraCuu.Text = "Tra cứu biển số xe";
            // 
            // lblTimBienSo
            // 
            this.lblTimBienSo.AutoSize = true;
            this.lblTimBienSo.Location = new System.Drawing.Point(15, 32);
            this.lblTimBienSo.Name = "lblTimBienSo";
            this.lblTimBienSo.Size = new System.Drawing.Size(55, 19);
            this.lblTimBienSo.TabIndex = 0;
            this.lblTimBienSo.Text = "Biển số";
            // 
            // txtTimBienSo
            // 
            this.txtTimBienSo.Location = new System.Drawing.Point(120, 29);
            this.txtTimBienSo.Name = "txtTimBienSo";
            this.txtTimBienSo.Size = new System.Drawing.Size(180, 25);
            this.txtTimBienSo.TabIndex = 1;
            // 
            // btnTimXe
            // 
            this.btnTimXe.Location = new System.Drawing.Point(315, 26);
            this.btnTimXe.Name = "btnTimXe";
            this.btnTimXe.Size = new System.Drawing.Size(100, 32);
            this.btnTimXe.TabIndex = 2;
            this.btnTimXe.Text = "Tìm xe";
            this.btnTimXe.UseVisualStyleBackColor = true;
            this.btnTimXe.Click += new System.EventHandler(this.btnTimXe_Click);
            // 
            // lblKetQuaXe
            // 
            this.lblKetQuaXe.ForeColor = System.Drawing.Color.DimGray;
            this.lblKetQuaXe.Location = new System.Drawing.Point(15, 68);
            this.lblKetQuaXe.Name = "lblKetQuaXe";
            this.lblKetQuaXe.Size = new System.Drawing.Size(1000, 45);
            this.lblKetQuaXe.TabIndex = 3;
            this.lblKetQuaXe.Text = "Nhập biển số để tra cứu thông tin xe và chủ xe.";
            // 
            // tabXe
            // 
            this.tabXe.Controls.Add(this.dgvXe2);
            this.tabXe.Controls.Add(this.grpXeInput);
            this.tabXe.Location = new System.Drawing.Point(4, 27);
            this.tabXe.Name = "tabXe";
            this.tabXe.Padding = new System.Windows.Forms.Padding(3);
            this.tabXe.Size = new System.Drawing.Size(1172, 689);
            this.tabXe.TabIndex = 1;
            this.tabXe.Text = "Danh mục xe";
            this.tabXe.UseVisualStyleBackColor = true;
            // 
            // dgvXe2
            // 
            this.dgvXe2.AllowUserToAddRows = false;
            this.dgvXe2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe2.BackgroundColor = System.Drawing.Color.White;
            this.dgvXe2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXe2BienSo,
            this.colXe2HieuXe,
            this.colXe2NamSX,
            this.colXe2TenKH,
            this.colXe2DienThoai,
            this.colXe2DiaChi});
            this.dgvXe2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXe2.Location = new System.Drawing.Point(3, 203);
            this.dgvXe2.MultiSelect = false;
            this.dgvXe2.Name = "dgvXe2";
            this.dgvXe2.ReadOnly = true;
            this.dgvXe2.RowHeadersVisible = false;
            this.dgvXe2.RowTemplate.Height = 25;
            this.dgvXe2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe2.Size = new System.Drawing.Size(1166, 483);
            this.dgvXe2.TabIndex = 1;
            this.dgvXe2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe2_CellClick);
            // 
            // colXe2BienSo
            // 
            this.colXe2BienSo.DataPropertyName = "BienSo";
            this.colXe2BienSo.FillWeight = 15F;
            this.colXe2BienSo.HeaderText = "Biển số";
            this.colXe2BienSo.Name = "colXe2BienSo";
            // 
            // colXe2HieuXe
            // 
            this.colXe2HieuXe.DataPropertyName = "HieuXe";
            this.colXe2HieuXe.FillWeight = 15F;
            this.colXe2HieuXe.HeaderText = "Hiệu xe";
            this.colXe2HieuXe.Name = "colXe2HieuXe";
            // 
            // colXe2NamSX
            // 
            this.colXe2NamSX.DataPropertyName = "NamSanXuat";
            this.colXe2NamSX.FillWeight = 10F;
            this.colXe2NamSX.HeaderText = "Năm SX";
            this.colXe2NamSX.Name = "colXe2NamSX";
            // 
            // colXe2TenKH
            // 
            this.colXe2TenKH.DataPropertyName = "TenKH";
            this.colXe2TenKH.FillWeight = 20F;
            this.colXe2TenKH.HeaderText = "Chủ xe";
            this.colXe2TenKH.Name = "colXe2TenKH";
            // 
            // colXe2DienThoai
            // 
            this.colXe2DienThoai.DataPropertyName = "DienThoai";
            this.colXe2DienThoai.FillWeight = 15F;
            this.colXe2DienThoai.HeaderText = "Điện thoại";
            this.colXe2DienThoai.Name = "colXe2DienThoai";
            // 
            // colXe2DiaChi
            // 
            this.colXe2DiaChi.DataPropertyName = "DiaChi";
            this.colXe2DiaChi.FillWeight = 30F;
            this.colXe2DiaChi.HeaderText = "Địa chỉ";
            this.colXe2DiaChi.Name = "colXe2DiaChi";
            // 
            // grpXeInput
            // 
            this.grpXeInput.Controls.Add(this.lblMaKHXe);
            this.grpXeInput.Controls.Add(this.txtMaKHXe);
            this.grpXeInput.Controls.Add(this.lblTenKHXe);
            this.grpXeInput.Controls.Add(this.txtTenKHXe);
            this.grpXeInput.Controls.Add(this.lblDienThoaiXe);
            this.grpXeInput.Controls.Add(this.txtDienThoaiXe);
            this.grpXeInput.Controls.Add(this.lblDiaChiXe);
            this.grpXeInput.Controls.Add(this.txtDiaChiXe);
            this.grpXeInput.Controls.Add(this.lblHieuXe);
            this.grpXeInput.Controls.Add(this.txtHieuXe);
            this.grpXeInput.Controls.Add(this.lblNamSX);
            this.grpXeInput.Controls.Add(this.numNamSX);
            this.grpXeInput.Controls.Add(this.lblBienSoXe);
            this.grpXeInput.Controls.Add(this.txtBienSoXe);
            this.grpXeInput.Controls.Add(this.lblGhiChuXe);
            this.grpXeInput.Controls.Add(this.btnSuaXe);
            this.grpXeInput.Controls.Add(this.btnXoaXe);
            this.grpXeInput.Controls.Add(this.btnLamMoiXe);
            this.grpXeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpXeInput.Location = new System.Drawing.Point(3, 3);
            this.grpXeInput.Name = "grpXeInput";
            this.grpXeInput.Size = new System.Drawing.Size(1166, 200);
            this.grpXeInput.TabIndex = 0;
            this.grpXeInput.TabStop = false;
            this.grpXeInput.Text = "Thông tin xe và chủ xe";
            // 
            // lblMaKHXe
            // 
            this.lblMaKHXe.AutoSize = true;
            this.lblMaKHXe.Location = new System.Drawing.Point(15, 32);
            this.lblMaKHXe.Name = "lblMaKHXe";
            this.lblMaKHXe.Size = new System.Drawing.Size(53, 19);
            this.lblMaKHXe.TabIndex = 0;
            this.lblMaKHXe.Text = "Mã KH";
            // 
            // txtMaKHXe
            // 
            this.txtMaKHXe.Location = new System.Drawing.Point(100, 29);
            this.txtMaKHXe.Name = "txtMaKHXe";
            this.txtMaKHXe.ReadOnly = true;
            this.txtMaKHXe.Size = new System.Drawing.Size(70, 25);
            this.txtMaKHXe.TabIndex = 1;
            // 
            // lblTenKHXe
            // 
            this.lblTenKHXe.AutoSize = true;
            this.lblTenKHXe.Location = new System.Drawing.Point(200, 32);
            this.lblTenKHXe.Name = "lblTenKHXe";
            this.lblTenKHXe.Size = new System.Drawing.Size(71, 19);
            this.lblTenKHXe.TabIndex = 2;
            this.lblTenKHXe.Text = "Tên chủ xe";
            // 
            // txtTenKHXe
            // 
            this.txtTenKHXe.Location = new System.Drawing.Point(280, 29);
            this.txtTenKHXe.Name = "txtTenKHXe";
            this.txtTenKHXe.Size = new System.Drawing.Size(220, 25);
            this.txtTenKHXe.TabIndex = 3;
            // 
            // lblDienThoaiXe
            // 
            this.lblDienThoaiXe.AutoSize = true;
            this.lblDienThoaiXe.Location = new System.Drawing.Point(520, 32);
            this.lblDienThoaiXe.Name = "lblDienThoaiXe";
            this.lblDienThoaiXe.Size = new System.Drawing.Size(77, 19);
            this.lblDienThoaiXe.TabIndex = 4;
            this.lblDienThoaiXe.Text = "Điện thoại";
            // 
            // txtDienThoaiXe
            // 
            this.txtDienThoaiXe.Location = new System.Drawing.Point(610, 29);
            this.txtDienThoaiXe.Name = "txtDienThoaiXe";
            this.txtDienThoaiXe.Size = new System.Drawing.Size(150, 25);
            this.txtDienThoaiXe.TabIndex = 5;
            // 
            // lblDiaChiXe
            // 
            this.lblDiaChiXe.AutoSize = true;
            this.lblDiaChiXe.Location = new System.Drawing.Point(15, 72);
            this.lblDiaChiXe.Name = "lblDiaChiXe";
            this.lblDiaChiXe.Size = new System.Drawing.Size(51, 19);
            this.lblDiaChiXe.TabIndex = 6;
            this.lblDiaChiXe.Text = "Địa chỉ";
            // 
            // txtDiaChiXe
            // 
            this.txtDiaChiXe.Location = new System.Drawing.Point(100, 69);
            this.txtDiaChiXe.Name = "txtDiaChiXe";
            this.txtDiaChiXe.Size = new System.Drawing.Size(350, 25);
            this.txtDiaChiXe.TabIndex = 7;
            // 
            // lblHieuXe
            // 
            this.lblHieuXe.AutoSize = true;
            this.lblHieuXe.Location = new System.Drawing.Point(470, 72);
            this.lblHieuXe.Name = "lblHieuXe";
            this.lblHieuXe.Size = new System.Drawing.Size(58, 19);
            this.lblHieuXe.TabIndex = 8;
            this.lblHieuXe.Text = "Hiệu xe";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(540, 69);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(140, 25);
            this.txtHieuXe.TabIndex = 9;
            // 
            // lblNamSX
            // 
            this.lblNamSX.AutoSize = true;
            this.lblNamSX.Location = new System.Drawing.Point(700, 72);
            this.lblNamSX.Name = "lblNamSX";
            this.lblNamSX.Size = new System.Drawing.Size(40, 19);
            this.lblNamSX.TabIndex = 10;
            this.lblNamSX.Text = "Năm";
            // 
            // numNamSX
            // 
            this.numNamSX.Location = new System.Drawing.Point(770, 69);
            this.numNamSX.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.numNamSX.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numNamSX.Name = "numNamSX";
            this.numNamSX.Size = new System.Drawing.Size(100, 25);
            this.numNamSX.TabIndex = 11;
            this.numNamSX.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // lblBienSoXe
            // 
            this.lblBienSoXe.AutoSize = true;
            this.lblBienSoXe.Location = new System.Drawing.Point(15, 112);
            this.lblBienSoXe.Name = "lblBienSoXe";
            this.lblBienSoXe.Size = new System.Drawing.Size(55, 19);
            this.lblBienSoXe.TabIndex = 12;
            this.lblBienSoXe.Text = "Biển số";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(100, 109);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.ReadOnly = true;
            this.txtBienSoXe.Size = new System.Drawing.Size(160, 25);
            this.txtBienSoXe.TabIndex = 13;
            // 
            // lblGhiChuXe
            // 
            this.lblGhiChuXe.AutoSize = true;
            this.lblGhiChuXe.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChuXe.Location = new System.Drawing.Point(280, 112);
            this.lblGhiChuXe.Name = "lblGhiChuXe";
            this.lblGhiChuXe.Size = new System.Drawing.Size(380, 19);
            this.lblGhiChuXe.TabIndex = 14;
            this.lblGhiChuXe.Text = "Muốn thêm xe mới, hãy dùng tab Tiếp nhận xe.";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Location = new System.Drawing.Point(100, 150);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(110, 32);
            this.btnSuaXe.TabIndex = 15;
            this.btnSuaXe.Text = "Sửa";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Location = new System.Drawing.Point(220, 150);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(110, 32);
            this.btnXoaXe.TabIndex = 16;
            this.btnXoaXe.Text = "Xóa";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnLamMoiXe
            // 
            this.btnLamMoiXe.Location = new System.Drawing.Point(340, 150);
            this.btnLamMoiXe.Name = "btnLamMoiXe";
            this.btnLamMoiXe.Size = new System.Drawing.Size(110, 32);
            this.btnLamMoiXe.TabIndex = 17;
            this.btnLamMoiXe.Text = "Làm mới";
            this.btnLamMoiXe.UseVisualStyleBackColor = true;
            this.btnLamMoiXe.Click += new System.EventHandler(this.btnLamMoiXe_Click);
            // 
            // tabPhuTung
            // 
            this.tabPhuTung.Controls.Add(this.dgvPhuTung);
            this.tabPhuTung.Controls.Add(this.grpPhuTung);
            this.tabPhuTung.Location = new System.Drawing.Point(4, 27);
            this.tabPhuTung.Name = "tabPhuTung";
            this.tabPhuTung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTung.Size = new System.Drawing.Size(1172, 689);
            this.tabPhuTung.TabIndex = 2;
            this.tabPhuTung.Text = "Phụ tùng";
            this.tabPhuTung.UseVisualStyleBackColor = true;
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.AllowUserToAddRows = false;
            this.dgvPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuTung.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPT,
            this.colTenPT,
            this.colDonGia,
            this.colTonKho});
            this.dgvPhuTung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhuTung.Location = new System.Drawing.Point(3, 153);
            this.dgvPhuTung.MultiSelect = false;
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.ReadOnly = true;
            this.dgvPhuTung.RowHeadersVisible = false;
            this.dgvPhuTung.RowTemplate.Height = 25;
            this.dgvPhuTung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuTung.Size = new System.Drawing.Size(1166, 533);
            this.dgvPhuTung.TabIndex = 1;
            this.dgvPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellClick);
            // 
            // colMaPT
            // 
            this.colMaPT.DataPropertyName = "MaPhuTung";
            this.colMaPT.FillWeight = 12F;
            this.colMaPT.HeaderText = "Mã";
            this.colMaPT.Name = "colMaPT";
            // 
            // colTenPT
            // 
            this.colTenPT.DataPropertyName = "TenPhuTung";
            this.colTenPT.FillWeight = 50F;
            this.colTenPT.HeaderText = "Tên phụ tùng";
            this.colTenPT.Name = "colTenPT";
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.DefaultCellStyle.Format = "N0";
            this.colDonGia.FillWeight = 20F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            // 
            // colTonKho
            // 
            this.colTonKho.DataPropertyName = "SoLuongTon";
            this.colTonKho.FillWeight = 18F;
            this.colTonKho.HeaderText = "Số lượng tồn";
            this.colTonKho.Name = "colTonKho";
            // 
            // grpPhuTung
            // 
            this.grpPhuTung.Controls.Add(this.lblMaPhuTung);
            this.grpPhuTung.Controls.Add(this.lblTenPhuTung);
            this.grpPhuTung.Controls.Add(this.txtTenPhuTungPT);
            this.grpPhuTung.Controls.Add(this.lblDonGia);
            this.grpPhuTung.Controls.Add(this.numDonGia);
            this.grpPhuTung.Controls.Add(this.lblSoLuongTon);
            this.grpPhuTung.Controls.Add(this.numSoLuongTon);
            this.grpPhuTung.Controls.Add(this.btnThemPT);
            this.grpPhuTung.Controls.Add(this.btnSuaPT);
            this.grpPhuTung.Controls.Add(this.btnXoaPT);
            this.grpPhuTung.Controls.Add(this.btnLamMoiPT);
            this.grpPhuTung.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPhuTung.Location = new System.Drawing.Point(3, 3);
            this.grpPhuTung.Name = "grpPhuTung";
            this.grpPhuTung.Size = new System.Drawing.Size(1166, 150);
            this.grpPhuTung.TabIndex = 0;
            this.grpPhuTung.TabStop = false;
            this.grpPhuTung.Text = "Thông tin phụ tùng";
            // 
            // lblMaPhuTung
            // 
            this.lblMaPhuTung.AutoSize = true;
            this.lblMaPhuTung.ForeColor = System.Drawing.Color.Gray;
            this.lblMaPhuTung.Location = new System.Drawing.Point(15, 90);
            this.lblMaPhuTung.Name = "lblMaPhuTung";
            this.lblMaPhuTung.Size = new System.Drawing.Size(90, 19);
            this.lblMaPhuTung.TabIndex = 0;
            this.lblMaPhuTung.Text = "Mã phụ tùng: --";
            // 
            // lblTenPhuTung
            // 
            this.lblTenPhuTung.AutoSize = true;
            this.lblTenPhuTung.Location = new System.Drawing.Point(15, 32);
            this.lblTenPhuTung.Name = "lblTenPhuTung";
            this.lblTenPhuTung.Size = new System.Drawing.Size(91, 19);
            this.lblTenPhuTung.TabIndex = 1;
            this.lblTenPhuTung.Text = "Tên phụ tùng";
            // 
            // txtTenPhuTungPT
            // 
            this.txtTenPhuTungPT.Location = new System.Drawing.Point(120, 29);
            this.txtTenPhuTungPT.Name = "txtTenPhuTungPT";
            this.txtTenPhuTungPT.Size = new System.Drawing.Size(300, 25);
            this.txtTenPhuTungPT.TabIndex = 2;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(450, 32);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(59, 19);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // numDonGia
            // 
            this.numDonGia.Location = new System.Drawing.Point(520, 29);
            this.numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(150, 25);
            this.numDonGia.TabIndex = 4;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(700, 32);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(90, 19);
            this.lblSoLuongTon.TabIndex = 5;
            this.lblSoLuongTon.Text = "Số lượng tồn";
            // 
            // numSoLuongTon
            // 
            this.numSoLuongTon.Location = new System.Drawing.Point(800, 29);
            this.numSoLuongTon.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numSoLuongTon.Name = "numSoLuongTon";
            this.numSoLuongTon.Size = new System.Drawing.Size(100, 25);
            this.numSoLuongTon.TabIndex = 6;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(120, 70);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(100, 32);
            this.btnThemPT.TabIndex = 7;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.UseVisualStyleBackColor = true;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.Location = new System.Drawing.Point(230, 70);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(100, 32);
            this.btnSuaPT.TabIndex = 8;
            this.btnSuaPT.Text = "Sửa";
            this.btnSuaPT.UseVisualStyleBackColor = true;
            this.btnSuaPT.Click += new System.EventHandler(this.btnSuaPT_Click);
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.Location = new System.Drawing.Point(340, 70);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(100, 32);
            this.btnXoaPT.TabIndex = 9;
            this.btnXoaPT.Text = "Xóa";
            this.btnXoaPT.UseVisualStyleBackColor = true;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // btnLamMoiPT
            // 
            this.btnLamMoiPT.Location = new System.Drawing.Point(450, 70);
            this.btnLamMoiPT.Name = "btnLamMoiPT";
            this.btnLamMoiPT.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoiPT.TabIndex = 10;
            this.btnLamMoiPT.Text = "Làm mới";
            this.btnLamMoiPT.UseVisualStyleBackColor = true;
            this.btnLamMoiPT.Click += new System.EventHandler(this.btnLamMoiPT_Click);
            // 
            // tabPhieu
            // 
            this.tabPhieu.Controls.Add(this.grpDanhSachPhieu);
            this.tabPhieu.Controls.Add(this.grpLapPhieu);
            this.tabPhieu.Location = new System.Drawing.Point(4, 27);
            this.tabPhieu.Name = "tabPhieu";
            this.tabPhieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieu.Size = new System.Drawing.Size(1172, 689);
            this.tabPhieu.TabIndex = 3;
            this.tabPhieu.Text = "Phiếu sửa chữa";
            this.tabPhieu.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachPhieu
            // 
            this.grpDanhSachPhieu.Controls.Add(this.dgvPhieu);
            this.grpDanhSachPhieu.Controls.Add(this.panelChiTietPhieu);
            this.grpDanhSachPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSachPhieu.Location = new System.Drawing.Point(3, 333);
            this.grpDanhSachPhieu.Name = "grpDanhSachPhieu";
            this.grpDanhSachPhieu.Size = new System.Drawing.Size(1166, 353);
            this.grpDanhSachPhieu.TabIndex = 1;
            this.grpDanhSachPhieu.TabStop = false;
            this.grpDanhSachPhieu.Text = "Danh sách phiếu sửa chữa";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colBienSoPhieu,
            this.colTenKHPhieu,
            this.colNgayNhan,
            this.colNoiDungPhieu,
            this.colTongTien,
            this.colTrangThaiPhieu});
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieu.Location = new System.Drawing.Point(3, 21);
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.RowTemplate.Height = 25;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(820, 329);
            this.dgvPhieu.TabIndex = 0;
            this.dgvPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieu_CellClick);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieu";
            this.colMaPhieu.FillWeight = 8F;
            this.colMaPhieu.HeaderText = "Mã";
            this.colMaPhieu.Name = "colMaPhieu";
            // 
            // colBienSoPhieu
            // 
            this.colBienSoPhieu.DataPropertyName = "BienSo";
            this.colBienSoPhieu.FillWeight = 14F;
            this.colBienSoPhieu.HeaderText = "Biển số";
            this.colBienSoPhieu.Name = "colBienSoPhieu";
            // 
            // colTenKHPhieu
            // 
            this.colTenKHPhieu.DataPropertyName = "TenKH";
            this.colTenKHPhieu.FillWeight = 18F;
            this.colTenKHPhieu.HeaderText = "Chủ xe";
            this.colTenKHPhieu.Name = "colTenKHPhieu";
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.DataPropertyName = "NgayNhan";
            this.colNgayNhan.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colNgayNhan.FillWeight = 14F;
            this.colNgayNhan.HeaderText = "Ngày nhận";
            this.colNgayNhan.Name = "colNgayNhan";
            // 
            // colNoiDungPhieu
            // 
            this.colNoiDungPhieu.DataPropertyName = "NoiDungSua";
            this.colNoiDungPhieu.FillWeight = 20F;
            this.colNoiDungPhieu.HeaderText = "Nội dung sửa";
            this.colNoiDungPhieu.Name = "colNoiDungPhieu";
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.DefaultCellStyle.Format = "N0";
            this.colTongTien.FillWeight = 12F;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            // 
            // colTrangThaiPhieu
            // 
            this.colTrangThaiPhieu.DataPropertyName = "TrangThai";
            this.colTrangThaiPhieu.FillWeight = 14F;
            this.colTrangThaiPhieu.HeaderText = "Trạng thái";
            this.colTrangThaiPhieu.Name = "colTrangThaiPhieu";
            // 
            // panelChiTietPhieu
            // 
            this.panelChiTietPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChiTietPhieu.Controls.Add(this.dgvChiTietPhieu);
            this.panelChiTietPhieu.Controls.Add(this.lblChiTietPhieu);
            this.panelChiTietPhieu.Controls.Add(this.btnThanhToan);
            this.panelChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChiTietPhieu.Location = new System.Drawing.Point(823, 21);
            this.panelChiTietPhieu.Name = "panelChiTietPhieu";
            this.panelChiTietPhieu.Size = new System.Drawing.Size(340, 329);
            this.panelChiTietPhieu.TabIndex = 1;
            // 
            // dgvChiTietPhieu
            // 
            this.dgvChiTietPhieu.AllowUserToAddRows = false;
            this.dgvChiTietPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCTTen,
            this.colCTSoLuong,
            this.colCTDonGia,
            this.colCTTienCong,
            this.colCTThanhTien});
            this.dgvChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieu.Location = new System.Drawing.Point(0, 30);
            this.dgvChiTietPhieu.Name = "dgvChiTietPhieu";
            this.dgvChiTietPhieu.ReadOnly = true;
            this.dgvChiTietPhieu.RowHeadersVisible = false;
            this.dgvChiTietPhieu.RowTemplate.Height = 25;
            this.dgvChiTietPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieu.Size = new System.Drawing.Size(338, 247);
            this.dgvChiTietPhieu.TabIndex = 1;
            // 
            // colCTTen
            // 
            this.colCTTen.DataPropertyName = "TenPhuTung";
            this.colCTTen.FillWeight = 34F;
            this.colCTTen.HeaderText = "Phụ tùng";
            this.colCTTen.Name = "colCTTen";
            // 
            // colCTSoLuong
            // 
            this.colCTSoLuong.DataPropertyName = "SoLuong";
            this.colCTSoLuong.FillWeight = 12F;
            this.colCTSoLuong.HeaderText = "SL";
            this.colCTSoLuong.Name = "colCTSoLuong";
            // 
            // colCTDonGia
            // 
            this.colCTDonGia.DataPropertyName = "DonGia";
            this.colCTDonGia.DefaultCellStyle.Format = "N0";
            this.colCTDonGia.FillWeight = 18F;
            this.colCTDonGia.HeaderText = "Đơn giá";
            this.colCTDonGia.Name = "colCTDonGia";
            // 
            // colCTTienCong
            // 
            this.colCTTienCong.DataPropertyName = "TienCong";
            this.colCTTienCong.DefaultCellStyle.Format = "N0";
            this.colCTTienCong.FillWeight = 16F;
            this.colCTTienCong.HeaderText = "Tiền công";
            this.colCTTienCong.Name = "colCTTienCong";
            // 
            // colCTThanhTien
            // 
            this.colCTThanhTien.DataPropertyName = "ThanhTien";
            this.colCTThanhTien.DefaultCellStyle.Format = "N0";
            this.colCTThanhTien.FillWeight = 20F;
            this.colCTThanhTien.HeaderText = "Thành tiền";
            this.colCTThanhTien.Name = "colCTThanhTien";
            // 
            // lblChiTietPhieu
            // 
            this.lblChiTietPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiTietPhieu.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietPhieu.Name = "lblChiTietPhieu";
            this.lblChiTietPhieu.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblChiTietPhieu.Size = new System.Drawing.Size(338, 30);
            this.lblChiTietPhieu.TabIndex = 0;
            this.lblChiTietPhieu.Text = "Chi tiết phiếu đang chọn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 277);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(338, 50);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán phiếu";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // grpLapPhieu
            // 
            this.grpLapPhieu.Controls.Add(this.lblBienSoPhieu);
            this.grpLapPhieu.Controls.Add(this.txtBienSoPhieu);
            this.grpLapPhieu.Controls.Add(this.btnTimXePhieu);
            this.grpLapPhieu.Controls.Add(this.lblXePhieu);
            this.grpLapPhieu.Controls.Add(this.lblNoiDungSua);
            this.grpLapPhieu.Controls.Add(this.txtNoiDungSua);
            this.grpLapPhieu.Controls.Add(this.lblChonPhuTung);
            this.grpLapPhieu.Controls.Add(this.cboPhuTung);
            this.grpLapPhieu.Controls.Add(this.lblSoLuongPhieu);
            this.grpLapPhieu.Controls.Add(this.numSoLuongPhieu);
            this.grpLapPhieu.Controls.Add(this.lblTienCong);
            this.grpLapPhieu.Controls.Add(this.numTienCong);
            this.grpLapPhieu.Controls.Add(this.btnThemPhuTungVaoPhieu);
            this.grpLapPhieu.Controls.Add(this.dgvChiTietTam);
            this.grpLapPhieu.Controls.Add(this.btnXoaDongChiTiet);
            this.grpLapPhieu.Controls.Add(this.lblTongTamTinh);
            this.grpLapPhieu.Controls.Add(this.btnHoanTatPhieu);
            this.grpLapPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLapPhieu.Location = new System.Drawing.Point(3, 3);
            this.grpLapPhieu.Name = "grpLapPhieu";
            this.grpLapPhieu.Size = new System.Drawing.Size(1166, 330);
            this.grpLapPhieu.TabIndex = 0;
            this.grpLapPhieu.TabStop = false;
            this.grpLapPhieu.Text = "Lập phiếu sửa chữa (tạo phiếu - thêm chi tiết - trừ kho trong SqlTransaction)";
            // 
            // lblBienSoPhieu
            // 
            this.lblBienSoPhieu.AutoSize = true;
            this.lblBienSoPhieu.Location = new System.Drawing.Point(15, 32);
            this.lblBienSoPhieu.Name = "lblBienSoPhieu";
            this.lblBienSoPhieu.Size = new System.Drawing.Size(55, 19);
            this.lblBienSoPhieu.TabIndex = 0;
            this.lblBienSoPhieu.Text = "Biển số";
            // 
            // txtBienSoPhieu
            // 
            this.txtBienSoPhieu.Location = new System.Drawing.Point(120, 29);
            this.txtBienSoPhieu.Name = "txtBienSoPhieu";
            this.txtBienSoPhieu.Size = new System.Drawing.Size(160, 25);
            this.txtBienSoPhieu.TabIndex = 1;
            // 
            // btnTimXePhieu
            // 
            this.btnTimXePhieu.Location = new System.Drawing.Point(290, 26);
            this.btnTimXePhieu.Name = "btnTimXePhieu";
            this.btnTimXePhieu.Size = new System.Drawing.Size(90, 32);
            this.btnTimXePhieu.TabIndex = 2;
            this.btnTimXePhieu.Text = "Tìm xe";
            this.btnTimXePhieu.UseVisualStyleBackColor = true;
            this.btnTimXePhieu.Click += new System.EventHandler(this.btnTimXePhieu_Click);
            // 
            // lblXePhieu
            // 
            this.lblXePhieu.AutoSize = true;
            this.lblXePhieu.ForeColor = System.Drawing.Color.DimGray;
            this.lblXePhieu.Location = new System.Drawing.Point(395, 32);
            this.lblXePhieu.Name = "lblXePhieu";
            this.lblXePhieu.Size = new System.Drawing.Size(300, 19);
            this.lblXePhieu.TabIndex = 3;
            this.lblXePhieu.Text = "Nhập biển số và bấm Tìm xe.";
            // 
            // lblNoiDungSua
            // 
            this.lblNoiDungSua.AutoSize = true;
            this.lblNoiDungSua.Location = new System.Drawing.Point(15, 72);
            this.lblNoiDungSua.Name = "lblNoiDungSua";
            this.lblNoiDungSua.Size = new System.Drawing.Size(95, 19);
            this.lblNoiDungSua.TabIndex = 4;
            this.lblNoiDungSua.Text = "Nội dung sửa";
            // 
            // txtNoiDungSua
            // 
            this.txtNoiDungSua.Location = new System.Drawing.Point(120, 69);
            this.txtNoiDungSua.Multiline = true;
            this.txtNoiDungSua.Name = "txtNoiDungSua";
            this.txtNoiDungSua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDungSua.Size = new System.Drawing.Size(760, 60);
            this.txtNoiDungSua.TabIndex = 5;
            // 
            // lblChonPhuTung
            // 
            this.lblChonPhuTung.AutoSize = true;
            this.lblChonPhuTung.Location = new System.Drawing.Point(15, 142);
            this.lblChonPhuTung.Name = "lblChonPhuTung";
            this.lblChonPhuTung.Size = new System.Drawing.Size(70, 19);
            this.lblChonPhuTung.TabIndex = 6;
            this.lblChonPhuTung.Text = "Phụ tùng";
            // 
            // cboPhuTung
            // 
            this.cboPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuTung.FormattingEnabled = true;
            this.cboPhuTung.Location = new System.Drawing.Point(120, 139);
            this.cboPhuTung.Name = "cboPhuTung";
            this.cboPhuTung.Size = new System.Drawing.Size(300, 25);
            this.cboPhuTung.TabIndex = 7;
            // 
            // lblSoLuongPhieu
            // 
            this.lblSoLuongPhieu.AutoSize = true;
            this.lblSoLuongPhieu.Location = new System.Drawing.Point(435, 142);
            this.lblSoLuongPhieu.Name = "lblSoLuongPhieu";
            this.lblSoLuongPhieu.Size = new System.Drawing.Size(65, 19);
            this.lblSoLuongPhieu.TabIndex = 8;
            this.lblSoLuongPhieu.Text = "Số lượng";
            // 
            // numSoLuongPhieu
            // 
            this.numSoLuongPhieu.Location = new System.Drawing.Point(510, 139);
            this.numSoLuongPhieu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongPhieu.Name = "numSoLuongPhieu";
            this.numSoLuongPhieu.Size = new System.Drawing.Size(70, 25);
            this.numSoLuongPhieu.TabIndex = 9;
            this.numSoLuongPhieu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTienCong
            // 
            this.lblTienCong.AutoSize = true;
            this.lblTienCong.Location = new System.Drawing.Point(595, 142);
            this.lblTienCong.Name = "lblTienCong";
            this.lblTienCong.Size = new System.Drawing.Size(69, 19);
            this.lblTienCong.TabIndex = 10;
            this.lblTienCong.Text = "Tiền công";
            // 
            // numTienCong
            // 
            this.numTienCong.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numTienCong.Location = new System.Drawing.Point(665, 139);
            this.numTienCong.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numTienCong.Name = "numTienCong";
            this.numTienCong.Size = new System.Drawing.Size(110, 25);
            this.numTienCong.TabIndex = 11;
            this.numTienCong.ThousandsSeparator = true;
            this.numTienCong.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            // 
            // btnThemPhuTungVaoPhieu
            // 
            this.btnThemPhuTungVaoPhieu.Location = new System.Drawing.Point(790, 135);
            this.btnThemPhuTungVaoPhieu.Name = "btnThemPhuTungVaoPhieu";
            this.btnThemPhuTungVaoPhieu.Size = new System.Drawing.Size(140, 32);
            this.btnThemPhuTungVaoPhieu.TabIndex = 12;
            this.btnThemPhuTungVaoPhieu.Text = "Thêm vào phiếu";
            this.btnThemPhuTungVaoPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhuTungVaoPhieu.Click += new System.EventHandler(this.btnThemPhuTungVaoPhieu_Click);
            // 
            // dgvChiTietTam
            // 
            this.dgvChiTietTam.AllowUserToAddRows = false;
            this.dgvChiTietTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTam.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTamTen,
            this.colTamSoLuong,
            this.colTamDonGia,
            this.colTamTienCong,
            this.colTamThanhTien});
            this.dgvChiTietTam.Location = new System.Drawing.Point(120, 175);
            this.dgvChiTietTam.MultiSelect = false;
            this.dgvChiTietTam.Name = "dgvChiTietTam";
            this.dgvChiTietTam.ReadOnly = true;
            this.dgvChiTietTam.RowHeadersVisible = false;
            this.dgvChiTietTam.RowTemplate.Height = 25;
            this.dgvChiTietTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTam.Size = new System.Drawing.Size(810, 100);
            this.dgvChiTietTam.TabIndex = 13;
            // 
            // colTamTen
            // 
            this.colTamTen.DataPropertyName = "TenPhuTung";
            this.colTamTen.FillWeight = 40F;
            this.colTamTen.HeaderText = "Phụ tùng";
            this.colTamTen.Name = "colTamTen";
            // 
            // colTamSoLuong
            // 
            this.colTamSoLuong.DataPropertyName = "SoLuong";
            this.colTamSoLuong.FillWeight = 12F;
            this.colTamSoLuong.HeaderText = "SL";
            this.colTamSoLuong.Name = "colTamSoLuong";
            // 
            // colTamDonGia
            // 
            this.colTamDonGia.DataPropertyName = "DonGia";
            this.colTamDonGia.DefaultCellStyle.Format = "N0";
            this.colTamDonGia.FillWeight = 16F;
            this.colTamDonGia.HeaderText = "Đơn giá";
            this.colTamDonGia.Name = "colTamDonGia";
            // 
            // colTamTienCong
            // 
            this.colTamTienCong.DataPropertyName = "TienCong";
            this.colTamTienCong.DefaultCellStyle.Format = "N0";
            this.colTamTienCong.FillWeight = 16F;
            this.colTamTienCong.HeaderText = "Tiền công";
            this.colTamTienCong.Name = "colTamTienCong";
            // 
            // colTamThanhTien
            // 
            this.colTamThanhTien.DataPropertyName = "ThanhTien";
            this.colTamThanhTien.DefaultCellStyle.Format = "N0";
            this.colTamThanhTien.FillWeight = 16F;
            this.colTamThanhTien.HeaderText = "Thành tiền";
            this.colTamThanhTien.Name = "colTamThanhTien";
            // 
            // btnXoaDongChiTiet
            // 
            this.btnXoaDongChiTiet.Location = new System.Drawing.Point(945, 175);
            this.btnXoaDongChiTiet.Name = "btnXoaDongChiTiet";
            this.btnXoaDongChiTiet.Size = new System.Drawing.Size(110, 32);
            this.btnXoaDongChiTiet.TabIndex = 14;
            this.btnXoaDongChiTiet.Text = "Xóa dòng";
            this.btnXoaDongChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaDongChiTiet.Click += new System.EventHandler(this.btnXoaDongChiTiet_Click);
            // 
            // lblTongTamTinh
            // 
            this.lblTongTamTinh.AutoSize = true;
            this.lblTongTamTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongTamTinh.Location = new System.Drawing.Point(120, 288);
            this.lblTongTamTinh.Name = "lblTongTamTinh";
            this.lblTongTamTinh.Size = new System.Drawing.Size(180, 20);
            this.lblTongTamTinh.TabIndex = 15;
            this.lblTongTamTinh.Text = "Tổng tạm tính: 0 đ";
            // 
            // btnHoanTatPhieu
            // 
            this.btnHoanTatPhieu.Location = new System.Drawing.Point(650, 280);
            this.btnHoanTatPhieu.Name = "btnHoanTatPhieu";
            this.btnHoanTatPhieu.Size = new System.Drawing.Size(200, 36);
            this.btnHoanTatPhieu.TabIndex = 16;
            this.btnHoanTatPhieu.Text = "Hoàn tất phiếu";
            this.btnHoanTatPhieu.UseVisualStyleBackColor = true;
            this.btnHoanTatPhieu.Click += new System.EventHandler(this.btnHoanTatPhieu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 680);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý garage và bảo dưỡng xe ô tô";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTiepNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.grpThemXe.ResumeLayout(false);
            this.grpThemXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoiNamSX)).EndInit();
            this.grpTraCuu.ResumeLayout(false);
            this.grpTraCuu.PerformLayout();
            this.tabXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe2)).EndInit();
            this.grpXeInput.ResumeLayout(false);
            this.grpXeInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamSX)).EndInit();
            this.tabPhuTung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.grpPhuTung.ResumeLayout(false);
            this.grpPhuTung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongTon)).EndInit();
            this.tabPhieu.ResumeLayout(false);
            this.grpDanhSachPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.panelChiTietPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieu)).EndInit();
            this.grpLapPhieu.ResumeLayout(false);
            this.grpLapPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTiepNhan;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeBienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeHieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeNamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXeDiaChi;
        private System.Windows.Forms.GroupBox grpThemXe;
        private System.Windows.Forms.Label lblMoiBienSo;
        private System.Windows.Forms.TextBox txtMoiBienSo;
        private System.Windows.Forms.Label lblMoiTenKH;
        private System.Windows.Forms.TextBox txtMoiTenKH;
        private System.Windows.Forms.Label lblMoiDienThoai;
        private System.Windows.Forms.TextBox txtMoiDienThoai;
        private System.Windows.Forms.Label lblMoiDiaChi;
        private System.Windows.Forms.TextBox txtMoiDiaChi;
        private System.Windows.Forms.Label lblMoiHieuXe;
        private System.Windows.Forms.TextBox txtMoiHieuXe;
        private System.Windows.Forms.Label lblMoiNamSX;
        private System.Windows.Forms.NumericUpDown numMoiNamSX;
        private System.Windows.Forms.Button btnThemXe;
        private System.Windows.Forms.Label lblMoiGhiChu;
        private System.Windows.Forms.GroupBox grpTraCuu;
        private System.Windows.Forms.Label lblTimBienSo;
        private System.Windows.Forms.TextBox txtTimBienSo;
        private System.Windows.Forms.Button btnTimXe;
        private System.Windows.Forms.Label lblKetQuaXe;
        private System.Windows.Forms.TabPage tabXe;
        private System.Windows.Forms.DataGridView dgvXe2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2HieuXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2NamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXe2DiaChi;
        private System.Windows.Forms.GroupBox grpXeInput;
        private System.Windows.Forms.Label lblMaKHXe;
        private System.Windows.Forms.TextBox txtMaKHXe;
        private System.Windows.Forms.Label lblTenKHXe;
        private System.Windows.Forms.TextBox txtTenKHXe;
        private System.Windows.Forms.Label lblDienThoaiXe;
        private System.Windows.Forms.TextBox txtDienThoaiXe;
        private System.Windows.Forms.Label lblDiaChiXe;
        private System.Windows.Forms.TextBox txtDiaChiXe;
        private System.Windows.Forms.Label lblHieuXe;
        private System.Windows.Forms.TextBox txtHieuXe;
        private System.Windows.Forms.Label lblNamSX;
        private System.Windows.Forms.NumericUpDown numNamSX;
        private System.Windows.Forms.Label lblBienSoXe;
        private System.Windows.Forms.TextBox txtBienSoXe;
        private System.Windows.Forms.Label lblGhiChuXe;
        private System.Windows.Forms.Button btnSuaXe;
        private System.Windows.Forms.Button btnXoaXe;
        private System.Windows.Forms.Button btnLamMoiXe;
        private System.Windows.Forms.TabPage tabPhuTung;
        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.GroupBox grpPhuTung;
        private System.Windows.Forms.Label lblMaPhuTung;
        private System.Windows.Forms.Label lblTenPhuTung;
        private System.Windows.Forms.TextBox txtTenPhuTungPT;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.NumericUpDown numSoLuongTon;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Button btnSuaPT;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.Button btnLamMoiPT;
        private System.Windows.Forms.TabPage tabPhieu;
        private System.Windows.Forms.GroupBox grpDanhSachPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBienSoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKHPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDungPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiPhieu;
        private System.Windows.Forms.Panel panelChiTietPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTThanhTien;
        private System.Windows.Forms.Label lblChiTietPhieu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grpLapPhieu;
        private System.Windows.Forms.Label lblBienSoPhieu;
        private System.Windows.Forms.TextBox txtBienSoPhieu;
        private System.Windows.Forms.Button btnTimXePhieu;
        private System.Windows.Forms.Label lblXePhieu;
        private System.Windows.Forms.Label lblNoiDungSua;
        private System.Windows.Forms.TextBox txtNoiDungSua;
        private System.Windows.Forms.Label lblChonPhuTung;
        private System.Windows.Forms.ComboBox cboPhuTung;
        private System.Windows.Forms.Label lblSoLuongPhieu;
        private System.Windows.Forms.NumericUpDown numSoLuongPhieu;
        private System.Windows.Forms.Label lblTienCong;
        private System.Windows.Forms.NumericUpDown numTienCong;
        private System.Windows.Forms.Button btnThemPhuTungVaoPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamTienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamThanhTien;
        private System.Windows.Forms.Button btnXoaDongChiTiet;
        private System.Windows.Forms.Label lblTongTamTinh;
        private System.Windows.Forms.Button btnHoanTatPhieu;
    }
}
