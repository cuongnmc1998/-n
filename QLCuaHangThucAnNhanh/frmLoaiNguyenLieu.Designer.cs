namespace QLCuaHangThucAnNhanh
{
    partial class frmLoaiNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiemLoaiNL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSubDSNguyenLieu = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaLoaiNL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkNLConSuDung = new MetroFramework.Controls.MetroCheckBox();
            this.dgvDSLoaiNL = new System.Windows.Forms.DataGridView();
            this.colLoaiNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTenLoaiMon = new System.Windows.Forms.Label();
            this.lblSubMaLoaiMon = new System.Windows.Forms.Label();
            this.grbThongTinNguyenLieu = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.lblSubTrangThai = new System.Windows.Forms.Label();
            this.txtTenLoaiNL = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNL)).BeginInit();
            this.grbThongTinNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiemLoaiNL
            // 
            this.txtTimKiemLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemLoaiNL.Location = new System.Drawing.Point(488, 90);
            this.txtTimKiemLoaiNL.Name = "txtTimKiemLoaiNL";
            this.txtTimKiemLoaiNL.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemLoaiNL.TabIndex = 68;
            this.txtTimKiemLoaiNL.TextChanged += new System.EventHandler(this.txtTimKiemLoaiNL_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 69;
            this.label9.Text = "Tìm Kiếm:";
            // 
            // lblSubDSNguyenLieu
            // 
            this.lblSubDSNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSNguyenLieu.Location = new System.Drawing.Point(12, 62);
            this.lblSubDSNguyenLieu.Name = "lblSubDSNguyenLieu";
            this.lblSubDSNguyenLieu.Size = new System.Drawing.Size(680, 22);
            this.lblSubDSNguyenLieu.TabIndex = 66;
            this.lblSubDSNguyenLieu.Text = "DANH SÁCH LOẠI NGUYÊN LIỆU";
            this.lblSubDSNguyenLieu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(12, 174);
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
            this.btnXoa.Location = new System.Drawing.Point(362, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaLoaiNL
            // 
            this.txtMaLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiNL.Location = new System.Drawing.Point(127, 42);
            this.txtMaLoaiNL.Name = "txtMaLoaiNL";
            this.txtMaLoaiNL.Size = new System.Drawing.Size(343, 24);
            this.txtMaLoaiNL.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkNLConSuDung);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.txtTimKiemLoaiNL);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvDSLoaiNL);
            this.panel2.Controls.Add(this.lblSubDSNguyenLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 365);
            this.panel2.TabIndex = 1;
            // 
            // chkNLConSuDung
            // 
            this.chkNLConSuDung.AutoSize = true;
            this.chkNLConSuDung.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkNLConSuDung.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkNLConSuDung.Location = new System.Drawing.Point(12, 90);
            this.chkNLConSuDung.Name = "chkNLConSuDung";
            this.chkNLConSuDung.Size = new System.Drawing.Size(333, 19);
            this.chkNLConSuDung.TabIndex = 70;
            this.chkNLConSuDung.Text = "Danh sách loại nguyên liệu không còn sử dụng";
            this.chkNLConSuDung.UseSelectable = true;
            this.chkNLConSuDung.CheckedChanged += new System.EventHandler(this.chkNLConSuDung_CheckedChanged);
            // 
            // dgvDSLoaiNL
            // 
            this.dgvDSLoaiNL.AllowUserToAddRows = false;
            this.dgvDSLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLoaiNL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSLoaiNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoaiNL,
            this.colTenLoaiNL,
            this.colTrangThai});
            this.dgvDSLoaiNL.Location = new System.Drawing.Point(12, 129);
            this.dgvDSLoaiNL.Name = "dgvDSLoaiNL";
            this.dgvDSLoaiNL.ReadOnly = true;
            this.dgvDSLoaiNL.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSLoaiNL.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSLoaiNL.RowTemplate.Height = 30;
            this.dgvDSLoaiNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLoaiNL.Size = new System.Drawing.Size(680, 224);
            this.dgvDSLoaiNL.TabIndex = 67;
            this.dgvDSLoaiNL.SelectionChanged += new System.EventHandler(this.dgvDSLoaiNL_SelectionChanged);
            // 
            // colLoaiNL
            // 
            this.colLoaiNL.DataPropertyName = "MaLoaiNL";
            this.colLoaiNL.HeaderText = "Mã Loại Nguyên Liệu";
            this.colLoaiNL.Name = "colLoaiNL";
            this.colLoaiNL.ReadOnly = true;
            this.colLoaiNL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiNL.Width = 150;
            // 
            // colTenLoaiNL
            // 
            this.colTenLoaiNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiNL.DataPropertyName = "TenLoaiNL";
            this.colTenLoaiNL.HeaderText = "Tên Loại Nguyên Liệu";
            this.colTenLoaiNL.Name = "colTenLoaiNL";
            this.colTenLoaiNL.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Còn Sử Dụng";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(139, 47);
            this.btnQuayLai.TabIndex = 62;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTenLoaiMon
            // 
            this.lblTenLoaiMon.AutoSize = true;
            this.lblTenLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiMon.Location = new System.Drawing.Point(7, 87);
            this.lblTenLoaiMon.Name = "lblTenLoaiMon";
            this.lblTenLoaiMon.Size = new System.Drawing.Size(99, 18);
            this.lblTenLoaiMon.TabIndex = 1;
            this.lblTenLoaiMon.Text = "Tên loại NL:";
            // 
            // lblSubMaLoaiMon
            // 
            this.lblSubMaLoaiMon.AutoSize = true;
            this.lblSubMaLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaLoaiMon.Location = new System.Drawing.Point(10, 42);
            this.lblSubMaLoaiMon.Name = "lblSubMaLoaiMon";
            this.lblSubMaLoaiMon.Size = new System.Drawing.Size(94, 18);
            this.lblSubMaLoaiMon.TabIndex = 0;
            this.lblSubMaLoaiMon.Text = "Mã loại NL:";
            // 
            // grbThongTinNguyenLieu
            // 
            this.grbThongTinNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinNguyenLieu.Controls.Add(this.btnThem);
            this.grbThongTinNguyenLieu.Controls.Add(this.btnLamMoi);
            this.grbThongTinNguyenLieu.Controls.Add(this.btnKhoiPhuc);
            this.grbThongTinNguyenLieu.Controls.Add(this.chkTrangThai);
            this.grbThongTinNguyenLieu.Controls.Add(this.lblSubTrangThai);
            this.grbThongTinNguyenLieu.Controls.Add(this.btnCapNhat);
            this.grbThongTinNguyenLieu.Controls.Add(this.btnXoa);
            this.grbThongTinNguyenLieu.Controls.Add(this.txtMaLoaiNL);
            this.grbThongTinNguyenLieu.Controls.Add(this.lblTenLoaiMon);
            this.grbThongTinNguyenLieu.Controls.Add(this.lblSubMaLoaiMon);
            this.grbThongTinNguyenLieu.Controls.Add(this.txtTenLoaiNL);
            this.grbThongTinNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNguyenLieu.Location = new System.Drawing.Point(3, 62);
            this.grbThongTinNguyenLieu.Name = "grbThongTinNguyenLieu";
            this.grbThongTinNguyenLieu.Size = new System.Drawing.Size(476, 291);
            this.grbThongTinNguyenLieu.TabIndex = 63;
            this.grbThongTinNguyenLieu.TabStop = false;
            this.grbThongTinNguyenLieu.Text = "THÔNG TIN LOẠI NGUYÊN LIỆU";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(13, 174);
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
            this.btnLamMoi.Location = new System.Drawing.Point(189, 174);
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
            this.btnKhoiPhuc.Location = new System.Drawing.Point(189, 174);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(108, 34);
            this.btnKhoiPhuc.TabIndex = 73;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.Location = new System.Drawing.Point(127, 126);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(107, 19);
            this.chkTrangThai.TabIndex = 70;
            this.chkTrangThai.Text = "Còn Sử Dụng";
            this.chkTrangThai.UseSelectable = true;
            // 
            // lblSubTrangThai
            // 
            this.lblSubTrangThai.AutoSize = true;
            this.lblSubTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTrangThai.Location = new System.Drawing.Point(6, 126);
            this.lblSubTrangThai.Name = "lblSubTrangThai";
            this.lblSubTrangThai.Size = new System.Drawing.Size(88, 18);
            this.lblSubTrangThai.TabIndex = 69;
            this.lblSubTrangThai.Text = "Trạng thái:";
            // 
            // txtTenLoaiNL
            // 
            this.txtTenLoaiNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoaiNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiNL.Location = new System.Drawing.Point(127, 87);
            this.txtTenLoaiNL.Name = "txtTenLoaiNL";
            this.txtTenLoaiNL.Size = new System.Drawing.Size(343, 24);
            this.txtTenLoaiNL.TabIndex = 3;
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
            this.splitContainer1.Panel1MinSize = 704;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 482;
            this.splitContainer1.Size = new System.Drawing.Size(1190, 365);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbThongTinNguyenLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 365);
            this.panel1.TabIndex = 0;
            // 
            // frmLoaiNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 365);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiNguyenLieu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoaiNguyenLieu_FormClosed);
            this.Load += new System.EventHandler(this.frmLoaiNguyenLieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNL)).EndInit();
            this.grbThongTinNguyenLieu.ResumeLayout(false);
            this.grbThongTinNguyenLieu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiemLoaiNL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSubDSNguyenLieu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaLoaiNL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSLoaiNL;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTenLoaiMon;
        private System.Windows.Forms.Label lblSubMaLoaiMon;
        private System.Windows.Forms.GroupBox grbThongTinNguyenLieu;
        private System.Windows.Forms.TextBox txtTenLoaiNL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private System.Windows.Forms.Label lblSubTrangThai;
        private MetroFramework.Controls.MetroCheckBox chkNLConSuDung;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiNL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.Button btnThem;
    }
}