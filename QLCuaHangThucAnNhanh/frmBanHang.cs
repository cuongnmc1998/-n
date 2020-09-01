using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QLCuaHangThucAnNhanh
{
    public partial class frmBanHang : Form
    {
        private HDBanHangDTO _hdBH;
        private static frmBanHang _Instance = null;
        public frmBanHang()
        {
            InitializeComponent();
        }
        public frmBanHang(HDBanHangDTO hdBH): this()
        {
            this._hdBH = hdBH;
        }
        
        public static frmBanHang Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmBanHang();
                }
                return _Instance;
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadHDVaoThongTinHD();
            LoadDSCTHD();
        }

        #region Events
        private void txtTienCuaKH_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int tienKH = int.Parse(txtTienCuaKH.Text.Replace(",", ""));
            //    txtTienCuaKH.Text = tienKH.ToString("0,00.##");
            //    txtTienCuaKH.Select(txtTienCuaKH.TextLength, 0);

                
            //}
            //catch (Exception ex)
            //{
                
            //}

            if (txtTienCuaKH.Text.Trim() == "")
                lblTienThoiKH.Text = "0 VND";
            else
            {
                int tThoi = (Convert.ToInt32(txtTienCuaKH.Text) - _hdBH.TongTien);
                if (tThoi < 0)
                    lblTienThoiKH.Text = "0 VND";
                else
                    lblTienThoiKH.Text = tThoi.ToString("#,##0 VND");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(FrmBanHang_FormClosed);
            this.Close();
        }

        private void FrmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;

            frmDatMon frmDM = new frmDatMon();
            frmDM.MdiParent = this.MdiParent;
            frmDM.Dock = DockStyle.Fill;

            frmDM.Show();
            frmDM.TaoHDBanHang();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (txtTienCuaKH.Text != "")
            {
                _hdBH.TrangThai = 1;
                _hdBH.TonTai = 1;
                _hdBH.NgayLapHD = DateTime.Now;
                _hdBH.TienCuaKH = Convert.ToInt32(txtTienCuaKH.Text);
                _hdBH.TienThua = Convert.ToInt32(txtTienCuaKH.Text) - _hdBH.TongTien;
                if (HDBanHangBUS.CapNhatHoaDon(_hdBH))
                {
                    MessageBox.Show("Đặt món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                    int tienKH = int.Parse(txtTienCuaKH.Text.Replace(",", ""));
                    string tienCuaKH = String.Format("{0:#,##0}",tienKH);
                    int tienThua = Convert.ToInt32(txtTienCuaKH.Text) - _hdBH.TongTien;
                    string tienThuaKH = String.Format("{0:#,##0}", tienThua);
                    frmBaoCao._tienMat = tienCuaKH;
                    frmBaoCao._tienThua = tienThuaKH;
                    frmBaoCao frmBC = new frmBaoCao();
                    frmBC.HienHDBanHang(_hdBH.MaHD);
                    frmBC.Show();

                    frmDatMon frmDM = new frmDatMon();
                    frmDM.MdiParent = this.MdiParent;
                    frmDM.Dock = DockStyle.Fill;
                    frmDM.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Đặt món thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Mời bạn nhập tiền khách đưa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInPhieuDM_Click(object sender, EventArgs e)
        {
            frmBaoCao frmBC = new frmBaoCao();
            frmBC.HienPhieuDatMon(_hdBH.MaHD);
            frmBC.Show();
        }
        #endregion

        #region Functions
        private void LoadHDVaoThongTinHD()
        {
            lblMaHD.Text = _hdBH.MaHD.ToString();
            lblNguoiLHD.Text = _hdBH.TenTaiKhoan;
            lblNgayLHD.Text = DateTime.Now.ToString();
            lblTongTien.Text = _hdBH.TongTien.ToString("#,##0 VND");
        }

        private void LoadDSCTHD()
        {
            DataGridViewComboBoxColumn cboMon = (DataGridViewComboBoxColumn)dgvCTHDBanHang.Columns["colMaMon"];
            cboMon.DataSource = MonBUS.LayDanhSachMon("");
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "MaMon";

            dgvCTHDBanHang.DataSource = CTHDBanHangBUS.LayDSCTHDBanHang(_hdBH.MaHD);
        }
        #endregion



    }
}
