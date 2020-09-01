namespace QLCuaHangThucAnNhanh
{
    partial class frmMonAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonAn));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkMAConSuDung = new MetroFramework.Controls.MetroCheckBox();
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnhMon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTimKiemMon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSubDSMon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnAddLM = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.lblSubMaLoaiMon = new System.Windows.Forms.Label();
            this.cboLoaiMon = new MetroFramework.Controls.MetroComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSubDonGia = new System.Windows.Forms.Label();
            this.lblSubTenMon = new System.Windows.Forms.Label();
            this.lblSubMaMon = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
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
            this.panel2.Controls.Add(this.chkMAConSuDung);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.dgvDSMon);
            this.panel2.Controls.Add(this.txtTimKiemMon);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblSubDSMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 579);
            this.panel2.TabIndex = 1;
            // 
            // chkMAConSuDung
            // 
            this.chkMAConSuDung.AutoSize = true;
            this.chkMAConSuDung.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMAConSuDung.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkMAConSuDung.Location = new System.Drawing.Point(12, 90);
            this.chkMAConSuDung.Name = "chkMAConSuDung";
            this.chkMAConSuDung.Size = new System.Drawing.Size(277, 19);
            this.chkMAConSuDung.TabIndex = 72;
            this.chkMAConSuDung.Text = "Danh sách món ăn không còn sử dụng";
            this.chkMAConSuDung.UseSelectable = true;
            this.chkMAConSuDung.CheckedChanged += new System.EventHandler(this.chkMAConSuDung_CheckedChanged);
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.AllowUserToAddRows = false;
            this.dgvDSMon.AllowUserToResizeRows = false;
            this.dgvDSMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colMaLoaiMon,
            this.colTenMon,
            this.colDonGia,
            this.colHinhAnhMon,
            this.colTrangThai});
            this.dgvDSMon.Location = new System.Drawing.Point(13, 130);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.ReadOnly = true;
            this.dgvDSMon.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSMon.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSMon.RowTemplate.Height = 30;
            this.dgvDSMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMon.Size = new System.Drawing.Size(709, 435);
            this.dgvDSMon.TabIndex = 17;
            this.dgvDSMon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSMon_CellFormatting);
            this.dgvDSMon.SelectionChanged += new System.EventHandler(this.dgvDSMon_SelectionChanged);
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.HeaderText = "Mã Món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            // 
            // colMaLoaiMon
            // 
            this.colMaLoaiMon.DataPropertyName = "MaLoaiMon";
            this.colMaLoaiMon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaLoaiMon.HeaderText = "Mã Loại Món";
            this.colMaLoaiMon.Name = "colMaLoaiMon";
            this.colMaLoaiMon.ReadOnly = true;
            this.colMaLoaiMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaLoaiMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0 VND";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            this.colDonGia.Width = 150;
            // 
            // colHinhAnhMon
            // 
            this.colHinhAnhMon.DataPropertyName = "HinhAnh";
            this.colHinhAnhMon.HeaderText = "Hình Ảnh";
            this.colHinhAnhMon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colHinhAnhMon.Name = "colHinhAnhMon";
            this.colHinhAnhMon.ReadOnly = true;
            this.colHinhAnhMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHinhAnhMon.Width = 70;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Còn Sử Dụng";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // txtTimKiemMon
            // 
            this.txtTimKiemMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMon.Location = new System.Drawing.Point(517, 90);
            this.txtTimKiemMon.Name = "txtTimKiemMon";
            this.txtTimKiemMon.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemMon.TabIndex = 62;
            this.txtTimKiemMon.TextChanged += new System.EventHandler(this.txtTimKiemMon_TextChanged);
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
            // lblSubDSMon
            // 
            this.lblSubDSMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSMon.Location = new System.Drawing.Point(12, 62);
            this.lblSubDSMon.Name = "lblSubDSMon";
            this.lblSubDSMon.Size = new System.Drawing.Size(709, 24);
            this.lblSubDSMon.TabIndex = 16;
            this.lblSubDSMon.Text = "DANH SÁCH MÓN ĂN";
            this.lblSubDSMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 579);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnAddLM);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.picHinh);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.lblSubMaLoaiMon);
            this.groupBox1.Controls.Add(this.cboLoaiMon);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblSubDonGia);
            this.groupBox1.Controls.Add(this.lblSubTenMon);
            this.groupBox1.Controls.Add(this.lblSubMaMon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 494);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN MÓN ĂN";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 414);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(171, 414);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(108, 34);
            this.btnLamMoi.TabIndex = 74;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(171, 414);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(108, 34);
            this.btnKhoiPhuc.TabIndex = 73;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnAddLM
            // 
            this.btnAddLM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLM.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.add;
            this.btnAddLM.Location = new System.Drawing.Point(407, 153);
            this.btnAddLM.Name = "btnAddLM";
            this.btnAddLM.Size = new System.Drawing.Size(32, 32);
            this.btnAddLM.TabIndex = 65;
            this.btnAddLM.UseVisualStyleBackColor = true;
            this.btnAddLM.Click += new System.EventHandler(this.btnAddLM_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(6, 414);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
            this.btnCapNhat.TabIndex = 64;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(332, 414);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(9, 242);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(79, 18);
            this.lbl.TabIndex = 60;
            this.lbl.Text = "Hình ảnh:";
            // 
            // picHinh
            // 
            this.picHinh.BackColor = System.Drawing.Color.LightGray;
            this.picHinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHinh.BackgroundImage")));
            this.picHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHinh.Location = new System.Drawing.Point(143, 242);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(168, 122);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinh.TabIndex = 59;
            this.picHinh.TabStop = false;
            this.picHinh.Click += new System.EventHandler(this.picHinh_Click);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.Location = new System.Drawing.Point(146, 198);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(107, 19);
            this.chkTrangThai.TabIndex = 54;
            this.chkTrangThai.Text = "Còn Sử Dụng";
            this.chkTrangThai.UseSelectable = true;
            // 
            // lblSubMaLoaiMon
            // 
            this.lblSubMaLoaiMon.AutoSize = true;
            this.lblSubMaLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaLoaiMon.Location = new System.Drawing.Point(6, 156);
            this.lblSubMaLoaiMon.Name = "lblSubMaLoaiMon";
            this.lblSubMaLoaiMon.Size = new System.Drawing.Size(83, 18);
            this.lblSubMaLoaiMon.TabIndex = 56;
            this.lblSubMaLoaiMon.Text = "Loại món:";
            // 
            // cboLoaiMon
            // 
            this.cboLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiMon.FormattingEnabled = true;
            this.cboLoaiMon.ItemHeight = 23;
            this.cboLoaiMon.Location = new System.Drawing.Point(146, 156);
            this.cboLoaiMon.Name = "cboLoaiMon";
            this.cboLoaiMon.Size = new System.Drawing.Size(255, 29);
            this.cboLoaiMon.TabIndex = 57;
            this.cboLoaiMon.UseSelectable = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(146, 114);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(294, 24);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(146, 73);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(294, 24);
            this.txtTenMon.TabIndex = 8;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(146, 32);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(294, 24);
            this.txtMaMon.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(6, 199);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(88, 18);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblSubDonGia
            // 
            this.lblSubDonGia.AutoSize = true;
            this.lblSubDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDonGia.Location = new System.Drawing.Point(6, 114);
            this.lblSubDonGia.Name = "lblSubDonGia";
            this.lblSubDonGia.Size = new System.Drawing.Size(71, 18);
            this.lblSubDonGia.TabIndex = 4;
            this.lblSubDonGia.Text = "Đơn giá:";
            // 
            // lblSubTenMon
            // 
            this.lblSubTenMon.AutoSize = true;
            this.lblSubTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTenMon.Location = new System.Drawing.Point(6, 73);
            this.lblSubTenMon.Name = "lblSubTenMon";
            this.lblSubTenMon.Size = new System.Drawing.Size(79, 18);
            this.lblSubTenMon.TabIndex = 2;
            this.lblSubTenMon.Text = "Tên món:";
            // 
            // lblSubMaMon
            // 
            this.lblSubMaMon.AutoSize = true;
            this.lblSubMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaMon.Location = new System.Drawing.Point(6, 32);
            this.lblSubMaMon.Name = "lblSubMaMon";
            this.lblSubMaMon.Size = new System.Drawing.Size(74, 18);
            this.lblSubMaMon.TabIndex = 0;
            this.lblSubMaMon.Text = "Mã món:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 47);
            this.btnQuayLai.TabIndex = 59;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonAn";
            this.Text = "frmMonAn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMonAn_FormClosed);
            this.Load += new System.EventHandler(this.frmMonAn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox picHinh;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private System.Windows.Forms.Label lblSubMaLoaiMon;
        private MetroFramework.Controls.MetroComboBox cboLoaiMon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSubDonGia;
        private System.Windows.Forms.Label lblSubTenMon;
        private System.Windows.Forms.Label lblSubMaMon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAddLM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiemMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Label lblSubDSMon;
        //private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroCheckBox chkMAConSuDung;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLoaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnhMon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
    }
}