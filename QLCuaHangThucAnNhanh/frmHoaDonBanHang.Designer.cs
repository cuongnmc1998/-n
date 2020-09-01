namespace QLCuaHangThucAnNhanh
{
    partial class frmHoaDonBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiemHDTT = new System.Windows.Forms.TextBox();
            this.lblSubTimKiem = new System.Windows.Forms.Label();
            this.lblSubDSHDThanhToan = new System.Windows.Forms.Label();
            this.dgvDSHDThanhToan = new System.Windows.Forms.DataGridView();
            this.lblSubMaHD = new System.Windows.Forms.Label();
            this.lblSubTrangThai = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSCTHDThanhToan = new System.Windows.Forms.DataGridView();
            this.lblSubThongTinCTHDThanhToan = new System.Windows.Forms.Label();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDThanhToan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHDThanhToan)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 664;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2MinSize = 506;
            this.splitContainer1.Size = new System.Drawing.Size(1174, 540);
            this.splitContainer1.SplitterDistance = 664;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkTrangThai);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.txtTimKiemHDTT);
            this.panel1.Controls.Add(this.lblSubTimKiem);
            this.panel1.Controls.Add(this.lblSubDSHDThanhToan);
            this.panel1.Controls.Add(this.dgvDSHDThanhToan);
            this.panel1.Controls.Add(this.lblSubMaHD);
            this.panel1.Controls.Add(this.lblSubTrangThai);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 540);
            this.panel1.TabIndex = 0;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkTrangThai.Location = new System.Drawing.Point(6, 98);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(201, 19);
            this.chkTrangThai.TabIndex = 108;
            this.chkTrangThai.Text = "Danh sách hóa đơn đã xóa";
            this.chkTrangThai.UseSelectable = true;
            this.chkTrangThai.CheckedChanged += new System.EventHandler(this.chkTrangThai_CheckedChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(511, 431);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(139, 47);
            this.btnKhoiPhuc.TabIndex = 107;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(102, 461);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(114, 28);
            this.lblTrangThai.TabIndex = 106;
            this.lblTrangThai.Text = "Đã thanh toán";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(327, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 47);
            this.btnXoa.TabIndex = 105;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(12, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 47);
            this.btnThoat.TabIndex = 104;
            this.btnThoat.Text = "QUAY LẠI";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTimKiemHDTT
            // 
            this.txtTimKiemHDTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemHDTT.Location = new System.Drawing.Point(446, 98);
            this.txtTimKiemHDTT.Name = "txtTimKiemHDTT";
            this.txtTimKiemHDTT.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemHDTT.TabIndex = 102;
            // 
            // lblSubTimKiem
            // 
            this.lblSubTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTimKiem.AutoSize = true;
            this.lblSubTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTimKiem.Location = new System.Drawing.Point(361, 101);
            this.lblSubTimKiem.Name = "lblSubTimKiem";
            this.lblSubTimKiem.Size = new System.Drawing.Size(84, 18);
            this.lblSubTimKiem.TabIndex = 103;
            this.lblSubTimKiem.Text = "Tìm Kiếm:";
            // 
            // lblSubDSHDThanhToan
            // 
            this.lblSubDSHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSHDThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSHDThanhToan.Location = new System.Drawing.Point(9, 62);
            this.lblSubDSHDThanhToan.Name = "lblSubDSHDThanhToan";
            this.lblSubDSHDThanhToan.Size = new System.Drawing.Size(641, 22);
            this.lblSubDSHDThanhToan.TabIndex = 92;
            this.lblSubDSHDThanhToan.Text = "DANH SÁCH HÓA ĐƠN BÁN HÀNG\r\n";
            this.lblSubDSHDThanhToan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDSHDThanhToan
            // 
            this.dgvDSHDThanhToan.AllowUserToAddRows = false;
            this.dgvDSHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHDThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHDThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHDThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenTaiKhoan,
            this.colNgayLapHD,
            this.colTongTien,
            this.colGhiChu});
            this.dgvDSHDThanhToan.Location = new System.Drawing.Point(9, 131);
            this.dgvDSHDThanhToan.MultiSelect = false;
            this.dgvDSHDThanhToan.Name = "dgvDSHDThanhToan";
            this.dgvDSHDThanhToan.ReadOnly = true;
            this.dgvDSHDThanhToan.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSHDThanhToan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSHDThanhToan.RowTemplate.Height = 30;
            this.dgvDSHDThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHDThanhToan.Size = new System.Drawing.Size(641, 285);
            this.dgvDSHDThanhToan.TabIndex = 94;
            this.dgvDSHDThanhToan.SelectionChanged += new System.EventHandler(this.dgvDSHDThanhToan_SelectionChanged);
            // 
            // lblSubMaHD
            // 
            this.lblSubMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubMaHD.AutoSize = true;
            this.lblSubMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaHD.Location = new System.Drawing.Point(6, 431);
            this.lblSubMaHD.Name = "lblSubMaHD";
            this.lblSubMaHD.Size = new System.Drawing.Size(65, 18);
            this.lblSubMaHD.TabIndex = 95;
            this.lblSubMaHD.Text = "Mã HĐ:";
            // 
            // lblSubTrangThai
            // 
            this.lblSubTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubTrangThai.AutoSize = true;
            this.lblSubTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTrangThai.Location = new System.Drawing.Point(3, 461);
            this.lblSubTrangThai.Name = "lblSubTrangThai";
            this.lblSubTrangThai.Size = new System.Drawing.Size(93, 18);
            this.lblSubTrangThai.TabIndex = 97;
            this.lblSubTrangThai.Text = "Trạng Thái:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(102, 431);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(88, 28);
            this.lblMaHD.TabIndex = 96;
            this.lblMaHD.Text = "MHD001";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSCTHDThanhToan);
            this.panel2.Controls.Add(this.lblSubThongTinCTHDThanhToan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 540);
            this.panel2.TabIndex = 0;
            // 
            // dgvDSCTHDThanhToan
            // 
            this.dgvDSCTHDThanhToan.AllowUserToAddRows = false;
            this.dgvDSCTHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCTHDThanhToan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSCTHDThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTHDThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCTMaHD,
            this.colMaMon,
            this.colDonGia,
            this.colSoLuong});
            this.dgvDSCTHDThanhToan.Location = new System.Drawing.Point(18, 66);
            this.dgvDSCTHDThanhToan.MultiSelect = false;
            this.dgvDSCTHDThanhToan.Name = "dgvDSCTHDThanhToan";
            this.dgvDSCTHDThanhToan.ReadOnly = true;
            this.dgvDSCTHDThanhToan.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSCTHDThanhToan.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSCTHDThanhToan.RowTemplate.Height = 30;
            this.dgvDSCTHDThanhToan.Size = new System.Drawing.Size(476, 413);
            this.dgvDSCTHDThanhToan.TabIndex = 70;
            // 
            // lblSubThongTinCTHDThanhToan
            // 
            this.lblSubThongTinCTHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubThongTinCTHDThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubThongTinCTHDThanhToan.Location = new System.Drawing.Point(14, 9);
            this.lblSubThongTinCTHDThanhToan.Name = "lblSubThongTinCTHDThanhToan";
            this.lblSubThongTinCTHDThanhToan.Size = new System.Drawing.Size(480, 45);
            this.lblSubThongTinCTHDThanhToan.TabIndex = 69;
            this.lblSubThongTinCTHDThanhToan.Text = "DANH SÁCH \r\nCHI TIẾT HÓA ĐƠN BÁN HÀNG";
            this.lblSubThongTinCTHDThanhToan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colTenTaiKhoan
            // 
            this.colTenTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.colTenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.colTenTaiKhoan.Name = "colTenTaiKhoan";
            this.colTenTaiKhoan.ReadOnly = true;
            // 
            // colNgayLapHD
            // 
            this.colNgayLapHD.DataPropertyName = "NgayLapHD";
            this.colNgayLapHD.HeaderText = "Ngày Lập";
            this.colNgayLapHD.Name = "colNgayLapHD";
            this.colNgayLapHD.ReadOnly = true;
            this.colNgayLapHD.Width = 130;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0 VND";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colCTMaHD
            // 
            this.colCTMaHD.DataPropertyName = "MaHD";
            this.colCTMaHD.HeaderText = "Mã HD";
            this.colCTMaHD.Name = "colCTMaHD";
            this.colCTMaHD.ReadOnly = true;
            // 
            // colMaMon
            // 
            this.colMaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaMon.HeaderText = "Mã món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            this.colMaMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0 VND";
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 540);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDonBanHang";
            this.Text = "frmHoaDonThanhToan";
            this.Activated += new System.EventHandler(this.frmHoaDonBanHang_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHoaDonThanhToan_FormClosed);
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDThanhToan)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHDThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiemHDTT;
        private System.Windows.Forms.Label lblSubTimKiem;
        private System.Windows.Forms.Label lblSubDSHDThanhToan;
        private System.Windows.Forms.DataGridView dgvDSHDThanhToan;
        private System.Windows.Forms.Label lblSubMaHD;
        private System.Windows.Forms.Label lblSubTrangThai;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSCTHDThanhToan;
        private System.Windows.Forms.Label lblSubThongTinCTHDThanhToan;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Label lblTrangThai;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}