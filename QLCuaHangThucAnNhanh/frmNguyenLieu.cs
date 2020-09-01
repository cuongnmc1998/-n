using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmNguyenLieu : Form
    {
        private static frmNguyenLieu _Instance = null;
        private NguyenLieuDTO nl = null;
        frmLoaiNguyenLieu _frmLoaiNL;
        frmNhaCC _frmNhaCC;
        private int _staTus;
        private string _tenTK;
        public frmNguyenLieu()
        {
            InitializeComponent();
        }
        public frmNguyenLieu(string tenTK, int staTus) : this()
        {
            this._tenTK = tenTK;
            this._staTus = staTus;
        }
        public static frmNguyenLieu Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmNguyenLieu();
                }
                return _Instance;
            }
        }

        private void frmNguyenLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            
            chkTrangThai.Checked = true;
            dgvDSNguyenLieu.AutoGenerateColumns = false;
            txtMaNL.Enabled = false;
            DataGridViewComboBoxColumn dgvcolNL = (DataGridViewComboBoxColumn)dgvDSNguyenLieu.Columns["colLoaiNL"];
            DataTable dtNguyenLieu = LoaiNguyenLieuBUS.LoadDSLoaiNguyenLieu();
            // Đỗ dữ liệu cho cbo trong dgv
            dgvcolNL.DataSource = dtNguyenLieu;
            dgvcolNL.DisplayMember = "TenLoaiNL";
            dgvcolNL.ValueMember = "MaLoaiNL";
            // Đỗ dữ liệu cho cbo LoaiNguyenLieu
            cboLoaiNL.DataSource = dtNguyenLieu;
            cboLoaiNL.DisplayMember = "TenLoaiNL";
            cboLoaiNL.ValueMember = "MaLoaiNL";
            
            DataGridViewComboBoxColumn dgvcolNCC = (DataGridViewComboBoxColumn)dgvDSNguyenLieu.Columns["colNhaCungCap"];
            DataTable dtNhaCungCap = NhaCungCapBUS.LayDSNhaCungCap();
            // Đỗ dữ liệu cho cbo trong dgv
            dgvcolNCC.DataSource = dtNhaCungCap;
            dgvcolNCC.DisplayMember = "TenNhaCC";
            dgvcolNCC.ValueMember = "MaNCC";
            // Đỗ dữ liệu cho cbo NhaCungCap
            cboNhaCC.DataSource = dtNhaCungCap;
            cboNhaCC.DisplayMember = "TenNhaCC";
            cboNhaCC.ValueMember = "MaNCC";

            LoadDSNguyenLieu();
            AddStatus(1);
            RefeshForm();
            
        }
        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //_staTus = 0 tắt form ko mở form nào hết
            //_staTus = 1 tắt form mở form hóa đơn nhập
            if (_staTus == 0)
            {
                ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true; this.Close();
            }
                
            else if (_staTus != 0)
            {
                ((frmMain)(this.ParentForm)).Controls["pnlDasboard"].Visible = true;
                this.FormClosing += FrmNguyenLieu_FormClosing;
                this.Close();
            }
            
        }

        private void FrmNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_staTus == 1)
            {
                frmHoaDonNhap frm = new frmHoaDonNhap(_tenTK);
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else if(_staTus == 2)
            {
                frmHoaDonXuat frm = new frmHoaDonXuat(_tenTK);
                frm.MdiParent = this.MdiParent;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void dgvDSNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNguyenLieu.SelectedRows.Count > 0)
            {               
                DataGridViewRow dgvRow = dgvDSNguyenLieu.CurrentRow;
                txtMaNL.Text = dgvRow.Cells["colMaNL"].Value.ToString();
                txtTenNL.Text = dgvRow.Cells["colTenNL"].Value.ToString();
                cboDonViTinh.SelectedValue = dgvRow.Cells["colDonViTinh"].Value.ToString();
                if (dgvRow.Cells["colDonViTinh"].Value.ToString() == "kg")
                {
                    cboDonViTinh.SelectedItem = "kg";
                }
                else if (dgvRow.Cells["colDonViTinh"].Value.ToString() == "gram")
                {
                    cboDonViTinh.SelectedItem = "gram";
                }
                else cboDonViTinh.SelectedItem = "quả";
                txtDonGia.Text = dgvRow.Cells["colDonGia"].Value.ToString();
                txtSLTonKho.Text = dgvRow.Cells["colSLTK"].Value.ToString();
                cboLoaiNL.SelectedValue = dgvRow.Cells["colLoaiNL"].Value.ToString();
                cboNhaCC.SelectedValue = dgvRow.Cells["colNhaCungCap"].Value.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(dgvRow.Cells["colTrangThai"].Value.ToString());
                if(chkTrangThai.Checked == true)
                {
                    AddStatus(-1);
                }
                else
                {
                    AddStatus(0);
                }
                
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(nl == null)
            {
                if (!RegexForm())
                {
                    return;
                }
                else
                {
                    GetInfoResultNguyenLieu();
                    if (NguyenLieuBUS.ThemNguyenLieu(nl))
                    {
                        //MessageBox.Show("Thêm nguyên liệu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSNguyenLieu();
                        LamMoi();
                        AddStatus(1);
                    }
                    else
                    {
                        MessageBox.Show("Mã nguyên liệu không được phép trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nl = null;
                    }
                }    
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!RegexForm())
            {
                return;
            }
            else
            {
                GetInfoResultNguyenLieu();
                if (nl != null)
                {
                    if (NguyenLieuBUS.CapNhatNguyenLieu(nl))
                    {
                        //MessageBox.Show("Cập nhật nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSNguyenLieu();
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu nguyên liệu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }      
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!RegexForm())
            {
                return;
            }
            else
            {
                GetInfoResultNguyenLieu();
                if (nl != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        RegexForm();
                        if (NguyenLieuBUS.XoaNguyenLieu(nl.MaNL))
                        {
                            //MessageBox.Show("Xóa nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LoadDSNguyenLieu();
                            LamMoi();
                            AddStatus(1);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LoadDSNguyenLieu();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu nguyên liệu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNguyenLieu();
                }
            }
            
        }

        private void txtTimKiemNL_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnAddLoaiNL_Click(object sender, EventArgs e)
        {
            _frmLoaiNL = new frmLoaiNguyenLieu(_tenTK, 1);
            _frmLoaiNL.MdiParent = this.MdiParent;
            _frmLoaiNL.Dock = DockStyle.Fill;
            _frmLoaiNL.Show();
            this.Hide();
        } 

        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            _frmNhaCC = new frmNhaCC(_tenTK, 1);
            _frmNhaCC.MdiParent = this.MdiParent;
            _frmNhaCC.Dock = DockStyle.Fill;
            _frmNhaCC.Show();
            this.Hide();
        }

        private void frmNguyenLieu_Activated(object sender, EventArgs e)
        {
            cboLoaiNL.DataSource = LoaiNguyenLieuBUS.LoadDSLoaiNguyenLieu();
            cboLoaiNL.DisplayMember = "TenLoaiNL";
            cboLoaiNL.ValueMember = "MaLoaiNL";

            cboNhaCC.DataSource = NhaCungCapBUS.LayDSNhaCungCap();
            cboNhaCC.DisplayMember = "TenNhaCC";
            cboNhaCC.ValueMember = "MaNCC";
        }

        private void chkNLConSuDung_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSNguyenLieu();
            OnlyReadResetStatus();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (chkNLConSuDung.Checked == true)
            {
                try
                {
                    GetInfoResultNguyenLieu();
                    if (nl != null)
                    {
                        if (NguyenLieuBUS.KhoiPhucTrangThaiNguyenLieu(nl))
                        {
                            //MessageBox.Show("Khôi phục trạng thái nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LoadDSNguyenLieu();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Khôi phục trạng thái nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }             
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSLTonKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        #region Functions
        void LoadDSNguyenLieu()
        {      
            if (chkNLConSuDung.Checked == false)
            {
                dgvDSNguyenLieu.DataSource = NguyenLieuBUS.LoadDSNguyenLieu();
                AddStatus(1);
                btnXoa.Show();
                btnLamMoi.Show();
            }
            else
            {
                dgvDSNguyenLieu.DataSource = NguyenLieuBUS.LoadDSNguyenLieuKhongConSuDung();
                AddStatus(0);
                RefeshForm();
                txtMaNL.Clear();
                chkTrangThai.Checked = false;
                cboDonViTinh.SelectedIndex = -1;
            }
            dgvDSNguyenLieu.CurrentCell = null;
        }

        void GetInfoResultNguyenLieu()
        {
            if (nl == null)
            {
                nl = new NguyenLieuDTO();
            }
            nl.MaNL = txtMaNL.Text;
            nl.TenNL = txtTenNL.Text;
            nl.DonViTinh = cboDonViTinh.SelectedItem.ToString();
            nl.DonGia = Convert.ToInt32(txtDonGia.Text);
            nl.SoLuongTonKho = Convert.ToInt32(txtSLTonKho.Text);
            nl.MaLoaiNL = cboLoaiNL.SelectedValue.ToString();
            nl.MaNCC = cboNhaCC.SelectedValue.ToString();
            nl.TrangThai = chkTrangThai.Checked;
        }

        void RefeshForm()
        {
            txtMaNL.Text = NguyenLieuBUS.LayMaNLLonNhat();
            txtTenNL.Clear();
            txtDonGia.Clear();
            txtSLTonKho.Clear();
            cboDonViTinh.SelectedValue = -1;
            cboLoaiNL.SelectedValue = -1;
            cboNhaCC.SelectedValue = -1;
            chkTrangThai.Checked = true;
        }  

        void AddStatus(int k)
        {
            if (k == 1)
            {
                bool t = true;
                btnThem.Enabled = t;
                btnThem.Show();
                btnCapNhat.Enabled = btnXoa.Enabled = !t;
                btnCapNhat.Hide();
            }
            else if(k == -1)
            {
                bool t = false;
                btnCapNhat.Enabled = btnXoa.Enabled = !t;
                btnCapNhat.Show();
                btnThem.Enabled = !t;
                btnThem.Hide();
            }
            else
            {
                bool t = true;
                btnThem.Hide();
                btnCapNhat.Hide();
                btnLamMoi.Hide();
                btnXoa.Hide();
                btnKhoiPhuc.Show();
                if (dgvDSNguyenLieu.Rows.Count > 0)
                {
                    btnKhoiPhuc.Enabled = t;
                }
                else
                    btnKhoiPhuc.Enabled = !t;
            }
        }

        bool RegexForm()
        {
            int donGia = 0;
            int sltk = 0;
            if (txtTenNL.Text == "" || txtDonGia.Text == "" || txtSLTonKho.Text == "" ||cboLoaiNL.SelectedValue.ToString() == "" || cboNhaCC.SelectedValue.ToString() == "" || string.IsNullOrEmpty(cboDonViTinh.Text) || chkTrangThai.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(this.txtDonGia.Text, out donGia) || !int.TryParse(this.txtSLTonKho.Text, out sltk))
            {
                MessageBox.Show("Đơn giá và số lượng tồn kho phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;

        }

        void TimKiem()
        {
            if(txtTimKiemNL.Text != "")
            {
                dgvDSNguyenLieu.DataSource = NguyenLieuBUS.TimKiemTheoTenNguyenLieu(txtTimKiemNL.Text);
                AddStatus(1);
            }
            else
            {
                LoadDSNguyenLieu();
                AddStatus(1);
            }
        }

        void LamMoi()
        {
            RefeshForm();
            AddStatus(1);
            nl = null;
        }

        void OnlyReadResetStatus()
        {
            if(chkNLConSuDung.Checked == true)
            {
                txtTenNL.Enabled = txtDonGia.Enabled = txtSLTonKho.Enabled = false;
                cboDonViTinh.Enabled = cboLoaiNL.Enabled = cboNhaCC.Enabled = false;
                chkTrangThai.Enabled = false;
                
            }
            else
            {
                txtTenNL.Enabled = txtDonGia.Enabled = txtSLTonKho.Enabled = true;
                cboDonViTinh.Enabled = cboLoaiNL.Enabled = cboNhaCC.Enabled = true;
                chkTrangThai.Enabled = true;
                LamMoi();
            }
        }

        #endregion

        #region Setting

        #endregion
    }
}
