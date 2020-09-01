namespace QLCuaHangThucAnNhanh
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblSubLoaiTK = new System.Windows.Forms.Label();
            this.cboLoaiTK = new MetroFramework.Controls.MetroComboBox();
            this.lblSubMatKhau = new System.Windows.Forms.Label();
            this.lblSubTenTK = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.lblCuaHangThucAnNhanh = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDangNhap);
            this.metroPanel1.Controls.Add(this.txtMatKhau);
            this.metroPanel1.Controls.Add(this.lblSubLoaiTK);
            this.metroPanel1.Controls.Add(this.cboLoaiTK);
            this.metroPanel1.Controls.Add(this.lblSubMatKhau);
            this.metroPanel1.Controls.Add(this.lblSubTenTK);
            this.metroPanel1.Controls.Add(this.txtTenTK);
            this.metroPanel1.Controls.Add(this.lblCuaHangThucAnNhanh);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(579, 289);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.DangNhap;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(238, 217);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(141, 45);
            this.btnDangNhap.TabIndex = 33;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(238, 171);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(195, 24);
            this.txtMatKhau.TabIndex = 32;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // lblSubLoaiTK
            // 
            this.lblSubLoaiTK.AutoSize = true;
            this.lblSubLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubLoaiTK.Location = new System.Drawing.Point(113, 101);
            this.lblSubLoaiTK.Name = "lblSubLoaiTK";
            this.lblSubLoaiTK.Size = new System.Drawing.Size(119, 18);
            this.lblSubLoaiTK.TabIndex = 29;
            this.lblSubLoaiTK.Text = "Loại tài khoản:";
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.ItemHeight = 23;
            this.cboLoaiTK.Items.AddRange(new object[] {
            "CHỦ",
            "QUẢN LÝ",
            "CA TRƯỞNG"});
            this.cboLoaiTK.Location = new System.Drawing.Point(238, 101);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(195, 29);
            this.cboLoaiTK.TabIndex = 27;
            this.cboLoaiTK.UseSelectable = true;
            this.cboLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTK_SelectedIndexChanged);
            // 
            // lblSubMatKhau
            // 
            this.lblSubMatKhau.AutoSize = true;
            this.lblSubMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMatKhau.Location = new System.Drawing.Point(113, 171);
            this.lblSubMatKhau.Name = "lblSubMatKhau";
            this.lblSubMatKhau.Size = new System.Drawing.Size(82, 18);
            this.lblSubMatKhau.TabIndex = 26;
            this.lblSubMatKhau.Text = "Mật khẩu:";
            // 
            // lblSubTenTK
            // 
            this.lblSubTenTK.AutoSize = true;
            this.lblSubTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTenTK.Location = new System.Drawing.Point(113, 136);
            this.lblSubTenTK.Name = "lblSubTenTK";
            this.lblSubTenTK.Size = new System.Drawing.Size(115, 18);
            this.lblSubTenTK.TabIndex = 25;
            this.lblSubTenTK.Text = "Tên tài khoản:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(238, 136);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(195, 24);
            this.txtTenTK.TabIndex = 24;
            // 
            // lblCuaHangThucAnNhanh
            // 
            this.lblCuaHangThucAnNhanh.BackColor = System.Drawing.Color.White;
            this.lblCuaHangThucAnNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuaHangThucAnNhanh.Location = new System.Drawing.Point(104, 15);
            this.lblCuaHangThucAnNhanh.Name = "lblCuaHangThucAnNhanh";
            this.lblCuaHangThucAnNhanh.Size = new System.Drawing.Size(347, 71);
            this.lblCuaHangThucAnNhanh.TabIndex = 23;
            this.lblCuaHangThucAnNhanh.Text = "PHẦN MỀM QUẢN LÝ \r\nCỬA HÀNG THỨC ĂN NHANH";
            this.lblCuaHangThucAnNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 289);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblSubLoaiTK;
        private System.Windows.Forms.Label lblSubMatKhau;
        private System.Windows.Forms.Label lblSubTenTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label lblCuaHangThucAnNhanh;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private MetroFramework.Controls.MetroComboBox cboLoaiTK;
    }
}