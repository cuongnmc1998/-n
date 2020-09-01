namespace QLCuaHangThucAnNhanh
{
    partial class frmDatMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMonAn = new System.Windows.Forms.TabControl();
            this.tabTimKiem = new System.Windows.Forms.TabPage();
            this.lsvTimKiem = new System.Windows.Forms.ListView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.lblDanhSachMon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTHDThanhToan = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboTTMonAn = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSubGhiChu = new System.Windows.Forms.Label();
            this.lblSubSoLuong = new System.Windows.Forms.Label();
            this.lblSubDonGia = new System.Windows.Forms.Label();
            this.lblSubTenMon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCTHDThanhToan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.imlMonAn = new System.Windows.Forms.ImageList(this.components);
            this.lblSubTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMonAn.SuspendLayout();
            this.tabTimKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDThanhToan)).BeginInit();
            this.gboTTMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1MinSize = 702;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 474;
            this.splitContainer1.Size = new System.Drawing.Size(1190, 579);
            this.splitContainer1.SplitterDistance = 708;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabMonAn);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.btnTaoHD);
            this.panel2.Controls.Add(this.lblSubTimKiem);
            this.panel2.Controls.Add(this.lblDanhSachMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 579);
            this.panel2.TabIndex = 0;
            // 
            // tabMonAn
            // 
            this.tabMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMonAn.Controls.Add(this.tabTimKiem);
            this.tabMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonAn.Location = new System.Drawing.Point(7, 125);
            this.tabMonAn.Name = "tabMonAn";
            this.tabMonAn.SelectedIndex = 0;
            this.tabMonAn.Size = new System.Drawing.Size(688, 442);
            this.tabMonAn.TabIndex = 48;
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.lsvTimKiem);
            this.tabTimKiem.Location = new System.Drawing.Point(4, 27);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.Size = new System.Drawing.Size(680, 411);
            this.tabTimKiem.TabIndex = 0;
            this.tabTimKiem.Text = "Kết quả tìm kiếm";
            this.tabTimKiem.UseVisualStyleBackColor = true;
            // 
            // lsvTimKiem
            // 
            this.lsvTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvTimKiem.Location = new System.Drawing.Point(4, 4);
            this.lsvTimKiem.Name = "lsvTimKiem";
            this.lsvTimKiem.Size = new System.Drawing.Size(673, 404);
            this.lsvTimKiem.TabIndex = 0;
            this.lsvTimKiem.UseCompatibleStateImageBehavior = false;
            this.lsvTimKiem.SelectedIndexChanged += new System.EventHandler(this.lsvTimKiem_SelectedIndexChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(16, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 47);
            this.btnQuayLai.TabIndex = 17;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(556, 8);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(139, 47);
            this.btnTaoHD.TabIndex = 17;
            this.btnTaoHD.Text = "TẠO HÓA ĐƠN";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // lblDanhSachMon
            // 
            this.lblDanhSachMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDanhSachMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachMon.Location = new System.Drawing.Point(7, 62);
            this.lblDanhSachMon.Name = "lblDanhSachMon";
            this.lblDanhSachMon.Size = new System.Drawing.Size(688, 22);
            this.lblDanhSachMon.TabIndex = 42;
            this.lblDanhSachMon.Text = "DANH SÁCH MÓN ĂN";
            this.lblDanhSachMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTHDThanhToan);
            this.panel1.Controls.Add(this.gboTTMonAn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCTHDThanhToan);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 579);
            this.panel1.TabIndex = 0;
            // 
            // dgvCTHDThanhToan
            // 
            this.dgvCTHDThanhToan.AllowUserToAddRows = false;
            this.dgvCTHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTHDThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaMon,
            this.colDonGia,
            this.colSoLuong,
            this.colGhiChu});
            this.dgvCTHDThanhToan.Location = new System.Drawing.Point(7, 305);
            this.dgvCTHDThanhToan.MultiSelect = false;
            this.dgvCTHDThanhToan.Name = "dgvCTHDThanhToan";
            this.dgvCTHDThanhToan.ReadOnly = true;
            this.dgvCTHDThanhToan.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvCTHDThanhToan.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHDThanhToan.RowTemplate.Height = 30;
            this.dgvCTHDThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDThanhToan.Size = new System.Drawing.Size(462, 209);
            this.dgvCTHDThanhToan.TabIndex = 50;
            this.dgvCTHDThanhToan.SelectionChanged += new System.EventHandler(this.dgvCTHDThanhToan_SelectionChanged);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaMon.HeaderText = "Tên Món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            this.colMaMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaMon.Width = 200;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0 VND";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 200;
            // 
            // gboTTMonAn
            // 
            this.gboTTMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboTTMonAn.Controls.Add(this.btnCapNhat);
            this.gboTTMonAn.Controls.Add(this.btnXoa);
            this.gboTTMonAn.Controls.Add(this.btnThem);
            this.gboTTMonAn.Controls.Add(this.rtbGhiChu);
            this.gboTTMonAn.Controls.Add(this.lblDonGia);
            this.gboTTMonAn.Controls.Add(this.lblTenMon);
            this.gboTTMonAn.Controls.Add(this.txtSoLuong);
            this.gboTTMonAn.Controls.Add(this.lblSubGhiChu);
            this.gboTTMonAn.Controls.Add(this.lblSubSoLuong);
            this.gboTTMonAn.Controls.Add(this.lblSubDonGia);
            this.gboTTMonAn.Controls.Add(this.lblSubTenMon);
            this.gboTTMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTTMonAn.Location = new System.Drawing.Point(7, 31);
            this.gboTTMonAn.Name = "gboTTMonAn";
            this.gboTTMonAn.Size = new System.Drawing.Size(462, 246);
            this.gboTTMonAn.TabIndex = 34;
            this.gboTTMonAn.TabStop = false;
            this.gboTTMonAn.Text = "THÔNG TIN MÓN ĂN";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(178, 206);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(348, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(9, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGhiChu.Location = new System.Drawing.Point(89, 129);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(367, 54);
            this.rtbGhiChu.TabIndex = 13;
            this.rtbGhiChu.Text = "";
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(86, 64);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(229, 18);
            this.lblDonGia.TabIndex = 11;
            this.lblDonGia.Text = "35.000 VND";
            // 
            // lblTenMon
            // 
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(87, 34);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(228, 27);
            this.lblTenMon.TabIndex = 10;
            this.lblTenMon.Text = "Gà giòn không cay (1 Miếng)";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(89, 94);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(79, 24);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSubGhiChu
            // 
            this.lblSubGhiChu.AutoSize = true;
            this.lblSubGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGhiChu.Location = new System.Drawing.Point(6, 129);
            this.lblSubGhiChu.Name = "lblSubGhiChu";
            this.lblSubGhiChu.Size = new System.Drawing.Size(71, 18);
            this.lblSubGhiChu.TabIndex = 3;
            this.lblSubGhiChu.Text = "Ghi chú:";
            // 
            // lblSubSoLuong
            // 
            this.lblSubSoLuong.AutoSize = true;
            this.lblSubSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSoLuong.Location = new System.Drawing.Point(6, 94);
            this.lblSubSoLuong.Name = "lblSubSoLuong";
            this.lblSubSoLuong.Size = new System.Drawing.Size(80, 18);
            this.lblSubSoLuong.TabIndex = 2;
            this.lblSubSoLuong.Text = "Số lượng:";
            // 
            // lblSubDonGia
            // 
            this.lblSubDonGia.AutoSize = true;
            this.lblSubDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDonGia.Location = new System.Drawing.Point(8, 64);
            this.lblSubDonGia.Name = "lblSubDonGia";
            this.lblSubDonGia.Size = new System.Drawing.Size(71, 18);
            this.lblSubDonGia.TabIndex = 1;
            this.lblSubDonGia.Text = "Đơn giá:";
            // 
            // lblSubTenMon
            // 
            this.lblSubTenMon.AutoSize = true;
            this.lblSubTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTenMon.Location = new System.Drawing.Point(8, 34);
            this.lblSubTenMon.Name = "lblSubTenMon";
            this.lblSubTenMon.Size = new System.Drawing.Size(79, 18);
            this.lblSubTenMon.TabIndex = 0;
            this.lblSubTenMon.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "DANH SÁCH CTHD BÁN HÀNG\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCTHDThanhToan
            // 
            this.lblCTHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCTHDThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTHDThanhToan.Location = new System.Drawing.Point(3, 6);
            this.lblCTHDThanhToan.Name = "lblCTHDThanhToan";
            this.lblCTHDThanhToan.Size = new System.Drawing.Size(466, 22);
            this.lblCTHDThanhToan.TabIndex = 33;
            this.lblCTHDThanhToan.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            this.lblCTHDThanhToan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(330, 520);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(139, 47);
            this.btnThanhToan.TabIndex = 46;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(7, 520);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(139, 47);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // imlMonAn
            // 
            this.imlMonAn.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlMonAn.ImageSize = new System.Drawing.Size(64, 64);
            this.imlMonAn.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblSubTimKiem
            // 
            this.lblSubTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTimKiem.AutoSize = true;
            this.lblSubTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTimKiem.Location = new System.Drawing.Point(406, 92);
            this.lblSubTimKiem.Name = "lblSubTimKiem";
            this.lblSubTimKiem.Size = new System.Drawing.Size(84, 18);
            this.lblSubTimKiem.TabIndex = 44;
            this.lblSubTimKiem.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(491, 89);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // frmDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatMon";
            this.Text = "Đặt Món";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatMon_FormClosed);
            this.Load += new System.EventHandler(this.frmDatMon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMonAn.ResumeLayout(false);
            this.tabTimKiem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDThanhToan)).EndInit();
            this.gboTTMonAn.ResumeLayout(false);
            this.gboTTMonAn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboTTMonAn;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSubGhiChu;
        private System.Windows.Forms.Label lblSubSoLuong;
        private System.Windows.Forms.Label lblSubDonGia;
        private System.Windows.Forms.Label lblSubTenMon;
        private System.Windows.Forms.Label lblCTHDThanhToan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDanhSachMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ImageList imlMonAn;
        private System.Windows.Forms.TabControl tabMonAn;
        private System.Windows.Forms.DataGridView dgvCTHDThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.TabPage tabTimKiem;
        private System.Windows.Forms.ListView lsvTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSubTimKiem;
    }
}