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
    public partial class frmNhaCC : Form
    {
        private static frmNhaCC _Instance = null;
        private NhaCungCapDTO nccDTO;
        private string _tenTK;
        private int _staTus;
        public frmNhaCC()
        {
            InitializeComponent();
        }
        public frmNhaCC(string tenTK) : this()
        {
            this._tenTK = tenTK;
        }
        public static frmNhaCC Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmNhaCC();
                }
                return _Instance;
            }
        }
        public frmNhaCC(string tenTK, int staTus) : this()
        {
            this._tenTK = tenTK;
            this._staTus = staTus;
        }
        private void frmNhaCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            XuLyAnHienButton(true);
            LoadDSNhaCungCap();
        }
        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            //_staTus = 0 tắt form ko mở form nào hết
            if (_staTus != 0)
            {
                this.FormClosing += FrmNhaCC_FormClosing;
            }
            this.Close();

        }

        private void FrmNhaCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_staTus = 1 tắt form mở form nguyên liệu
            //_staTus = 2 tắt form mở form hóa đơn nhập
            if (_staTus == 1)
            {
                frmNguyenLieu frm = new frmNguyenLieu(_tenTK, 0);
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else if (_staTus == 2)
            {
                frmHoaDonNhap frm = new frmHoaDonNhap(_tenTK);
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XuLyAnHienButton(true);
            nccDTO = null;
            string maNCC = NhaCungCapBUS.LayMaxMaNCC();
            txtMaNCC.Text = maNCC;
            DuaDuLieuChoThongTinNCC();
        }

        private void dgvDSNhaCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNhaCC.SelectedRows.Count > 0)
            {
                XuLyAnHienButton(false);
                if (chkNhaCungCap.Checked)
                {
                    btnKhoiPhuc.Visible = true;
                    btnCapNhat.Visible = false;
                    btnXoa.Visible = false;
                }
                else
                {
                    btnKhoiPhuc.Visible = false;
                    btnXoa.Visible = true;
                }
                DataRowView dr = (DataRowView)dgvDSNhaCC.SelectedRows[0].DataBoundItem;
                nccDTO = new NhaCungCapDTO();
                nccDTO.MaNCC = dr[0].ToString();
                nccDTO.TenNhaCC = dr[1].ToString();
                nccDTO.DiaChiNCC = dr[2].ToString();
                nccDTO.SDTNCC = dr[3].ToString();
                nccDTO.EmailNCC = dr[4].ToString();
                nccDTO.TrangThai = Convert.ToInt32(dr[5]);
                DuaDuLieuChoThongTinNCC();
            }
            else
                nccDTO = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "" || txtTenNCC.Text.Trim() == "" || txtEmailNCC.Text.Trim() == "" || txtSDTNCC.Text == "" || rtbDiaChiNCC.Text.Trim() == "")
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                GanGiaTriChoNCC();
                if (NhaCungCapBUS.ThemNhaCungCap(nccDTO))
                {
                    //MessageBox.Show("Tạo nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LoadDSNhaCungCap();
                }
                else
                    MessageBox.Show("Tạo nhà cung cấp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (nccDTO != null)
            {
                GanGiaTriChoNCC();
                if (NhaCungCapBUS.CapNhatNhaCungCap(nccDTO))
                {
                    //MessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LoadDSNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nccDTO != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (NhaCungCapBUS.CapNhatTrangThai(nccDTO.MaNCC, 0))
                    {
                        //MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSNhaCungCap();
                    }
                    else
                        MessageBox.Show("Xóa nhà cung cấp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkNhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhaCungCap.Checked)
            {
                XoaForm();
                btnCapNhat.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnLamMoi.Visible = false;
                btnKhoiPhuc.Visible = true;
                txtTenNCC.Enabled = txtEmailNCC.Enabled = txtSDTNCC.Enabled = rtbDiaChiNCC.Enabled = false;
                dgvDSNhaCC.DataSource = NhaCungCapBUS.LayDSNhaCungCapBiXoa();
                if (dgvDSNhaCC.Rows.Count > 0)
                {
                    btnKhoiPhuc.Enabled = true;
                }
                else
                {
                    btnKhoiPhuc.Enabled = false;
                }
            }
            else
            {
                txtTenNCC.Enabled = txtEmailNCC.Enabled = txtSDTNCC.Enabled = rtbDiaChiNCC.Enabled = true;
                btnKhoiPhuc.Visible = false;
                btnLamMoi.Visible = true;
                LoadDSNhaCungCap();
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (nccDTO != null)
            {
                if (NhaCungCapBUS.CapNhatTrangThai(nccDTO.MaNCC, 1))
                {
                    //MessageBox.Show("Khôi phục nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    dgvDSNhaCC.DataSource = NhaCungCapBUS.LayDSNhaCungCapBiXoa();
                }
                else
                    MessageBox.Show("Khôi phục nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để kkhôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNCC.Text == "")
            {
                LoadDSNhaCungCap();
            }
            else
            {
                string tKiem = "%" + txtTimKiemNCC.Text + "%";
                dgvDSNhaCC.DataSource = NhaCungCapBUS.TimKiemNCC(tKiem);
            }
        }

        private void txtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Functions
        private void LoadDSNhaCungCap()
        {
            dgvDSNhaCC.AutoGenerateColumns = false;
            dgvDSNhaCC.DataSource = NhaCungCapBUS.LayDSNhaCungCap();
            dgvDSNhaCC.ClearSelection();
        }

        private void DuaDuLieuChoThongTinNCC()
        {
            if (nccDTO != null)
            {
                txtMaNCC.Text = nccDTO.MaNCC;
                txtTenNCC.Text = nccDTO.TenNhaCC;
                txtEmailNCC.Text = nccDTO.EmailNCC;
                txtSDTNCC.Text = nccDTO.SDTNCC;
                rtbDiaChiNCC.Text = nccDTO.DiaChiNCC;
                chkTrangThai.Checked = (nccDTO.TrangThai == 1) ? true : false;
            }
            else
            {
                txtTenNCC.Text = txtEmailNCC.Text = txtSDTNCC.Text = string.Empty;
                rtbDiaChiNCC.Text = string.Empty;
                chkTrangThai.Checked = true;
            }
        }

        private void XuLyAnHienButton(bool chk)
        {
            btnThem.Visible = chk; 
            btnCapNhat.Visible = !chk;
            btnXoa.Enabled = !chk;
            chkTrangThai.Enabled = chk;
        }

        private void GanGiaTriChoNCC()
        {
            if (nccDTO == null)
            {
                nccDTO = new NhaCungCapDTO();
            }
            nccDTO.MaNCC = txtMaNCC.Text;
            nccDTO.TenNhaCC = txtTenNCC.Text;
            nccDTO.DiaChiNCC = rtbDiaChiNCC.Text;
            nccDTO.SDTNCC = txtSDTNCC.Text;
            nccDTO.EmailNCC = txtEmailNCC.Text;
            nccDTO.TrangThai = (chkTrangThai.Checked) ? 1 : 0;
        }

        void XoaForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtEmailNCC.Clear();
            txtSDTNCC.Clear();
            rtbDiaChiNCC.Clear();
            chkTrangThai.Checked = false;
        }
        #endregion
    }
}
