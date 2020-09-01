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
namespace QLCuaHangThucAnNhanh
{
    public partial class frmLoaiMonAn : Form
    {
        private static frmLoaiMonAn _Instance = null;
        private frmLoaiMonAn loaiMon = null;
        private string _tenTK;
        private int _staTus;
        public frmLoaiMonAn()
        {
            InitializeComponent();
        }
        public frmLoaiMonAn(string tenTK, int staTus): this()
        {
            this._tenTK = tenTK;
            this._staTus = staTus;
        }
        public static frmLoaiMonAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmLoaiMonAn();
                }
                return _Instance;
            }
        }

        private void frmLoaiMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
              
        private void frmLoaiMonAn_Load(object sender, EventArgs e)
        {
            txtMaLoaiMon.Enabled = false;
            chkTrangThai.Checked = true;
            dgvDSLoaiMon.AutoGenerateColumns = false;
            LoadDSLoaiMon();
            LamMoi();
            XoaForm(true);
        }
        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //_staTus = 0 tắt form ko mở form nào hết
            //_staTus = 1 tắt form mở form món ăn
            if (_staTus == 0)
            {
                ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
                this.Close();
            }
                
            else if (_staTus == 1)
            {
                this.FormClosing += FrmLoaiMonAn_FormClosing;
                this.Close();
            }
        }

        private void FrmLoaiMonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMonAn frm = new frmMonAn(_tenTK);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void dgvDSLoaiMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSLoaiMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSLoaiMon.CurrentRow;
                txtMaLoaiMon.Text = row.Cells["colMaLoaiMon"].Value.ToString();
                txtTenLoaiMon.Text = row.Cells["colTenLoaiMon"].Value.ToString();
                chkTrangThai.Checked = Convert.ToBoolean(row.Cells["colTrangThai"].Value);
                LamMoi(false);
                if(chkLoaiMAConSuDung.Checked == true)
                {
                    btnCapNhat.Hide();
                    btnThem.Hide();
                    btnXoa.Hide();
                    btnLamMoi.Hide();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi(true);
            XoaForm(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (loaiMon == null)
            {
                if (txtTenLoaiMon.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin loại món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    LoaiMonDTO loaiMon = new LoaiMonDTO();
                    loaiMon.MaLoaiMon = txtMaLoaiMon.Text;
                    loaiMon.TenLoaiMon = txtTenLoaiMon.Text;
                    loaiMon.TrangThai = chkTrangThai.Checked;

                    if (LoaiMonBUS.ThemLoaiMon(loaiMon))
                    {
                        //MessageBox.Show("Thêm loại món ăn mới thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
                        LamMoi();
                        LoadDSLoaiMon();
                        XoaForm(true);
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loaiMon = null;
                    }
                }
               
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin loại món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LoaiMonDTO loaiMon = new LoaiMonDTO();
                loaiMon.MaLoaiMon = txtMaLoaiMon.Text;
                loaiMon.TenLoaiMon = txtTenLoaiMon.Text;
                loaiMon.TrangThai = chkTrangThai.Checked;
                if (LoaiMonBUS.SuaLoaiMon(loaiMon))
                {
                    //MessageBox.Show("Cập nhật loại món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LamMoi();
                    LoadDSLoaiMon();
                    XoaForm(true);
                }
                else
                {
                    MessageBox.Show("Cập nhật loại món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loaiMon = null;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiMon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin loại món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa loại nguyên liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string maLoaiMon = txtMaLoaiMon.Text;
                    if (LoaiMonBUS.XoaLoaiMon(maLoaiMon))
                    {
                        //MessageBox.Show("Xóa loại món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSLoaiMon();
                        LamMoi();
                        XoaForm(true);
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }       
        }

        private void txtTimKiemLM_TextChanged(object sender, EventArgs e)
        {
            LoadDSLoaiMon(txtTimKiemLM.Text);
        }

        private void chkLoaiMAConSuDung_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSLoaiMon();
            OnlyReadResetStatus();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(chkLoaiMAConSuDung.Checked == true)
            {
                LoaiMonDTO loaiMon = new LoaiMonDTO();
                loaiMon.MaLoaiMon = txtMaLoaiMon.Text;
                loaiMon.TenLoaiMon = txtTenLoaiMon.Text;
                loaiMon.TrangThai = true;

                if (LoaiMonBUS.SuaLoaiMon(loaiMon))
                {
                    //MessageBox.Show("Khôi phục loại món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LamMoi();
                    LoadDSLoaiMon();
                }
                else
                {
                    MessageBox.Show("Khôi phục loại món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loaiMon = null;
                }
            }
            
        }
        #endregion

        #region Functions
        private void LoadDSLoaiMon(string timKiem = "", bool trangThai = true)
        {
            if (chkLoaiMAConSuDung.Checked == false)
            {
                List<LoaiMonDTO> lstLoaiMon = LoaiMonBUS.LayDanhSachLoaiMon(timKiem, trangThai);
                dgvDSLoaiMon.DataSource = lstLoaiMon;
                XoaForm(true);
            }
            else
            {
                dgvDSLoaiMon.DataSource = LoaiMonBUS.LayDSLoaiMonAnBiXoa();
                dgvDSLoaiMon.CurrentCell = null;
                txtMaLoaiMon.Clear();
                txtTenLoaiMon.Clear();
                btnCapNhat.Hide();
                btnThem.Hide();
                btnXoa.Hide();
                btnLamMoi.Hide();
                btnKhoiPhuc.Show();
                if (dgvDSLoaiMon.Rows.Count > 0)
                {
                    btnKhoiPhuc.Enabled = true;
                }
                else
                {
                    btnKhoiPhuc.Enabled = false;
                }
                chkTrangThai.Checked = false;           
            }
   
        }

        private void LamMoi(bool TrangThai = true)
        {   
            if(TrangThai == true)
            {
                btnCapNhat.Visible = !TrangThai;
                btnThem.Visible = TrangThai;
                btnKhoiPhuc.Visible = !TrangThai;
                btnXoa.Visible = TrangThai;
                btnXoa.Enabled = !TrangThai;
            }
            else
            {
                btnCapNhat.Visible = !TrangThai;
                btnThem.Visible = TrangThai;
                btnKhoiPhuc.Visible = !TrangThai;
                btnXoa.Visible = !TrangThai;
                btnXoa.Enabled = !TrangThai;
            }
           
            
        }

        private void XoaForm(bool t)
        {
            if (t)
            {
                txtMaLoaiMon.Text = LoaiMonBUS.LayMaLoaiMonLonNhat();
                txtTenLoaiMon.Text = string.Empty;
            }
            else
            {
                txtMaLoaiMon.Text = string.Empty;
                txtTenLoaiMon.Text = string.Empty;
            }
           
        }

        void OnlyReadResetStatus()
        {
            if (chkLoaiMAConSuDung.Checked == true)
            {
                txtTenLoaiMon.Enabled = false;
                chkTrangThai.Enabled = false;
            }
            else
            {
                txtTenLoaiMon.Enabled = true;
                chkTrangThai.Enabled = true;
                LoadDSLoaiMon();
                btnCapNhat.Hide();
                btnThem.Show();
                btnXoa.Show();
                btnLamMoi.Show();
                btnKhoiPhuc.Hide();
            }
        }




        #endregion

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
