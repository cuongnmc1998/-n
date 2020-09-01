using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmMain : Form
    {
        private string _tenTK;
        private string _tenNV;
        private int _loaiTK;
        public frmMain()
        {
            InitializeComponent();
            var a = this.PointToScreen(lblTitle.Location);
            a = pictureBox1.PointToClient(a);
            lblTitle.Parent = pictureBox1;
            lblTitle.Location = a;
            lblTitle.BackColor = Color.Transparent;
        }
        public frmMain(string tenTK, string tenNV, int loaiTK) : this()
        {
            _tenTK = tenTK;
            _tenNV = tenNV;
            _loaiTK = loaiTK;
        }
        public string getTenTK()
        {
            return this._tenTK;
        }
        public string GetTenNV()
        {
            return this._tenNV;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTenTaiKhoan.Text = this._tenTK;
            if (_loaiTK == 0)
            {
                mnuBanHang.Enabled = true;
                mnuHoaDon.Enabled = true;
                mnuQuanLy.Enabled = true;
            }
            else if (_loaiTK == 1)
            {
                mnuBanHang.Enabled = true;
                mnuHoaDon.Enabled = true;
                mnuQuanLy.Enabled = true;
                mnuSubDSMon.Enabled = false;
            }
            else if (_loaiTK == 2)
            {
                mnuBanHang.Enabled = true;
                mnuHoaDon.Enabled = true;
                mnuHDNhap.Enabled = false;
                mnuHDXuat.Enabled = false;
                mnuQuanLy.Enabled = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Mdi Children Form
        private void mnuDatMon_Click(object sender, EventArgs e)
        {
            MoFormDatMon();
            pnlDashboard.Hide();
        }

        private void mnuHDBanHang_Click(object sender, EventArgs e)
        {
            MoFormHoaDonBanHang(); pnlDashboard.Hide();
        }

        private void mnuHDNhap_Click(object sender, EventArgs e)
        {
            MoFormHoaDonNhap(); pnlDashboard.Hide();
        }

        private void mnuHDXuat_Click(object sender, EventArgs e)
        {
            MoFormHoaDonXuat(); pnlDashboard.Hide();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            MoFormTaiKhoan(); pnlDashboard.Hide();
        }

        private void mnuDSNhaCC_Click_1(object sender, EventArgs e)
        {
            MoFormNhaCC(); pnlDashboard.Hide();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            MoFormMonAn(); pnlDashboard.Hide();
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            MoFormNguyenLieu(); pnlDashboard.Hide();
        }

        private void mnuLoaiMon_Click(object sender, EventArgs e)
        {
            MoFormLoaiMonAn(); pnlDashboard.Hide();
        }

        private void mnuLoaiNguyenLieu_Click(object sender, EventArgs e)
        {
            MoFormLoaiNguyenLieu(); pnlDashboard.Hide();
        }

        private void mnuBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            MoFormBaoCaoThongKe(); pnlDashboard.Hide();
        }
        #endregion

        #region Functions Create MoForm
        // Kiểm tra Form đã có chưa
        public Form KiemTraFormTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        // MDI frmDatMon
        void MoFormDatMon()
        {
            Form frm = KiemTraFormTonTai(typeof(frmDatMon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmDatMon m_frmDatMon = frmDatMon.Instance;
                m_frmDatMon.MdiParent = this;
                m_frmDatMon.Dock = DockStyle.Fill;
                m_frmDatMon.Show();
            }
        }

        // MDI frmBanHang
        void MoFormBanHang()
        {
            Form frm = KiemTraFormTonTai(typeof(frmBanHang));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBanHang m_frmHoaDonThanhToan = frmBanHang.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }

        }

        // MDI frmHoaDonBanHang
        void MoFormHoaDonBanHang()
        {
            Form frm = KiemTraFormTonTai(typeof(frmHoaDonBanHang));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDonBanHang m_frmHoaDonThanhToan = new frmHoaDonBanHang(_tenTK);
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmHoaDonNhap
        void MoFormHoaDonNhap()
        {
            Form frm = KiemTraFormTonTai(typeof(frmHoaDonNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDonNhap m_frmHoaDonThanhToan = new frmHoaDonNhap(_tenTK);
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmHoaDonXuat
        void MoFormHoaDonXuat()
        {
            Form frm = KiemTraFormTonTai(typeof(frmHoaDonXuat));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHoaDonXuat m_frmHoaDonThanhToan = new frmHoaDonXuat(_tenTK);
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmTaiKhoan
        void MoFormTaiKhoan()
        {
            Form frm = KiemTraFormTonTai(typeof(frmTaiKhoan));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTaiKhoan m_frmHoaDonThanhToan = frmTaiKhoan.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmNhaCungCap
        void MoFormNhaCC()
        {
            Form frm = KiemTraFormTonTai(typeof(frmNhaCC));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhaCC m_frmHoaDonThanhToan = frmNhaCC.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmMonAn
        void MoFormMonAn()
        {
            Form frm = KiemTraFormTonTai(typeof(frmMonAn));
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonAn m_frmHoaDonThanhToan = new frmMonAn(_tenTK);
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmNguyenLieu
        void MoFormNguyenLieu()
        {
            Form frm = KiemTraFormTonTai(typeof(frmNguyenLieu));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNguyenLieu m_frmHoaDonThanhToan = frmNguyenLieu.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmLoaiNguyenLieu
        void MoFormLoaiNguyenLieu()
        {
            Form frm = KiemTraFormTonTai(typeof(frmLoaiNguyenLieu));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoaiNguyenLieu m_frmHoaDonThanhToan = frmLoaiNguyenLieu.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmLoaiMonAn
        void MoFormLoaiMonAn()
        {
            Form frm = KiemTraFormTonTai(typeof(frmLoaiMonAn));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoaiMonAn m_frmHoaDonThanhToan = frmLoaiMonAn.Instance;
                m_frmHoaDonThanhToan.MdiParent = this;
                m_frmHoaDonThanhToan.Dock = DockStyle.Fill;
                m_frmHoaDonThanhToan.Show();
            }
        }

        // MDI frmBaoCaoThongKe
        void MoFormBaoCaoThongKe()
        {
            Form frm = KiemTraFormTonTai(typeof(frmBaoCaoThongKe));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBaoCaoThongKe m_frmThongKe = frmBaoCaoThongKe.Instance;
                m_frmThongKe.MdiParent = this;
                m_frmThongKe.Dock = DockStyle.Fill;
                m_frmThongKe.Show();
            }
        }

        #endregion

    }
}
