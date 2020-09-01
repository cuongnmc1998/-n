namespace QLCuaHangThucAnNhanh
{
    partial class frmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTHDBanHang = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaMon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.btnInPhieuDM = new System.Windows.Forms.Button();
            this.lblTienThoiKH = new System.Windows.Forms.Label();
            this.gboHDThanhToan = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayLHD = new System.Windows.Forms.Label();
            this.lblNguoiLHD = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblSubNgayLHD = new System.Windows.Forms.Label();
            this.lblSubNguoiLHD = new System.Windows.Forms.Label();
            this.lblSubMaHD = new System.Windows.Forms.Label();
            this.lblSubTongTien = new System.Windows.Forms.Label();
            this.txtTienCuaKH = new System.Windows.Forms.TextBox();
            this.lblSubTienCuaKH = new System.Windows.Forms.Label();
            this.lblSubTienThoiKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDBanHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.gboHDThanhToan.SuspendLayout();
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
            this.splitContainer1.Panel1MinSize = 734;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2MinSize = 452;
            this.splitContainer1.Size = new System.Drawing.Size(1190, 579);
            this.splitContainer1.SplitterDistance = 734;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTHDBanHang);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 579);
            this.panel1.TabIndex = 0;
            // 
            // dgvCTHDBanHang
            // 
            this.dgvCTHDBanHang.AllowUserToAddRows = false;
            this.dgvCTHDBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDBanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.ColMaMon,
            this.colDonGia,
            this.colSoLuong,
            this.colGhiChu});
            this.dgvCTHDBanHang.Location = new System.Drawing.Point(12, 100);
            this.dgvCTHDBanHang.Name = "dgvCTHDBanHang";
            this.dgvCTHDBanHang.ReadOnly = true;
            this.dgvCTHDBanHang.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvCTHDBanHang.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHDBanHang.RowTemplate.Height = 30;
            this.dgvCTHDBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHDBanHang.Size = new System.Drawing.Size(710, 467);
            this.dgvCTHDBanHang.TabIndex = 62;
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.HeaderText = "Mã Hóa Đơn";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // ColMaMon
            // 
            this.ColMaMon.DataPropertyName = "MaMon";
            this.ColMaMon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColMaMon.HeaderText = "Tên Món";
            this.ColMaMon.Name = "ColMaMon";
            this.ColMaMon.ReadOnly = true;
            this.ColMaMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMaMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColMaMon.Width = 200;
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
            this.colDonGia.Width = 130;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 130;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 250;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 47);
            this.btnQuayLai.TabIndex = 60;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "DANH SÁCH CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXuatHD);
            this.panel2.Controls.Add(this.btnInPhieuDM);
            this.panel2.Controls.Add(this.lblTienThoiKH);
            this.panel2.Controls.Add(this.gboHDThanhToan);
            this.panel2.Controls.Add(this.txtTienCuaKH);
            this.panel2.Controls.Add(this.lblSubTienCuaKH);
            this.panel2.Controls.Add(this.lblSubTienThoiKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 579);
            this.panel2.TabIndex = 0;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.Location = new System.Drawing.Point(259, 351);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(139, 47);
            this.btnXuatHD.TabIndex = 62;
            this.btnXuatHD.Text = "XUẤT HÓA ĐƠN";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // btnInPhieuDM
            // 
            this.btnInPhieuDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInPhieuDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuDM.Location = new System.Drawing.Point(48, 351);
            this.btnInPhieuDM.Name = "btnInPhieuDM";
            this.btnInPhieuDM.Size = new System.Drawing.Size(139, 47);
            this.btnInPhieuDM.TabIndex = 61;
            this.btnInPhieuDM.Text = "IN PHIẾU ĐẶT MÓN";
            this.btnInPhieuDM.UseVisualStyleBackColor = true;
            this.btnInPhieuDM.Click += new System.EventHandler(this.btnInPhieuDM_Click);
            // 
            // lblTienThoiKH
            // 
            this.lblTienThoiKH.AutoSize = true;
            this.lblTienThoiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThoiKH.Location = new System.Drawing.Point(189, 298);
            this.lblTienThoiKH.Name = "lblTienThoiKH";
            this.lblTienThoiKH.Size = new System.Drawing.Size(63, 22);
            this.lblTienThoiKH.TabIndex = 59;
            this.lblTienThoiKH.Text = "0 VND";
            // 
            // gboHDThanhToan
            // 
            this.gboHDThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboHDThanhToan.Controls.Add(this.lblTongTien);
            this.gboHDThanhToan.Controls.Add(this.lblNgayLHD);
            this.gboHDThanhToan.Controls.Add(this.lblNguoiLHD);
            this.gboHDThanhToan.Controls.Add(this.lblMaHD);
            this.gboHDThanhToan.Controls.Add(this.lblSubNgayLHD);
            this.gboHDThanhToan.Controls.Add(this.lblSubNguoiLHD);
            this.gboHDThanhToan.Controls.Add(this.lblSubMaHD);
            this.gboHDThanhToan.Controls.Add(this.lblSubTongTien);
            this.gboHDThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboHDThanhToan.Location = new System.Drawing.Point(3, 5);
            this.gboHDThanhToan.Name = "gboHDThanhToan";
            this.gboHDThanhToan.Size = new System.Drawing.Size(443, 228);
            this.gboHDThanhToan.TabIndex = 48;
            this.gboHDThanhToan.TabStop = false;
            this.gboHDThanhToan.Text = "THÔNG TIN HÓA ĐƠN BÁN HÀNG";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(129, 168);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(95, 18);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "200,000 VND";
            // 
            // lblNgayLHD
            // 
            this.lblNgayLHD.AutoSize = true;
            this.lblNgayLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLHD.Location = new System.Drawing.Point(129, 126);
            this.lblNgayLHD.Name = "lblNgayLHD";
            this.lblNgayLHD.Size = new System.Drawing.Size(72, 18);
            this.lblNgayLHD.TabIndex = 6;
            this.lblNgayLHD.Text = "1/12/2018";
            // 
            // lblNguoiLHD
            // 
            this.lblNguoiLHD.AutoSize = true;
            this.lblNguoiLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiLHD.Location = new System.Drawing.Point(129, 81);
            this.lblNguoiLHD.Name = "lblNguoiLHD";
            this.lblNguoiLHD.Size = new System.Drawing.Size(97, 18);
            this.lblNguoiLHD.TabIndex = 5;
            this.lblNguoiLHD.Text = "QL Bán Hàng";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(129, 41);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(67, 18);
            this.lblMaHD.TabIndex = 4;
            this.lblMaHD.Text = "MHD001";
            // 
            // lblSubNgayLHD
            // 
            this.lblSubNgayLHD.AutoSize = true;
            this.lblSubNgayLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNgayLHD.Location = new System.Drawing.Point(6, 126);
            this.lblSubNgayLHD.Name = "lblSubNgayLHD";
            this.lblSubNgayLHD.Size = new System.Drawing.Size(107, 18);
            this.lblSubNgayLHD.TabIndex = 2;
            this.lblSubNgayLHD.Text = "Ngày lập HĐ:";
            // 
            // lblSubNguoiLHD
            // 
            this.lblSubNguoiLHD.AutoSize = true;
            this.lblSubNguoiLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNguoiLHD.Location = new System.Drawing.Point(6, 81);
            this.lblSubNguoiLHD.Name = "lblSubNguoiLHD";
            this.lblSubNguoiLHD.Size = new System.Drawing.Size(113, 18);
            this.lblSubNguoiLHD.TabIndex = 1;
            this.lblSubNguoiLHD.Text = "Người lập HĐ:";
            // 
            // lblSubMaHD
            // 
            this.lblSubMaHD.AutoSize = true;
            this.lblSubMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaHD.Location = new System.Drawing.Point(6, 41);
            this.lblSubMaHD.Name = "lblSubMaHD";
            this.lblSubMaHD.Size = new System.Drawing.Size(65, 18);
            this.lblSubMaHD.TabIndex = 0;
            this.lblSubMaHD.Text = "Mã HĐ:";
            // 
            // lblSubTongTien
            // 
            this.lblSubTongTien.AutoSize = true;
            this.lblSubTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTongTien.Location = new System.Drawing.Point(6, 168);
            this.lblSubTongTien.Name = "lblSubTongTien";
            this.lblSubTongTien.Size = new System.Drawing.Size(83, 18);
            this.lblSubTongTien.TabIndex = 3;
            this.lblSubTongTien.Text = "Tổng tiền:";
            // 
            // txtTienCuaKH
            // 
            this.txtTienCuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCuaKH.Location = new System.Drawing.Point(193, 251);
            this.txtTienCuaKH.Name = "txtTienCuaKH";
            this.txtTienCuaKH.Size = new System.Drawing.Size(205, 27);
            this.txtTienCuaKH.TabIndex = 58;
            this.txtTienCuaKH.TextChanged += new System.EventHandler(this.txtTienCuaKH_TextChanged);
            // 
            // lblSubTienCuaKH
            // 
            this.lblSubTienCuaKH.AutoSize = true;
            this.lblSubTienCuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTienCuaKH.Location = new System.Drawing.Point(8, 254);
            this.lblSubTienCuaKH.Name = "lblSubTienCuaKH";
            this.lblSubTienCuaKH.Size = new System.Drawing.Size(179, 22);
            this.lblSubTienCuaKH.TabIndex = 56;
            this.lblSubTienCuaKH.Text = "Tổng tiền khách đưa:";
            // 
            // lblSubTienThoiKH
            // 
            this.lblSubTienThoiKH.AutoSize = true;
            this.lblSubTienThoiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTienThoiKH.Location = new System.Drawing.Point(8, 298);
            this.lblSubTienThoiKH.Name = "lblSubTienThoiKH";
            this.lblSubTienThoiKH.Size = new System.Drawing.Size(148, 22);
            this.lblSubTienThoiKH.TabIndex = 57;
            this.lblSubTienThoiKH.Text = "Tổng tiền thói lại:";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanHang";
            this.Text = "Hóa Đơn Thanh Toán";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDBanHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gboHDThanhToan.ResumeLayout(false);
            this.gboHDThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboHDThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayLHD;
        private System.Windows.Forms.Label lblNguoiLHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblSubNgayLHD;
        private System.Windows.Forms.Label lblSubNguoiLHD;
        private System.Windows.Forms.Label lblSubMaHD;
        private System.Windows.Forms.Label lblSubTongTien;
        private System.Windows.Forms.Label lblTienThoiKH;
        private System.Windows.Forms.TextBox txtTienCuaKH;
        private System.Windows.Forms.Label lblSubTienCuaKH;
        private System.Windows.Forms.Label lblSubTienThoiKH;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.Button btnInPhieuDM;
        private System.Windows.Forms.DataGridView dgvCTHDBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}