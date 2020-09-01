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
    public partial class frmLoaiNguyenLieu : Form
    {
        private static frmLoaiNguyenLieu _Instance = null;
        private LoaiNguyenLieuDTO loaiNL = null;
        private string _tenTK;
        private int _staTus;
        public frmLoaiNguyenLieu()
        {
            InitializeComponent();
        }
        public frmLoaiNguyenLieu(string tenTK, int staTus) : this()
        {
            this._tenTK = tenTK;
            this._staTus = staTus;
        }
        public static frmLoaiNguyenLieu Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmLoaiNguyenLieu();
                }
                return _Instance;
            }
        }

        private void frmLoaiNguyenLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            chkTrangThai.Checked = true;
            txtMaLoaiNL.Enabled = false;
            dgvDSLoaiNL.AutoGenerateColumns = false;
            LoadDSLoaiNguyenLieu();
            AddStatus(1);
            RefeshForm();
        }

        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //_staTus = 0 tắt form ko mở form nào hết
            //_staTus = 1 tắt form mở form nguyên liệu
            if (_staTus == 0)
            {
                ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
                this.Close();
            }
               
            else if (_staTus == 1)
            {
                this.FormClosing += FrmLoaiNguyenLieu_FormClosing;
                this.Close();
            }
        }

        private void FrmLoaiNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmNguyenLieu frm = new frmNguyenLieu(_tenTK, 0);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void dgvDSLoaiNL_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSLoaiNL.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvDSLoaiNL.CurrentRow;
                txtMaLoaiNL.Text = dgvRow.Cells["colLoaiNL"].Value.ToString();
                txtTenLoaiNL.Text = dgvRow.Cells["colTenLoaiNL"].Value.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(dgvRow.Cells["colTrangThai"].Value);
                if (chkTrangThai.Checked == true)
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
            if (loaiNL == null)
            {
                if (!RegexForm())
                {
                    return;
                }
                else
                {
                    GetInfoResultLoaiNguyenLieu();
                    if (LoaiNguyenLieuBUS.ThemLoaiNguyenLieu(loaiNL))
                    {
                        //MessageBox.Show("Thêm loại nguyên liệu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSLoaiNguyenLieu();
                        RefeshForm();
                        AddStatus(1);
                    }
                    else
                    {
                        MessageBox.Show("Mã loại nguyên liệu không được phép trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loaiNL = null;
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
                GetInfoResultLoaiNguyenLieu();
                if (loaiNL != null)
                {
                    RegexForm();
                    if (LoaiNguyenLieuBUS.CapNhatLoaiNguyenLieu(loaiNL))
                    {
                        //MessageBox.Show("Cập nhật loại nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSLoaiNguyenLieu();
                        RefeshForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật loại nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu loại nguyên liệu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GetInfoResultLoaiNguyenLieu();
                if (loaiNL != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa loại nguyên liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        RegexForm();
                        if (LoaiNguyenLieuBUS.XoaLoaiNguyenLieu(loaiNL.MaLoaiNL))
                        {
                            //MessageBox.Show("Xóa loại nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LoadDSLoaiNguyenLieu();
                            RefeshForm();
                            AddStatus(1);
                        }
                        else
                        {
                            MessageBox.Show("Xóa loại nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LoadDSLoaiNguyenLieu();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu loại nguyên liệu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSLoaiNguyenLieu();
                }
            }
            
        }

        private void txtTimKiemLoaiNL_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (chkNLConSuDung.Checked == true)
            {
                GetInfoResultLoaiNguyenLieu();
                if (loaiNL != null)
                {
                    if (LoaiNguyenLieuBUS.KhoiPhucTrangThaiNguyenLieu(loaiNL))
                    {
                        //MessageBox.Show("Khôi phục trạng thái loại nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSLoaiNguyenLieu();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục trạng thái loại nguyên liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void chkNLConSuDung_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSLoaiNguyenLieu();
            OnlyReadResetStatus();
        }
        #endregion

        #region Functions
        void LoadDSLoaiNguyenLieu()
        {
            if (chkNLConSuDung.Checked == false)
            {
                dgvDSLoaiNL.DataSource = LoaiNguyenLieuBUS.LoadDSLoaiNguyenLieu();
                AddStatus(1);
                btnXoa.Show();
                btnLamMoi.Show();
            }
            else
            {
                dgvDSLoaiNL.DataSource = LoaiNguyenLieuBUS.LayDSLoaiNguyenLieuKhongConSuDung();
                AddStatus(0);
                txtMaLoaiNL.Clear();
                txtTenLoaiNL.Clear();
                chkTrangThai.Checked = false;
            }
            dgvDSLoaiNL.CurrentCell = null;
        }

        void GetInfoResultLoaiNguyenLieu()
        {
            if (loaiNL == null)
            {
                loaiNL = new LoaiNguyenLieuDTO();
            }
            loaiNL.MaLoaiNL = txtMaLoaiNL.Text;
            loaiNL.TenLoaiNL = txtTenLoaiNL.Text;
            loaiNL.TrangThai = chkTrangThai.Checked;
        }

        void RefeshForm()
        {
            txtMaLoaiNL.Text = LoaiNguyenLieuBUS.LayMaLoaiNLLonNhat();
            txtTenLoaiNL.Clear();
            chkTrangThai.Checked = true;
        }

        bool RegexForm()
        {
            if (txtMaLoaiNL.Text == "" || txtTenLoaiNL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin loại nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            else if (k == -1)
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
                if (dgvDSLoaiNL.Rows.Count > 0)
                {
                    btnKhoiPhuc.Enabled = t;
                }
                else
                    btnKhoiPhuc.Enabled = !t;                
            }
        }

        void TimKiem()
        {
            if (txtTimKiemLoaiNL.Text != "")
            {
                dgvDSLoaiNL.DataSource = LoaiNguyenLieuBUS.TimKiemTheoTenLoaiNguyenLieu(txtTimKiemLoaiNL.Text);
                AddStatus(1);
            }
            else
            {
                LoadDSLoaiNguyenLieu();
                AddStatus(1);
            }
        }

        void LamMoi()
        {
            RefeshForm();
            AddStatus(1);
            loaiNL = null;
        }

        void OnlyReadResetStatus()
        {
            if (chkNLConSuDung.Checked == true)
            {
                txtTenLoaiNL.Enabled = false;
                chkTrangThai.Enabled = false;
            }
            else
            {
                txtTenLoaiNL.Enabled = true;
                chkTrangThai.Enabled = true;
                LamMoi();
            }
        }

        #endregion


    }
}
