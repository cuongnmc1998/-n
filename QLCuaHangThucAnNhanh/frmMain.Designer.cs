namespace QLCuaHangThucAnNhanh
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnbarMain = new System.Windows.Forms.MenuStrip();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubDSMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiNguyenLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblSubTenTK = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnbarMain.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnbarMain
            // 
            resources.ApplyResources(this.mnbarMain, "mnbarMain");
            this.mnbarMain.BackColor = System.Drawing.Color.White;
            this.mnbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanHang,
            this.mnuHoaDon,
            this.mnuQuanLy});
            this.mnbarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnbarMain.Name = "mnbarMain";
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.BackColor = System.Drawing.Color.White;
            this.mnuBanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatMon});
            this.mnuBanHang.ForeColor = System.Drawing.Color.Black;
            this.mnuBanHang.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.icons8_checkout_500;
            resources.ApplyResources(this.mnuBanHang, "mnuBanHang");
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            // 
            // mnuDatMon
            // 
            this.mnuDatMon.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.datmon;
            this.mnuDatMon.Name = "mnuDatMon";
            resources.ApplyResources(this.mnuDatMon, "mnuDatMon");
            this.mnuDatMon.Click += new System.EventHandler(this.mnuDatMon_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDBanHang,
            this.mnuHDNhap,
            this.mnuHDXuat});
            this.mnuHoaDon.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.bill;
            resources.ApplyResources(this.mnuHoaDon, "mnuHoaDon");
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            // 
            // mnuHDBanHang
            // 
            this.mnuHDBanHang.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.invoice_BanHang;
            this.mnuHDBanHang.Name = "mnuHDBanHang";
            resources.ApplyResources(this.mnuHDBanHang, "mnuHDBanHang");
            this.mnuHDBanHang.Click += new System.EventHandler(this.mnuHDBanHang_Click);
            // 
            // mnuHDNhap
            // 
            this.mnuHDNhap.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.invoice_Nhap;
            this.mnuHDNhap.Name = "mnuHDNhap";
            resources.ApplyResources(this.mnuHDNhap, "mnuHDNhap");
            this.mnuHDNhap.Click += new System.EventHandler(this.mnuHDNhap_Click);
            // 
            // mnuHDXuat
            // 
            this.mnuHDXuat.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.invoice_Xuat;
            this.mnuHDXuat.Name = "mnuHDXuat";
            resources.ApplyResources(this.mnuHDXuat, "mnuHDXuat");
            this.mnuHDXuat.Click += new System.EventHandler(this.mnuHDXuat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSTaiKhoan,
            this.mnuSubDSMon,
            this.mnuSubNguyenLieu,
            this.mnuDSNhaCC,
            this.mnuBaoCaoThongKe});
            this.mnuQuanLy.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.Management;
            resources.ApplyResources(this.mnuQuanLy, "mnuQuanLy");
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            // 
            // mnuDSTaiKhoan
            // 
            this.mnuDSTaiKhoan.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.account;
            this.mnuDSTaiKhoan.Name = "mnuDSTaiKhoan";
            resources.ApplyResources(this.mnuDSTaiKhoan, "mnuDSTaiKhoan");
            this.mnuDSTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // mnuSubDSMon
            // 
            this.mnuSubDSMon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMon,
            this.mnuLoaiMon});
            this.mnuSubDSMon.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.menu_monan;
            this.mnuSubDSMon.Name = "mnuSubDSMon";
            resources.ApplyResources(this.mnuSubDSMon, "mnuSubDSMon");
            // 
            // mnuMon
            // 
            this.mnuMon.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.fastfood_monan;
            this.mnuMon.Name = "mnuMon";
            resources.ApplyResources(this.mnuMon, "mnuMon");
            this.mnuMon.Click += new System.EventHandler(this.mnuMon_Click);
            // 
            // mnuLoaiMon
            // 
            this.mnuLoaiMon.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.fastfood_loaimonan;
            this.mnuLoaiMon.Name = "mnuLoaiMon";
            resources.ApplyResources(this.mnuLoaiMon, "mnuLoaiMon");
            this.mnuLoaiMon.Click += new System.EventHandler(this.mnuLoaiMon_Click);
            // 
            // mnuSubNguyenLieu
            // 
            this.mnuSubNguyenLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNguyenLieu,
            this.mnuLoaiNguyenLieu});
            this.mnuSubNguyenLieu.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.groceries_nguyenlieu;
            this.mnuSubNguyenLieu.Name = "mnuSubNguyenLieu";
            resources.ApplyResources(this.mnuSubNguyenLieu, "mnuSubNguyenLieu");
            // 
            // mnuNguyenLieu
            // 
            this.mnuNguyenLieu.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.nguyenlieu;
            this.mnuNguyenLieu.Name = "mnuNguyenLieu";
            resources.ApplyResources(this.mnuNguyenLieu, "mnuNguyenLieu");
            this.mnuNguyenLieu.Click += new System.EventHandler(this.mnuNguyenLieu_Click);
            // 
            // mnuLoaiNguyenLieu
            // 
            this.mnuLoaiNguyenLieu.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.loai_nguyenlieu;
            this.mnuLoaiNguyenLieu.Name = "mnuLoaiNguyenLieu";
            resources.ApplyResources(this.mnuLoaiNguyenLieu, "mnuLoaiNguyenLieu");
            this.mnuLoaiNguyenLieu.Click += new System.EventHandler(this.mnuLoaiNguyenLieu_Click);
            // 
            // mnuDSNhaCC
            // 
            this.mnuDSNhaCC.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.food_supply;
            this.mnuDSNhaCC.Name = "mnuDSNhaCC";
            resources.ApplyResources(this.mnuDSNhaCC, "mnuDSNhaCC");
            this.mnuDSNhaCC.Click += new System.EventHandler(this.mnuDSNhaCC_Click_1);
            // 
            // mnuBaoCaoThongKe
            // 
            this.mnuBaoCaoThongKe.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.bars_chart;
            this.mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            resources.ApplyResources(this.mnuBaoCaoThongKe, "mnuBaoCaoThongKe");
            this.mnuBaoCaoThongKe.Click += new System.EventHandler(this.mnuBaoCaoThongKe_Click);
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.BackColor = System.Drawing.Color.LightGray;
            this.metroPanel1.Controls.Add(this.btnThoat);
            this.metroPanel1.Controls.Add(this.btnDangXuat);
            this.metroPanel1.Controls.Add(this.lblTenTaiKhoan);
            this.metroPanel1.Controls.Add(this.lblSubTenTK);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.exit_e;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            resources.ApplyResources(this.btnDangXuat, "btnDangXuat");
            this.btnDangXuat.Image = global::QLCuaHangThucAnNhanh.Properties.Resources.DangXuat;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblTenTaiKhoan, "lblTenTaiKhoan");
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            // 
            // lblSubTenTK
            // 
            resources.ApplyResources(this.lblSubTenTK, "lblSubTenTK");
            this.lblSubTenTK.BackColor = System.Drawing.Color.White;
            this.lblSubTenTK.Name = "lblSubTenTK";
            // 
            // pnlDashboard
            // 
            resources.ApplyResources(this.pnlDashboard, "pnlDashboard");
            this.pnlDashboard.Controls.Add(this.lblTitle);
            this.pnlDashboard.Controls.Add(this.pictureBox1);
            this.pnlDashboard.Name = "pnlDashboard";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Name = "lblTitle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mnbarMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnbarMain.ResumeLayout(false);
            this.mnbarMain.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHDBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHDNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHDXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuDSTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuSubDSMon;
        private System.Windows.Forms.ToolStripMenuItem mnuMon;
        private System.Windows.Forms.ToolStripMenuItem mnuSubNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNguyenLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNhaCC;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe;
        private System.Windows.Forms.MenuStrip mnbarMain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblSubTenTK;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiMon;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiNguyenLieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDatMon;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

