namespace QLCuaHangThucAnNhanh
{
    partial class frmLoaiMonAn
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkLoaiMAConSuDung = new MetroFramework.Controls.MetroCheckBox();
            this.txtTimKiemLM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDSLoaiMon = new System.Windows.Forms.DataGridView();
            this.colMaLoaiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSubDSLoaiMon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongTinLoaiMon = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaLoaiMon = new System.Windows.Forms.TextBox();
            this.lblTenLoaiMon = new System.Windows.Forms.Label();
            this.lblSubMaLoaiMon = new System.Windows.Forms.Label();
            this.txtTenLoaiMon = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbThongTinLoaiMon.SuspendLayout();
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
            this.splitContainer1.Panel1MinSize = 704;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 482;
            this.splitContainer1.Size = new System.Drawing.Size(1190, 365);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkLoaiMAConSuDung);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.txtTimKiemLM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvDSLoaiMon);
            this.panel2.Controls.Add(this.lblSubDSLoaiMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 365);
            this.panel2.TabIndex = 1;
            // 
            // chkLoaiMAConSuDung
            // 
            this.chkLoaiMAConSuDung.AutoSize = true;
            this.chkLoaiMAConSuDung.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkLoaiMAConSuDung.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkLoaiMAConSuDung.Location = new System.Drawing.Point(12, 90);
            this.chkLoaiMAConSuDung.Name = "chkLoaiMAConSuDung";
            this.chkLoaiMAConSuDung.Size = new System.Drawing.Size(306, 19);
            this.chkLoaiMAConSuDung.TabIndex = 71;
            this.chkLoaiMAConSuDung.Text = "Danh sách loại món ăn không còn sử dụng";
            this.chkLoaiMAConSuDung.UseSelectable = true;
            this.chkLoaiMAConSuDung.CheckedChanged += new System.EventHandler(this.chkLoaiMAConSuDung_CheckedChanged);
            // 
            // txtTimKiemLM
            // 
            this.txtTimKiemLM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemLM.Location = new System.Drawing.Point(488, 90);
            this.txtTimKiemLM.Name = "txtTimKiemLM";
            this.txtTimKiemLM.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemLM.TabIndex = 68;
            this.txtTimKiemLM.TextChanged += new System.EventHandler(this.txtTimKiemLM_TextChanged);
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dgvDSLoaiMon
            // 
            this.dgvDSLoaiMon.AllowUserToAddRows = false;
            this.dgvDSLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLoaiMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSLoaiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiMon,
            this.colTenLoaiMon,
            this.colTrangThai});
            this.dgvDSLoaiMon.Location = new System.Drawing.Point(12, 129);
            this.dgvDSLoaiMon.Name = "dgvDSLoaiMon";
            this.dgvDSLoaiMon.ReadOnly = true;
            this.dgvDSLoaiMon.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSLoaiMon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSLoaiMon.RowTemplate.Height = 30;
            this.dgvDSLoaiMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLoaiMon.Size = new System.Drawing.Size(680, 224);
            this.dgvDSLoaiMon.TabIndex = 67;
            this.dgvDSLoaiMon.SelectionChanged += new System.EventHandler(this.dgvDSLoaiMon_SelectionChanged);
            // 
            // colMaLoaiMon
            // 
            this.colMaLoaiMon.DataPropertyName = "MaLoaiMon";
            this.colMaLoaiMon.HeaderText = "Mã Loại Món";
            this.colMaLoaiMon.Name = "colMaLoaiMon";
            this.colMaLoaiMon.ReadOnly = true;
            // 
            // colTenLoaiMon
            // 
            this.colTenLoaiMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiMon.DataPropertyName = "TenLoaiMon";
            this.colTenLoaiMon.HeaderText = "Tên Loại Món";
            this.colTenLoaiMon.Name = "colTenLoaiMon";
            this.colTenLoaiMon.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Còn Sử Dụng";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // lblSubDSLoaiMon
            // 
            this.lblSubDSLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSLoaiMon.Location = new System.Drawing.Point(12, 62);
            this.lblSubDSLoaiMon.Name = "lblSubDSLoaiMon";
            this.lblSubDSLoaiMon.Size = new System.Drawing.Size(680, 22);
            this.lblSubDSLoaiMon.TabIndex = 66;
            this.lblSubDSLoaiMon.Text = "DANH SÁCH LOẠI MÓN ĂN";
            this.lblSubDSLoaiMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbThongTinLoaiMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 365);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinLoaiMon
            // 
            this.grbThongTinLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinLoaiMon.Controls.Add(this.btnThem);
            this.grbThongTinLoaiMon.Controls.Add(this.btnLamMoi);
            this.grbThongTinLoaiMon.Controls.Add(this.btnKhoiPhuc);
            this.grbThongTinLoaiMon.Controls.Add(this.chkTrangThai);
            this.grbThongTinLoaiMon.Controls.Add(this.lblTrangThai);
            this.grbThongTinLoaiMon.Controls.Add(this.btnCapNhat);
            this.grbThongTinLoaiMon.Controls.Add(this.btnXoa);
            this.grbThongTinLoaiMon.Controls.Add(this.txtMaLoaiMon);
            this.grbThongTinLoaiMon.Controls.Add(this.lblTenLoaiMon);
            this.grbThongTinLoaiMon.Controls.Add(this.lblSubMaLoaiMon);
            this.grbThongTinLoaiMon.Controls.Add(this.txtTenLoaiMon);
            this.grbThongTinLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinLoaiMon.Location = new System.Drawing.Point(3, 62);
            this.grbThongTinLoaiMon.Name = "grbThongTinLoaiMon";
            this.grbThongTinLoaiMon.Size = new System.Drawing.Size(476, 291);
            this.grbThongTinLoaiMon.TabIndex = 63;
            this.grbThongTinLoaiMon.TabStop = false;
            this.grbThongTinLoaiMon.Text = "THÔNG TIN LOẠI MÓN ĂN";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(13, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 77;
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
            this.btnLamMoi.TabIndex = 76;
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
            this.btnKhoiPhuc.TabIndex = 75;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.Location = new System.Drawing.Point(127, 126);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(107, 19);
            this.chkTrangThai.TabIndex = 70;
            this.chkTrangThai.Text = "Còn Sử Dụng";
            this.chkTrangThai.UseSelectable = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(6, 126);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(88, 18);
            this.lblTrangThai.TabIndex = 69;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(13, 174);
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
            // txtMaLoaiMon
            // 
            this.txtMaLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiMon.Location = new System.Drawing.Point(127, 42);
            this.txtMaLoaiMon.Name = "txtMaLoaiMon";
            this.txtMaLoaiMon.Size = new System.Drawing.Size(343, 24);
            this.txtMaLoaiMon.TabIndex = 2;
            // 
            // lblTenLoaiMon
            // 
            this.lblTenLoaiMon.AutoSize = true;
            this.lblTenLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoaiMon.Location = new System.Drawing.Point(7, 87);
            this.lblTenLoaiMon.Name = "lblTenLoaiMon";
            this.lblTenLoaiMon.Size = new System.Drawing.Size(111, 18);
            this.lblTenLoaiMon.TabIndex = 1;
            this.lblTenLoaiMon.Text = "Tên loại món:";
            // 
            // lblSubMaLoaiMon
            // 
            this.lblSubMaLoaiMon.AutoSize = true;
            this.lblSubMaLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaLoaiMon.Location = new System.Drawing.Point(10, 42);
            this.lblSubMaLoaiMon.Name = "lblSubMaLoaiMon";
            this.lblSubMaLoaiMon.Size = new System.Drawing.Size(106, 18);
            this.lblSubMaLoaiMon.TabIndex = 0;
            this.lblSubMaLoaiMon.Text = "Mã loại món:";
            // 
            // txtTenLoaiMon
            // 
            this.txtTenLoaiMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiMon.Location = new System.Drawing.Point(127, 87);
            this.txtTenLoaiMon.Name = "txtTenLoaiMon";
            this.txtTenLoaiMon.Size = new System.Drawing.Size(343, 24);
            this.txtTenLoaiMon.TabIndex = 3;
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
            // frmLoaiMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 365);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiMonAn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoaiMonAn_FormClosed);
            this.Load += new System.EventHandler(this.frmLoaiMonAn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbThongTinLoaiMon.ResumeLayout(false);
            this.grbThongTinLoaiMon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox grbThongTinLoaiMon;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaLoaiMon;
        private System.Windows.Forms.Label lblTenLoaiMon;
        private System.Windows.Forms.Label lblSubMaLoaiMon;
        private System.Windows.Forms.TextBox txtTenLoaiMon;
        private System.Windows.Forms.DataGridView dgvDSLoaiMon;
        private System.Windows.Forms.Label lblSubDSLoaiMon;
        private System.Windows.Forms.TextBox txtTimKiemLM;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private MetroFramework.Controls.MetroCheckBox chkLoaiMAConSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiMon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.Button btnThem;
    }
}