namespace QuanLyKaraoke.GUI
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
            this.tabSoDo = new System.Windows.Forms.TabPage();
            this.tlpSoDo = new System.Windows.Forms.TableLayoutPanel();
            this.grpSoDo = new System.Windows.Forms.GroupBox();
            this.flowPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpPhongChon = new System.Windows.Forms.GroupBox();
            this.lblPhongChon = new System.Windows.Forms.Label();
            this.lblThongTinPhong = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.btnMoPhong = new System.Windows.Forms.Button();
            this.grpGoiDichVu = new System.Windows.Forms.GroupBox();
            this.lblChonDV = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblSoLuongDV = new System.Windows.Forms.Label();
            this.numSoLuongDV = new System.Windows.Forms.NumericUpDown();
            this.lblTonKhoDV = new System.Windows.Forms.Label();
            this.btnGoiDichVu = new System.Windows.Forms.Button();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.tlpChiTiet = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDichVuDaGoi = new System.Windows.Forms.DataGridView();
            this.colDVTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTong = new System.Windows.Forms.Panel();
            this.lblTongDichVu = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.tlpHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.grpHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.tlpChiTietHD = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colCTHDTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTHDSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTHDDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTHDThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaiLaiHoaDon = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabSoDo.SuspendLayout();
            this.tlpSoDo.SuspendLayout();
            this.grpSoDo.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpPhongChon.SuspendLayout();
            this.grpGoiDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDV)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.tlpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaGoi)).BeginInit();
            this.panelTong.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.tlpHoaDon.SuspendLayout();
            this.grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grpChiTietHoaDon.SuspendLayout();
            this.tlpChiTietHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSoDo);
            this.tabMain.Controls.Add(this.tabHoaDon);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1200, 720);
            this.tabMain.TabIndex = 0;
            // 
            // tabSoDo
            // 
            this.tabSoDo.Controls.Add(this.tlpSoDo);
            this.tabSoDo.Location = new System.Drawing.Point(4, 27);
            this.tabSoDo.Name = "tabSoDo";
            this.tabSoDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoDo.Size = new System.Drawing.Size(1192, 689);
            this.tabSoDo.TabIndex = 0;
            this.tabSoDo.Text = "Sơ đồ phòng";
            this.tabSoDo.UseVisualStyleBackColor = true;
            // 
            // tlpSoDo
            // 
            this.tlpSoDo.ColumnCount = 2;
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpSoDo.Controls.Add(this.grpSoDo, 0, 0);
            this.tlpSoDo.Controls.Add(this.tlpRight, 1, 0);
            this.tlpSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSoDo.Location = new System.Drawing.Point(3, 3);
            this.tlpSoDo.Name = "tlpSoDo";
            this.tlpSoDo.RowCount = 1;
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSoDo.Size = new System.Drawing.Size(1186, 683);
            this.tlpSoDo.TabIndex = 0;
            // 
            // grpSoDo
            // 
            this.grpSoDo.Controls.Add(this.flowPhong);
            this.grpSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSoDo.Location = new System.Drawing.Point(3, 3);
            this.grpSoDo.Name = "grpSoDo";
            this.grpSoDo.Size = new System.Drawing.Size(741, 677);
            this.grpSoDo.TabIndex = 0;
            this.grpSoDo.TabStop = false;
            this.grpSoDo.Text = "Sơ đồ phòng (xanh: Trống - đỏ: Đang hát)";
            // 
            // flowPhong
            // 
            this.flowPhong.AutoScroll = true;
            this.flowPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPhong.Location = new System.Drawing.Point(3, 21);
            this.flowPhong.Name = "flowPhong";
            this.flowPhong.Padding = new System.Windows.Forms.Padding(10);
            this.flowPhong.Size = new System.Drawing.Size(735, 653);
            this.flowPhong.TabIndex = 0;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.grpPhongChon, 0, 0);
            this.tlpRight.Controls.Add(this.grpGoiDichVu, 0, 1);
            this.tlpRight.Controls.Add(this.grpChiTiet, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(750, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(433, 677);
            this.tlpRight.TabIndex = 1;
            // 
            // grpPhongChon
            // 
            this.grpPhongChon.Controls.Add(this.lblPhongChon);
            this.grpPhongChon.Controls.Add(this.lblThongTinPhong);
            this.grpPhongChon.Controls.Add(this.lblGioVao);
            this.grpPhongChon.Controls.Add(this.btnMoPhong);
            this.grpPhongChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPhongChon.Location = new System.Drawing.Point(3, 3);
            this.grpPhongChon.Name = "grpPhongChon";
            this.grpPhongChon.Size = new System.Drawing.Size(427, 164);
            this.grpPhongChon.TabIndex = 0;
            this.grpPhongChon.TabStop = false;
            this.grpPhongChon.Text = "Phòng đang chọn";
            // 
            // lblPhongChon
            // 
            this.lblPhongChon.AutoSize = true;
            this.lblPhongChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhongChon.Location = new System.Drawing.Point(12, 25);
            this.lblPhongChon.Name = "lblPhongChon";
            this.lblPhongChon.Size = new System.Drawing.Size(127, 19);
            this.lblPhongChon.TabIndex = 0;
            this.lblPhongChon.Text = "Chưa chọn phòng";
            // 
            // lblThongTinPhong
            // 
            this.lblThongTinPhong.ForeColor = System.Drawing.Color.DimGray;
            this.lblThongTinPhong.Location = new System.Drawing.Point(12, 52);
            this.lblThongTinPhong.Name = "lblThongTinPhong";
            this.lblThongTinPhong.Size = new System.Drawing.Size(400, 42);
            this.lblThongTinPhong.TabIndex = 1;
            this.lblThongTinPhong.Text = "Chọn một phòng trên sơ đồ để xem thông tin.";
            // 
            // lblGioVao
            // 
            this.lblGioVao.ForeColor = System.Drawing.Color.DimGray;
            this.lblGioVao.Location = new System.Drawing.Point(12, 100);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(400, 22);
            this.lblGioVao.TabIndex = 2;
            // 
            // btnMoPhong
            // 
            this.btnMoPhong.Enabled = false;
            this.btnMoPhong.Location = new System.Drawing.Point(12, 126);
            this.btnMoPhong.Name = "btnMoPhong";
            this.btnMoPhong.Size = new System.Drawing.Size(160, 32);
            this.btnMoPhong.TabIndex = 3;
            this.btnMoPhong.Text = "Mở phòng";
            this.btnMoPhong.UseVisualStyleBackColor = true;
            this.btnMoPhong.Click += new System.EventHandler(this.btnMoPhong_Click);
            // 
            // grpGoiDichVu
            // 
            this.grpGoiDichVu.Controls.Add(this.lblChonDV);
            this.grpGoiDichVu.Controls.Add(this.cboDichVu);
            this.grpGoiDichVu.Controls.Add(this.lblSoLuongDV);
            this.grpGoiDichVu.Controls.Add(this.numSoLuongDV);
            this.grpGoiDichVu.Controls.Add(this.lblTonKhoDV);
            this.grpGoiDichVu.Controls.Add(this.btnGoiDichVu);
            this.grpGoiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGoiDichVu.Location = new System.Drawing.Point(3, 173);
            this.grpGoiDichVu.Name = "grpGoiDichVu";
            this.grpGoiDichVu.Size = new System.Drawing.Size(427, 139);
            this.grpGoiDichVu.TabIndex = 1;
            this.grpGoiDichVu.TabStop = false;
            this.grpGoiDichVu.Text = "Gọi dịch vụ";
            // 
            // lblChonDV
            // 
            this.lblChonDV.AutoSize = true;
            this.lblChonDV.Location = new System.Drawing.Point(12, 24);
            this.lblChonDV.Name = "lblChonDV";
            this.lblChonDV.Size = new System.Drawing.Size(59, 19);
            this.lblChonDV.TabIndex = 0;
            this.lblChonDV.Text = "Dịch vụ";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(12, 45);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(390, 25);
            this.cboDichVu.TabIndex = 1;
            this.cboDichVu.SelectedIndexChanged += new System.EventHandler(this.cboDichVu_SelectedIndexChanged);
            // 
            // lblSoLuongDV
            // 
            this.lblSoLuongDV.AutoSize = true;
            this.lblSoLuongDV.Location = new System.Drawing.Point(12, 82);
            this.lblSoLuongDV.Name = "lblSoLuongDV";
            this.lblSoLuongDV.Size = new System.Drawing.Size(65, 19);
            this.lblSoLuongDV.TabIndex = 2;
            this.lblSoLuongDV.Text = "Số lượng";
            // 
            // numSoLuongDV
            // 
            this.numSoLuongDV.Location = new System.Drawing.Point(12, 102);
            this.numSoLuongDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongDV.Name = "numSoLuongDV";
            this.numSoLuongDV.Size = new System.Drawing.Size(70, 25);
            this.numSoLuongDV.TabIndex = 3;
            this.numSoLuongDV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTonKhoDV
            // 
            this.lblTonKhoDV.AutoSize = true;
            this.lblTonKhoDV.ForeColor = System.Drawing.Color.DimGray;
            this.lblTonKhoDV.Location = new System.Drawing.Point(100, 106);
            this.lblTonKhoDV.Name = "lblTonKhoDV";
            this.lblTonKhoDV.Size = new System.Drawing.Size(70, 19);
            this.lblTonKhoDV.TabIndex = 4;
            this.lblTonKhoDV.Text = "Tồn kho: --";
            // 
            // btnGoiDichVu
            // 
            this.btnGoiDichVu.Location = new System.Drawing.Point(250, 98);
            this.btnGoiDichVu.Name = "btnGoiDichVu";
            this.btnGoiDichVu.Size = new System.Drawing.Size(150, 32);
            this.btnGoiDichVu.TabIndex = 5;
            this.btnGoiDichVu.Text = "Gọi dịch vụ";
            this.btnGoiDichVu.UseVisualStyleBackColor = true;
            this.btnGoiDichVu.Click += new System.EventHandler(this.btnGoiDichVu_Click);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.tlpChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Location = new System.Drawing.Point(3, 318);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(427, 356);
            this.grpChiTiet.TabIndex = 2;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Dịch vụ đã gọi của phòng";
            // 
            // tlpChiTiet
            // 
            this.tlpChiTiet.ColumnCount = 1;
            this.tlpChiTiet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChiTiet.Controls.Add(this.dgvDichVuDaGoi, 0, 0);
            this.tlpChiTiet.Controls.Add(this.panelTong, 0, 1);
            this.tlpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChiTiet.Location = new System.Drawing.Point(3, 21);
            this.tlpChiTiet.Name = "tlpChiTiet";
            this.tlpChiTiet.RowCount = 2;
            this.tlpChiTiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChiTiet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpChiTiet.Size = new System.Drawing.Size(421, 332);
            this.tlpChiTiet.TabIndex = 0;
            // 
            // dgvDichVuDaGoi
            // 
            this.dgvDichVuDaGoi.AllowUserToAddRows = false;
            this.dgvDichVuDaGoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVuDaGoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVuDaGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuDaGoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDVTen,
            this.colDVSoLuong,
            this.colDVDonGia,
            this.colDVThanhTien});
            this.dgvDichVuDaGoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVuDaGoi.Location = new System.Drawing.Point(3, 3);
            this.dgvDichVuDaGoi.Name = "dgvDichVuDaGoi";
            this.dgvDichVuDaGoi.ReadOnly = true;
            this.dgvDichVuDaGoi.RowHeadersVisible = false;
            this.dgvDichVuDaGoi.RowTemplate.Height = 25;
            this.dgvDichVuDaGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVuDaGoi.Size = new System.Drawing.Size(415, 201);
            this.dgvDichVuDaGoi.TabIndex = 0;
            // 
            // colDVTen
            // 
            this.colDVTen.DataPropertyName = "TenDV";
            this.colDVTen.FillWeight = 44F;
            this.colDVTen.HeaderText = "Dịch vụ";
            this.colDVTen.Name = "colDVTen";
            // 
            // colDVSoLuong
            // 
            this.colDVSoLuong.DataPropertyName = "SoLuong";
            this.colDVSoLuong.FillWeight = 12F;
            this.colDVSoLuong.HeaderText = "SL";
            this.colDVSoLuong.Name = "colDVSoLuong";
            // 
            // colDVDonGia
            // 
            this.colDVDonGia.DataPropertyName = "DonGia";
            this.colDVDonGia.DefaultCellStyle.Format = "N0";
            this.colDVDonGia.FillWeight = 20F;
            this.colDVDonGia.HeaderText = "Đơn giá";
            this.colDVDonGia.Name = "colDVDonGia";
            // 
            // colDVThanhTien
            // 
            this.colDVThanhTien.DataPropertyName = "ThanhTien";
            this.colDVThanhTien.DefaultCellStyle.Format = "N0";
            this.colDVThanhTien.FillWeight = 24F;
            this.colDVThanhTien.HeaderText = "Thành tiền";
            this.colDVThanhTien.Name = "colDVThanhTien";
            // 
            // panelTong
            // 
            this.panelTong.Controls.Add(this.lblTongDichVu);
            this.panelTong.Controls.Add(this.lblTienPhong);
            this.panelTong.Controls.Add(this.lblTongCong);
            this.panelTong.Controls.Add(this.btnThanhToan);
            this.panelTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTong.Location = new System.Drawing.Point(3, 210);
            this.panelTong.Name = "panelTong";
            this.panelTong.Size = new System.Drawing.Size(415, 119);
            this.panelTong.TabIndex = 1;
            // 
            // lblTongDichVu
            // 
            this.lblTongDichVu.AutoSize = true;
            this.lblTongDichVu.Location = new System.Drawing.Point(10, 8);
            this.lblTongDichVu.Name = "lblTongDichVu";
            this.lblTongDichVu.Size = new System.Drawing.Size(137, 19);
            this.lblTongDichVu.TabIndex = 0;
            this.lblTongDichVu.Text = "Tiền dịch vụ: 0 đ";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(10, 32);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(133, 19);
            this.lblTienPhong.TabIndex = 1;
            this.lblTienPhong.Text = "Tiền phòng: 0 đ";
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongCong.Location = new System.Drawing.Point(10, 58);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(145, 19);
            this.lblTongCong.TabIndex = 2;
            this.lblTongCong.Text = "Tổng cộng: 0 đ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new System.Drawing.Point(240, 55);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(160, 45);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán && trả phòng";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.tlpHoaDon);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 27);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1192, 689);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "Hóa đơn";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // tlpHoaDon
            // 
            this.tlpHoaDon.ColumnCount = 2;
            this.tlpHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpHoaDon.Controls.Add(this.grpHoaDon, 0, 0);
            this.tlpHoaDon.Controls.Add(this.grpChiTietHoaDon, 1, 0);
            this.tlpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHoaDon.Location = new System.Drawing.Point(3, 3);
            this.tlpHoaDon.Name = "tlpHoaDon";
            this.tlpHoaDon.RowCount = 1;
            this.tlpHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHoaDon.Size = new System.Drawing.Size(1186, 683);
            this.tlpHoaDon.TabIndex = 0;
            // 
            // grpHoaDon
            // 
            this.grpHoaDon.Controls.Add(this.dgvHoaDon);
            this.grpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHoaDon.Location = new System.Drawing.Point(3, 3);
            this.grpHoaDon.Name = "grpHoaDon";
            this.grpHoaDon.Size = new System.Drawing.Size(741, 677);
            this.grpHoaDon.TabIndex = 0;
            this.grpHoaDon.TabStop = false;
            this.grpHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenPhong,
            this.colGioVao,
            this.colGioRa,
            this.colTienPhong,
            this.colTienDichVu,
            this.colTongCong,
            this.colTrangThai});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 21);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 25;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(735, 653);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.FillWeight = 7F;
            this.colMaHD.HeaderText = "Mã";
            this.colMaHD.Name = "colMaHD";
            // 
            // colTenPhong
            // 
            this.colTenPhong.DataPropertyName = "TenPhong";
            this.colTenPhong.FillWeight = 16F;
            this.colTenPhong.HeaderText = "Phòng";
            this.colTenPhong.Name = "colTenPhong";
            // 
            // colGioVao
            // 
            this.colGioVao.DataPropertyName = "GioVao";
            this.colGioVao.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colGioVao.FillWeight = 17F;
            this.colGioVao.HeaderText = "Giờ vào";
            this.colGioVao.Name = "colGioVao";
            // 
            // colGioRa
            // 
            this.colGioRa.DataPropertyName = "GioRa";
            this.colGioRa.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colGioRa.FillWeight = 17F;
            this.colGioRa.HeaderText = "Giờ ra";
            this.colGioRa.Name = "colGioRa";
            // 
            // colTienPhong
            // 
            this.colTienPhong.DataPropertyName = "TongTienPhong";
            this.colTienPhong.DefaultCellStyle.Format = "N0";
            this.colTienPhong.FillWeight = 12F;
            this.colTienPhong.HeaderText = "Tiền phòng";
            this.colTienPhong.Name = "colTienPhong";
            // 
            // colTienDichVu
            // 
            this.colTienDichVu.DataPropertyName = "TongTienDichVu";
            this.colTienDichVu.DefaultCellStyle.Format = "N0";
            this.colTienDichVu.FillWeight = 12F;
            this.colTienDichVu.HeaderText = "Tiền dịch vụ";
            this.colTienDichVu.Name = "colTienDichVu";
            // 
            // colTongCong
            // 
            this.colTongCong.DataPropertyName = "TongCong";
            this.colTongCong.DefaultCellStyle.Format = "N0";
            this.colTongCong.FillWeight = 12F;
            this.colTongCong.HeaderText = "Tổng cộng";
            this.colTongCong.Name = "colTongCong";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThaiText";
            this.colTrangThai.FillWeight = 16F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // grpChiTietHoaDon
            // 
            this.grpChiTietHoaDon.Controls.Add(this.tlpChiTietHD);
            this.grpChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTietHoaDon.Location = new System.Drawing.Point(750, 3);
            this.grpChiTietHoaDon.Name = "grpChiTietHoaDon";
            this.grpChiTietHoaDon.Size = new System.Drawing.Size(433, 677);
            this.grpChiTietHoaDon.TabIndex = 1;
            this.grpChiTietHoaDon.TabStop = false;
            this.grpChiTietHoaDon.Text = "Chi tiết dịch vụ của hóa đơn";
            // 
            // tlpChiTietHD
            // 
            this.tlpChiTietHD.ColumnCount = 1;
            this.tlpChiTietHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChiTietHD.Controls.Add(this.dgvChiTietHoaDon, 0, 0);
            this.tlpChiTietHD.Controls.Add(this.btnTaiLaiHoaDon, 0, 1);
            this.tlpChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChiTietHD.Location = new System.Drawing.Point(3, 21);
            this.tlpChiTietHD.Name = "tlpChiTietHD";
            this.tlpChiTietHD.RowCount = 2;
            this.tlpChiTietHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChiTietHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpChiTietHD.Size = new System.Drawing.Size(427, 653);
            this.tlpChiTietHD.TabIndex = 0;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCTHDTen,
            this.colCTHDSoLuong,
            this.colCTHDDonGia,
            this.colCTHDThanhTien});
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowTemplate.Height = 25;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(421, 597);
            this.dgvChiTietHoaDon.TabIndex = 0;
            // 
            // colCTHDTen
            // 
            this.colCTHDTen.DataPropertyName = "TenDV";
            this.colCTHDTen.FillWeight = 40F;
            this.colCTHDTen.HeaderText = "Dịch vụ";
            this.colCTHDTen.Name = "colCTHDTen";
            // 
            // colCTHDSoLuong
            // 
            this.colCTHDSoLuong.DataPropertyName = "SoLuong";
            this.colCTHDSoLuong.FillWeight = 14F;
            this.colCTHDSoLuong.HeaderText = "SL";
            this.colCTHDSoLuong.Name = "colCTHDSoLuong";
            // 
            // colCTHDDonGia
            // 
            this.colCTHDDonGia.DataPropertyName = "DonGia";
            this.colCTHDDonGia.DefaultCellStyle.Format = "N0";
            this.colCTHDDonGia.FillWeight = 20F;
            this.colCTHDDonGia.HeaderText = "Đơn giá";
            this.colCTHDDonGia.Name = "colCTHDDonGia";
            // 
            // colCTHDThanhTien
            // 
            this.colCTHDThanhTien.DataPropertyName = "ThanhTien";
            this.colCTHDThanhTien.DefaultCellStyle.Format = "N0";
            this.colCTHDThanhTien.FillWeight = 26F;
            this.colCTHDThanhTien.HeaderText = "Thành tiền";
            this.colCTHDThanhTien.Name = "colCTHDThanhTien";
            // 
            // btnTaiLaiHoaDon
            // 
            this.btnTaiLaiHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaiLaiHoaDon.Location = new System.Drawing.Point(3, 606);
            this.btnTaiLaiHoaDon.Name = "btnTaiLaiHoaDon";
            this.btnTaiLaiHoaDon.Size = new System.Drawing.Size(421, 44);
            this.btnTaiLaiHoaDon.TabIndex = 1;
            this.btnTaiLaiHoaDon.Text = "Tải lại danh sách hóa đơn";
            this.btnTaiLaiHoaDon.UseVisualStyleBackColor = true;
            this.btnTaiLaiHoaDon.Click += new System.EventHandler(this.btnTaiLaiHoaDon_Click);
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
            this.Text = "Hệ thống quản lý phòng hát Karaoke";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabSoDo.ResumeLayout(false);
            this.tlpSoDo.ResumeLayout(false);
            this.grpSoDo.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.grpPhongChon.ResumeLayout(false);
            this.grpPhongChon.PerformLayout();
            this.grpGoiDichVu.ResumeLayout(false);
            this.grpGoiDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDV)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.tlpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuDaGoi)).EndInit();
            this.panelTong.ResumeLayout(false);
            this.panelTong.PerformLayout();
            this.tabHoaDon.ResumeLayout(false);
            this.tlpHoaDon.ResumeLayout(false);
            this.grpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grpChiTietHoaDon.ResumeLayout(false);
            this.tlpChiTietHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSoDo;
        private System.Windows.Forms.TableLayoutPanel tlpSoDo;
        private System.Windows.Forms.GroupBox grpSoDo;
        private System.Windows.Forms.FlowLayoutPanel flowPhong;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.GroupBox grpPhongChon;
        private System.Windows.Forms.Label lblPhongChon;
        private System.Windows.Forms.Label lblThongTinPhong;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Button btnMoPhong;
        private System.Windows.Forms.GroupBox grpGoiDichVu;
        private System.Windows.Forms.Label lblChonDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblSoLuongDV;
        private System.Windows.Forms.NumericUpDown numSoLuongDV;
        private System.Windows.Forms.Label lblTonKhoDV;
        private System.Windows.Forms.Button btnGoiDichVu;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.TableLayoutPanel tlpChiTiet;
        private System.Windows.Forms.DataGridView dgvDichVuDaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVThanhTien;
        private System.Windows.Forms.Panel panelTong;
        private System.Windows.Forms.Label lblTongDichVu;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.TableLayoutPanel tlpHoaDon;
        private System.Windows.Forms.GroupBox grpHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox grpChiTietHoaDon;
        private System.Windows.Forms.TableLayoutPanel tlpChiTietHD;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTHDTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTHDSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTHDDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTHDThanhTien;
        private System.Windows.Forms.Button btnTaiLaiHoaDon;
    }
}
