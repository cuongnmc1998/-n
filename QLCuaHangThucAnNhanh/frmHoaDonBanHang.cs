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
    public partial class frmHoaDonBanHang : Form
    {
        private string _tenTK;
        private static frmHoaDonBanHang _Instance = null;
        private HDBanHangDTO hdBH = null;
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }
        public frmHoaDonBanHang(string tenTK) : this()
        {
            this._tenTK = tenTK;
        }
        public static frmHoaDonBanHang Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmHoaDonBanHang();
                }
                return _Instance;
            }
        }

        private void frmHoaDonThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        //Load DSHD bán hàng
        public void LoadDSHdBanHang()
        {
            
            if (chkTrangThai.Checked)
            {
                dgvDSHDThanhToan.AutoGenerateColumns = false;
                dgvDSHDThanhToan.DataSource = HDBanHangBUS.LayDSHDBanHang(0);
                dgvDSHDThanhToan.CurrentCell = null;
                if (dgvDSHDThanhToan.Rows.Count > 0)
                    AddStatus(-2);
                else
                    AddStatus(1);
            }
            else
            {
                dgvDSHDThanhToan.AutoGenerateColumns = false;
                dgvDSHDThanhToan.DataSource = HDBanHangBUS.LayDSHDBanHang(1);
                dgvDSHDThanhToan.CurrentCell = null;
                if (dgvDSHDThanhToan.Rows.Count > 0)
                    AddStatus(-1);
                else
                    AddStatus(1);
            }

        }

        //Load DSCTHDBanHang theo mã HD
        private void LoadChiTietHD(int maHD)
        {
            //Load món ăn vào column mã món ăn
            DataGridViewComboBoxColumn cboMaMon = (DataGridViewComboBoxColumn)dgvDSCTHDThanhToan.Columns["colMaMon"];
            cboMaMon.DataSource = MonBUS.LayDanhSachMon("");
            cboMaMon.DisplayMember = "TenMon";
            cboMaMon.ValueMember = "MaMon";
            dgvDSCTHDThanhToan.AutoGenerateColumns = false;
            dgvDSCTHDThanhToan.DataSource = CTHDBanHangBUS.LayChiTietHD(maHD);
            dgvDSCTHDThanhToan.CurrentCell = null;
        }

        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadDSHdBanHang();
            dgvDSHDThanhToan.CurrentCell = null;
            AddStatus(1);
        }

        private void dgvDSHDThanhToan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHDThanhToan.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgvDSHDThanhToan.SelectedRows[0].DataBoundItem;
                hdBH = new HDBanHangDTO();
                hdBH.MaHD = Convert.ToInt32(drv[0].ToString());
                hdBH.TonTai = Convert.ToInt32(drv[8]);
                setHDBanHang();
                if (chkTrangThai.Checked)
                    AddStatus(-2);
                else
                    AddStatus(-1);
                LoadChiTietHD(hdBH.MaHD);
            }
            else
                hdBH = null;
            
        }
        private void setHDBanHang()
        {
            lblMaHD.Text = hdBH.MaHD.ToString();
            if (hdBH.TonTai == 0)
                lblTrangThai.Text = "Đã hủy";
            else if (hdBH.TonTai == 1)
                lblTrangThai.Text = "Tồn tại";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHDThanhToan.Rows.Count > 0)
            {
                if (hdBH != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa hóa đơn này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        frmGhiChuHDBanHang frmGhiChu = new frmGhiChuHDBanHang(hdBH.MaHD, 0);
                        this.MdiParent = this.MdiParent;
                        //this.Hide();
                        frmGhiChu.Show();
                    }
                }
            }
            else
                AddStatus(1);
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSHdBanHang();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(dgvDSHDThanhToan.Rows.Count > 0)
            {
                if(hdBH != null)
                {
                    if (HDBanHangBUS.CapNhatTrangThaiHDBanHang(hdBH.MaHD, 1, ""))
                    {
                        MessageBox.Show("Hóa đơn khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSHdBanHang();
                    }
                }
            }
            else
            {
                AddStatus(1);
            }
        }
        private void AddStatus(int k)
        {
            //Không chọn 1 dòng nào bên HDBanHang
            if(k == 1)
            {
                btnKhoiPhuc.Enabled = false;
                btnXoa.Enabled = false;
            }
            else if(k == -1)//Chọn 1 dòng bên HDBanHang
            {
                btnKhoiPhuc.Enabled = false;
                btnXoa.Enabled = true;
            }
            else if(k == -2)//Chọn 1 dòng bên HDBanHang bên HD bị xóa
            {
                btnKhoiPhuc.Enabled = true;
                btnXoa.Enabled = false;
            }
        }

        private void frmHoaDonBanHang_Activated(object sender, EventArgs e)
        {
            LoadDSHdBanHang();
        }
    }
}
