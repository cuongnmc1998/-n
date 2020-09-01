namespace QLCuaHangThucAnNhanh
{
    partial class frmNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkNLConSuDung = new MetroFramework.Controls.MetroCheckBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtTimKiemNL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDSNguyenLieu = new System.Windows.Forms.DataGridView();
            this.colMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCungCap = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLoaiNL = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSubDSNguyenLieu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboDonViTinh = new MetroFramework.Controls.MetroComboBox();
            this.btnAddNCC = new System.Windows.Forms.Button();
            this.btnAddLoaiNL = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.lblSubMaLoaiNL = new System.Windows.Forms.Label();
            this.lblSubNhaCungCap = new System.Windows.Forms.Label();
            this.cboLoaiNL = new MetroFramework.Controls.MetroComboBox();
            this.txtSLTonKho = new System.Windows.Forms.TextBox();
            this.cboNhaCC = new MetroFramework.Controls.MetroComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.lblSubTrangThai = new System.Windows.Forms.Label();
            this.lblSubSLTK = new System.Windows.Forms.Label();
            this.lblSubDonGia = new System.Windows.Forms.Label();
            this.lblSubDonViTinh = new System.Windows.Forms.Label();
            this.lblSubTenNL = new System.Windows.Forms.Label();
            this.lblSubMaNL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguyenLieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1MinSize = 734;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 452;
            this.splitContainer1.Size = new System.Drawing.Size(1190, 579);
            this.splitContainer1.SplitterDistance = 734;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkNLConSuDung);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.txtTimKiemNL);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvDSNguyenLieu);
            this.panel2.Controls.Add(this.lblSubDSNguyenLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 579);
            this.panel2.TabIndex = 2;
            // 
            // chkNLConSuDung
            // 
            this.chkNLConSuDung.AutoSize = true;
            this.chkNLConSuDung.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkNLConSuDung.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkNLConSuDung.Location = new System.Drawing.Point(12, 90);
            this.chkNLConSuDung.Name = "chkNLConSuDung";
            this.chkNLConSuDung.Size = new System.Drawing.Size(304, 19);
            this.chkNLConSuDung.TabIndex = 64;
            this.chkNLConSuDung.Text = "Danh sách nguyên liệu không còn sử dụng";
            this.chkNLConSuDung.UseSelectable = true;
            this.chkNLConSuDung.CheckedChanged += new System.EventHandler(this.chkNLConSuDung_CheckedChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(141, 45);
            this.btnQuayLai.TabIndex = 59;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtTimKiemNL
            // 
            this.txtTimKiemNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNL.Location = new System.Drawing.Point(517, 90);
            this.txtTimKiemNL.Name = "txtTimKiemNL";
            this.txtTimKiemNL.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemNL.TabIndex = 62;
            this.txtTimKiemNL.TextChanged += new System.EventHandler(this.txtTimKiemNL_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Tìm Kiếm:";
            // 
            // dgvDSNguyenLieu
            // 
            this.dgvDSNguyenLieu.AllowUserToAddRows = false;
            this.dgvDSNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNguyenLieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNL,
            this.colTenNL,
            this.colDonViTinh,
            this.colSLTK,
            this.colDonGia,
            this.colNhaCungCap,
            this.colLoaiNL,
            this.colTrangThai});
            this.dgvDSNguyenLieu.Location = new System.Drawing.Point(13, 130);
            this.dgvDSNguyenLieu.Name = "dgvDSNguyenLieu";
            this.dgvDSNguyenLieu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNguyenLieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSNguyenLieu.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDSNguyenLieu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSNguyenLieu.RowTemplate.Height = 30;
            this.dgvDSNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNguyenLieu.Size = new System.Drawing.Size(709, 435);
            this.dgvDSNguyenLieu.TabIndex = 17;
            this.dgvDSNguyenLieu.SelectionChanged += new System.EventHandler(this.dgvDSNguyenLieu_SelectionChanged);
            // 
            // colMaNL
            // 
            this.colMaNL.DataPropertyName = "MaNL";
            this.colMaNL.HeaderText = "Mã Nguyên Liệu";
            this.colMaNL.Name = "colMaNL";
            this.colMaNL.ReadOnly = true;
            this.colMaNL.Width = 130;
            // 
            // colTenNL
            // 
            this.colTenNL.DataPropertyName = "TenNL";
            this.colTenNL.HeaderText = "Tên Nguyên Liệu";
            this.colTenNL.Name = "colTenNL";
            this.colTenNL.ReadOnly = true;
            this.colTenNL.Width = 150;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "DonViTinh";
            this.colDonViTinh.HeaderText = "Đơn Vị Tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            // 
            // colSLTK
            // 
            this.colSLTK.DataPropertyName = "SoLuongTonKho";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSLTK.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSLTK.HeaderText = "Số Lượng Tồn Kho";
            this.colSLTK.Name = "colSLTK";
            this.colSLTK.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0 VND";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 130;
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.DataPropertyName = "MaNCC";
            this.colNhaCungCap.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.ReadOnly = true;
            this.colNhaCungCap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNhaCungCap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNhaCungCap.Width = 170;
            // 
            // colLoaiNL
            // 
            this.colLoaiNL.DataPropertyName = "MaLoaiNL";
            this.colLoaiNL.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLoaiNL.HeaderText = "Loại Nguyên Liệu";
            this.colLoaiNL.Name = "colLoaiNL";
            this.colLoaiNL.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Còn Sử Dụng";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // lblSubDSNguyenLieu
            // 
            this.lblSubDSNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSNguyenLieu.Location = new System.Drawing.Point(12, 62);
            this.lblSubDSNguyenLieu.Name = "lblSubDSNguyenLieu";
            this.lblSubDSNguyenLieu.Size = new System.Drawing.Size(709, 24);
            this.lblSubDSNguyenLieu.TabIndex = 16;
            this.lblSubDSNguyenLieu.Text = "DANH SÁCH NGUYÊN LIỆU";
            this.lblSubDSNguyenLieu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 579);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cboDonViTinh);
            this.groupBox1.Controls.Add(this.btnAddNCC);
            this.groupBox1.Controls.Add(this.btnAddLoaiNL);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.lblSubMaLoaiNL);
            this.groupBox1.Controls.Add(this.lblSubNhaCungCap);
            this.groupBox1.Controls.Add(this.cboLoaiNL);
            this.groupBox1.Controls.Add(this.txtSLTonKho);
            this.groupBox1.Controls.Add(this.cboNhaCC);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenNL);
            this.groupBox1.Controls.Add(this.txtMaNL);
            this.groupBox1.Controls.Add(this.lblSubTrangThai);
            this.groupBox1.Controls.Add(this.lblSubSLTK);
            this.groupBox1.Controls.Add(this.lblSubDonGia);
            this.groupBox1.Controls.Add(this.lblSubDonViTinh);
            this.groupBox1.Controls.Add(this.lblSubTenNL);
            this.groupBox1.Controls.Add(this.lblSubMaNL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 494);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NGUYÊN LIỆU";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(171, 389);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 34);
            this.btnLamMoi.TabIndex = 72;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.ItemHeight = 23;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "kg",
            "gram",
            "quả"});
            this.cboDonViTinh.Location = new System.Drawing.Point(146, 113);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(294, 29);
            this.cboDonViTinh.TabIndex = 71;
            this.cboDonViTinh.UseSelectable = true;
            // 
            // btnAddNCC
            // 
            this.btnAddNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNCC.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.add;
            this.btnAddNCC.Location = new System.Drawing.Point(408, 266);
            this.btnAddNCC.Name = "btnAddNCC";
            this.btnAddNCC.Size = new System.Drawing.Size(32, 32);
            this.btnAddNCC.TabIndex = 70;
            this.btnAddNCC.UseVisualStyleBackColor = true;
            this.btnAddNCC.Click += new System.EventHandler(this.btnAddNCC_Click);
            // 
            // btnAddLoaiNL
            // 
            this.btnAddLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoaiNL.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.add;
            this.btnAddLoaiNL.Location = new System.Drawing.Point(407, 227);
            this.btnAddLoaiNL.Name = "btnAddLoaiNL";
            this.btnAddLoaiNL.Size = new System.Drawing.Size(32, 32);
            this.btnAddLoaiNL.TabIndex = 69;
            this.btnAddLoaiNL.UseVisualStyleBackColor = true;
            this.btnAddLoaiNL.Click += new System.EventHandler(this.btnAddLoaiNL_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(6, 389);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
            this.btnCapNhat.TabIndex = 68;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(332, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(171, 389);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(108, 34);
            this.btnKhoiPhuc.TabIndex = 66;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.Location = new System.Drawing.Point(146, 314);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(107, 19);
            this.chkTrangThai.TabIndex = 54;
            this.chkTrangThai.Text = "Còn Sử Dụng";
            this.chkTrangThai.UseSelectable = true;
            // 
            // lblSubMaLoaiNL
            // 
            this.lblSubMaLoaiNL.AutoSize = true;
            this.lblSubMaLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaLoaiNL.Location = new System.Drawing.Point(6, 234);
            this.lblSubMaLoaiNL.Name = "lblSubMaLoaiNL";
            this.lblSubMaLoaiNL.Size = new System.Drawing.Size(71, 18);
            this.lblSubMaLoaiNL.TabIndex = 1;
            this.lblSubMaLoaiNL.Text = "Loại NL:";
            // 
            // lblSubNhaCungCap
            // 
            this.lblSubNhaCungCap.AutoSize = true;
            this.lblSubNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNhaCungCap.Location = new System.Drawing.Point(6, 273);
            this.lblSubNhaCungCap.Name = "lblSubNhaCungCap";
            this.lblSubNhaCungCap.Size = new System.Drawing.Size(116, 18);
            this.lblSubNhaCungCap.TabIndex = 0;
            this.lblSubNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // cboLoaiNL
            // 
            this.cboLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiNL.FormattingEnabled = true;
            this.cboLoaiNL.ItemHeight = 23;
            this.cboLoaiNL.Location = new System.Drawing.Point(146, 230);
            this.cboLoaiNL.Name = "cboLoaiNL";
            this.cboLoaiNL.Size = new System.Drawing.Size(255, 29);
            this.cboLoaiNL.TabIndex = 46;
            this.cboLoaiNL.UseSelectable = true;
            // 
            // txtSLTonKho
            // 
            this.txtSLTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSLTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTonKho.Location = new System.Drawing.Point(146, 193);
            this.txtSLTonKho.Name = "txtSLTonKho";
            this.txtSLTonKho.Size = new System.Drawing.Size(294, 24);
            this.txtSLTonKho.TabIndex = 11;
            this.txtSLTonKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLTonKho_KeyPress);
            // 
            // cboNhaCC
            // 
            this.cboNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhaCC.FormattingEnabled = true;
            this.cboNhaCC.ItemHeight = 23;
            this.cboNhaCC.Location = new System.Drawing.Point(145, 269);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Size = new System.Drawing.Size(255, 29);
            this.cboNhaCC.TabIndex = 48;
            this.cboNhaCC.UseSelectable = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(146, 152);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(294, 24);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtTenNL
            // 
            this.txtTenNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(145, 74);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(294, 24);
            this.txtTenNL.TabIndex = 8;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.Location = new System.Drawing.Point(145, 35);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(294, 24);
            this.txtMaNL.TabIndex = 7;
            // 
            // lblSubTrangThai
            // 
            this.lblSubTrangThai.AutoSize = true;
            this.lblSubTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTrangThai.Location = new System.Drawing.Point(6, 315);
            this.lblSubTrangThai.Name = "lblSubTrangThai";
            this.lblSubTrangThai.Size = new System.Drawing.Size(88, 18);
            this.lblSubTrangThai.TabIndex = 6;
            this.lblSubTrangThai.Text = "Trạng thái:";
            // 
            // lblSubSLTK
            // 
            this.lblSubSLTK.AutoSize = true;
            this.lblSubSLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSLTK.Location = new System.Drawing.Point(6, 193);
            this.lblSubSLTK.Name = "lblSubSLTK";
            this.lblSubSLTK.Size = new System.Drawing.Size(95, 18);
            this.lblSubSLTK.TabIndex = 5;
            this.lblSubSLTK.Text = "SL tồn kho:";
            // 
            // lblSubDonGia
            // 
            this.lblSubDonGia.AutoSize = true;
            this.lblSubDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDonGia.Location = new System.Drawing.Point(6, 152);
            this.lblSubDonGia.Name = "lblSubDonGia";
            this.lblSubDonGia.Size = new System.Drawing.Size(71, 18);
            this.lblSubDonGia.TabIndex = 4;
            this.lblSubDonGia.Text = "Đơn giá:";
            // 
            // lblSubDonViTinh
            // 
            this.lblSubDonViTinh.AutoSize = true;
            this.lblSubDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDonViTinh.Location = new System.Drawing.Point(6, 113);
            this.lblSubDonViTinh.Name = "lblSubDonViTinh";
            this.lblSubDonViTinh.Size = new System.Drawing.Size(93, 18);
            this.lblSubDonViTinh.TabIndex = 3;
            this.lblSubDonViTinh.Text = "Đơn vị tính:";
            // 
            // lblSubTenNL
            // 
            this.lblSubTenNL.AutoSize = true;
            this.lblSubTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTenNL.Location = new System.Drawing.Point(6, 77);
            this.lblSubTenNL.Name = "lblSubTenNL";
            this.lblSubTenNL.Size = new System.Drawing.Size(67, 18);
            this.lblSubTenNL.TabIndex = 2;
            this.lblSubTenNL.Text = "Tên NL:";
            // 
            // lblSubMaNL
            // 
            this.lblSubMaNL.AutoSize = true;
            this.lblSubMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaNL.Location = new System.Drawing.Point(6, 38);
            this.lblSubMaNL.Name = "lblSubMaNL";
            this.lblSubMaNL.Size = new System.Drawing.Size(62, 18);
            this.lblSubMaNL.TabIndex = 0;
            this.lblSubMaNL.Text = "Mã NL:";
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNguyenLieu";
            this.Text = "frmNguyenLieu";
            this.Activated += new System.EventHandler(this.frmNguyenLieu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNguyenLieu_FormClosed);
            this.Load += new System.EventHandler(this.frmNguyenLieu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguyenLieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiemNL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDSNguyenLieu;
        private System.Windows.Forms.Label lblSubDSNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnLamMoi;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private System.Windows.Forms.Label lblSubMaLoaiNL;
        private System.Windows.Forms.Label lblSubNhaCungCap;
        private MetroFramework.Controls.MetroComboBox cboLoaiNL;
        private System.Windows.Forms.TextBox txtSLTonKho;
        private MetroFramework.Controls.MetroComboBox cboNhaCC;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label lblSubTrangThai;
        private System.Windows.Forms.Label lblSubSLTK;
        private System.Windows.Forms.Label lblSubDonGia;
        private System.Windows.Forms.Label lblSubDonViTinh;
        private System.Windows.Forms.Label lblSubTenNL;
        private System.Windows.Forms.Label lblSubMaNL;
        private System.Windows.Forms.Button btnAddNCC;
        private System.Windows.Forms.Button btnAddLoaiNL;
        private MetroFramework.Controls.MetroComboBox cboDonViTinh;
        private MetroFramework.Controls.MetroCheckBox chkNLConSuDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNhaCungCap;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiNL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
    }
}