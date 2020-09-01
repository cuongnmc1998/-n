namespace QLCuaHangThucAnNhanh
{
    partial class frmNhaCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkNhaCungCap = new MetroFramework.Controls.MetroCheckBox();
            this.txtTimKiemNCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDSNhaCC = new System.Windows.Forms.DataGridView();
            this.lblSubDSNhaCC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbkTrangThai = new System.Windows.Forms.Label();
            this.chkTrangThai = new MetroFramework.Controls.MetroCheckBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.rtbDiaChiNCC = new System.Windows.Forms.RichTextBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtEmailNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblSubEmail = new System.Windows.Forms.Label();
            this.lblSubSDT = new System.Windows.Forms.Label();
            this.lblSubDiaChi = new System.Windows.Forms.Label();
            this.lblSubTenNCC = new System.Windows.Forms.Label();
            this.lblSubMaNCC = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCC)).BeginInit();
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
            this.panel2.Controls.Add(this.chkNhaCungCap);
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Controls.Add(this.txtTimKiemNCC);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvDSNhaCC);
            this.panel2.Controls.Add(this.lblSubDSNhaCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 579);
            this.panel2.TabIndex = 1;
            // 
            // chkNhaCungCap
            // 
            this.chkNhaCungCap.AutoSize = true;
            this.chkNhaCungCap.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkNhaCungCap.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkNhaCungCap.Location = new System.Drawing.Point(12, 90);
            this.chkNhaCungCap.Name = "chkNhaCungCap";
            this.chkNhaCungCap.Size = new System.Drawing.Size(230, 19);
            this.chkNhaCungCap.TabIndex = 64;
            this.chkNhaCungCap.Text = "Danh sách nhà cung cấp bị xóa";
            this.chkNhaCungCap.UseSelectable = true;
            this.chkNhaCungCap.CheckedChanged += new System.EventHandler(this.chkNhaCungCap_CheckedChanged);
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNCC.Location = new System.Drawing.Point(517, 90);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(204, 24);
            this.txtTimKiemNCC.TabIndex = 62;
            this.txtTimKiemNCC.TextChanged += new System.EventHandler(this.txtTimKiemNCC_TextChanged);
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
            // dgvDSNhaCC
            // 
            this.dgvDSNhaCC.AllowUserToAddRows = false;
            this.dgvDSNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhaCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colDiaChiNCC,
            this.colSDTNCC,
            this.colEmailNCC,
            this.colTrangThai});
            this.dgvDSNhaCC.Location = new System.Drawing.Point(13, 130);
            this.dgvDSNhaCC.MultiSelect = false;
            this.dgvDSNhaCC.Name = "dgvDSNhaCC";
            this.dgvDSNhaCC.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhaCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNhaCC.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSNhaCC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSNhaCC.RowTemplate.Height = 30;
            this.dgvDSNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhaCC.Size = new System.Drawing.Size(709, 435);
            this.dgvDSNhaCC.TabIndex = 17;
            this.dgvDSNhaCC.SelectionChanged += new System.EventHandler(this.dgvDSNhaCC_SelectionChanged);
            // 
            // lblSubDSNhaCC
            // 
            this.lblSubDSNhaCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubDSNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDSNhaCC.Location = new System.Drawing.Point(12, 62);
            this.lblSubDSNhaCC.Name = "lblSubDSNhaCC";
            this.lblSubDSNhaCC.Size = new System.Drawing.Size(709, 24);
            this.lblSubDSNhaCC.TabIndex = 16;
            this.lblSubDSNhaCC.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.lblSubDSNhaCC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnKhoiPhuc);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.lbkTrangThai);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.rtbDiaChiNCC);
            this.groupBox1.Controls.Add(this.txtSDTNCC);
            this.groupBox1.Controls.Add(this.txtEmailNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.lblSubEmail);
            this.groupBox1.Controls.Add(this.lblSubSDT);
            this.groupBox1.Controls.Add(this.lblSubDiaChi);
            this.groupBox1.Controls.Add(this.lblSubTenNCC);
            this.groupBox1.Controls.Add(this.lblSubMaNCC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 494);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 34);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbkTrangThai
            // 
            this.lbkTrangThai.AutoSize = true;
            this.lbkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkTrangThai.Location = new System.Drawing.Point(6, 330);
            this.lbkTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lbkTrangThai.Name = "lbkTrangThai";
            this.lbkTrangThai.Size = new System.Drawing.Size(88, 18);
            this.lbkTrangThai.TabIndex = 54;
            this.lbkTrangThai.Text = "Trạng thái:";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Enabled = false;
            this.chkTrangThai.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkTrangThai.Location = new System.Drawing.Point(137, 333);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(122, 19);
            this.chkTrangThai.TabIndex = 53;
            this.chkTrangThai.Text = "Còn Hoạt Động";
            this.chkTrangThai.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(6, 394);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
            this.btnCapNhat.TabIndex = 52;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(332, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // rtbDiaChiNCC
            // 
            this.rtbDiaChiNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDiaChiNCC.Location = new System.Drawing.Point(137, 195);
            this.rtbDiaChiNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.rtbDiaChiNCC.Name = "rtbDiaChiNCC";
            this.rtbDiaChiNCC.Size = new System.Drawing.Size(296, 119);
            this.rtbDiaChiNCC.TabIndex = 9;
            this.rtbDiaChiNCC.Text = "";
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDTNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNCC.Location = new System.Drawing.Point(138, 155);
            this.txtSDTNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(295, 24);
            this.txtSDTNCC.TabIndex = 8;
            this.txtSDTNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTNCC_KeyPress);
            // 
            // txtEmailNCC
            // 
            this.txtEmailNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNCC.Location = new System.Drawing.Point(138, 116);
            this.txtEmailNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txtEmailNCC.Name = "txtEmailNCC";
            this.txtEmailNCC.Size = new System.Drawing.Size(295, 24);
            this.txtEmailNCC.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(138, 76);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(295, 24);
            this.txtTenNCC.TabIndex = 6;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(138, 40);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(295, 24);
            this.txtMaNCC.TabIndex = 5;
            // 
            // lblSubEmail
            // 
            this.lblSubEmail.AutoSize = true;
            this.lblSubEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubEmail.Location = new System.Drawing.Point(6, 116);
            this.lblSubEmail.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lblSubEmail.Name = "lblSubEmail";
            this.lblSubEmail.Size = new System.Drawing.Size(55, 18);
            this.lblSubEmail.TabIndex = 4;
            this.lblSubEmail.Text = "Email:";
            // 
            // lblSubSDT
            // 
            this.lblSubSDT.AutoSize = true;
            this.lblSubSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubSDT.Location = new System.Drawing.Point(6, 155);
            this.lblSubSDT.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lblSubSDT.Name = "lblSubSDT";
            this.lblSubSDT.Size = new System.Drawing.Size(112, 18);
            this.lblSubSDT.TabIndex = 3;
            this.lblSubSDT.Text = "Số điện thoại:";
            // 
            // lblSubDiaChi
            // 
            this.lblSubDiaChi.AutoSize = true;
            this.lblSubDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubDiaChi.Location = new System.Drawing.Point(6, 195);
            this.lblSubDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lblSubDiaChi.Name = "lblSubDiaChi";
            this.lblSubDiaChi.Size = new System.Drawing.Size(65, 18);
            this.lblSubDiaChi.TabIndex = 2;
            this.lblSubDiaChi.Text = "Địa chỉ:";
            // 
            // lblSubTenNCC
            // 
            this.lblSubTenNCC.AutoSize = true;
            this.lblSubTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTenNCC.Location = new System.Drawing.Point(3, 79);
            this.lblSubTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lblSubTenNCC.Name = "lblSubTenNCC";
            this.lblSubTenNCC.Size = new System.Drawing.Size(82, 18);
            this.lblSubTenNCC.TabIndex = 1;
            this.lblSubTenNCC.Text = "Tên NCC:";
            // 
            // lblSubMaNCC
            // 
            this.lblSubMaNCC.AutoSize = true;
            this.lblSubMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMaNCC.Location = new System.Drawing.Point(6, 40);
            this.lblSubMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.lblSubMaNCC.Name = "lblSubMaNCC";
            this.lblSubMaNCC.Size = new System.Drawing.Size(77, 18);
            this.lblSubMaNCC.TabIndex = 0;
            this.lblSubMaNCC.Text = "Mã NCC:";
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
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(171, 394);
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
            this.btnKhoiPhuc.Location = new System.Drawing.Point(171, 394);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(108, 34);
            this.btnKhoiPhuc.TabIndex = 73;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Width = 130;
            // 
            // colTenNCC
            // 
            this.colTenNCC.DataPropertyName = "TenNhaCC";
            this.colTenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.ReadOnly = true;
            this.colTenNCC.Width = 170;
            // 
            // colDiaChiNCC
            // 
            this.colDiaChiNCC.DataPropertyName = "DiaChiNCC";
            this.colDiaChiNCC.HeaderText = "Địa Chỉ";
            this.colDiaChiNCC.Name = "colDiaChiNCC";
            this.colDiaChiNCC.ReadOnly = true;
            this.colDiaChiNCC.Width = 170;
            // 
            // colSDTNCC
            // 
            this.colSDTNCC.DataPropertyName = "SDTNCC";
            this.colSDTNCC.HeaderText = "Số Điện Thoại";
            this.colSDTNCC.Name = "colSDTNCC";
            this.colSDTNCC.ReadOnly = true;
            this.colSDTNCC.Width = 150;
            // 
            // colEmailNCC
            // 
            this.colEmailNCC.DataPropertyName = "EmailNCC";
            this.colEmailNCC.HeaderText = "Email";
            this.colEmailNCC.Name = "colEmailNCC";
            this.colEmailNCC.ReadOnly = true;
            this.colEmailNCC.Width = 130;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Còn Tồn Tại";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhaCC";
            this.Text = "frmNhaCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhaCC_FormClosed);
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhaCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RichTextBox rtbDiaChiNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtEmailNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblSubEmail;
        private System.Windows.Forms.Label lblSubSDT;
        private System.Windows.Forms.Label lblSubDiaChi;
        private System.Windows.Forms.Label lblSubTenNCC;
        private System.Windows.Forms.Label lblSubMaNCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiemNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDSNhaCC;
        private System.Windows.Forms.Label lblSubDSNhaCC;
        private System.Windows.Forms.Label lbkTrangThai;
        private MetroFramework.Controls.MetroCheckBox chkTrangThai;
        private MetroFramework.Controls.MetroCheckBox chkNhaCungCap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailNCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
    }
}