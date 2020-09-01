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
    public partial class frmTaiKhoan : Form
    {
        private static frmTaiKhoan _Instance = null;
        TaiKhoanDTO tkDTO = null;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        public static frmTaiKhoan Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmTaiKhoan();
                }
                return _Instance;
            }
        }

        private void frmTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvDSTaiKhoan.AutoGenerateColumns = false;           
            XuLyAnHienButton(true);
            DuaDuLieuChoThongTinTaiKhoan();
            LoadDSTaiKhoan();
        }

        #region Events
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tkDTO = null;
            XuLyAnHienButton(true);
            DuaDuLieuChoThongTinTaiKhoan();
            string tenTK = ((frmMain)this.ParentForm).getTenTK();
            if (tenTK == TaiKhoanBUS.PhanQuyenQuanLyTK(1))
            {
                radQuanLy.Checked = true;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void dgvDSTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSTaiKhoan.SelectedRows.Count > 0)
            {
                XuLyAnHienButton(false);
                if (chkTaiKhoanBiXoa.Checked)
                {
                    btnKhoiPhuc.Visible = true;
                    btnCapNhat.Visible = false;
                    btnXoa.Visible = false;
                }
                else
                {
                    btnKhoiPhuc.Visible = false;
                    btnXoa.Visible = true;
                    txtTenTaiKhoan.Enabled = false;
                }
                
                DataRowView dr = (DataRowView)dgvDSTaiKhoan.SelectedRows[0].DataBoundItem;
                tkDTO = new TaiKhoanDTO();
                tkDTO.TenTaiKhoan = dr[0].ToString();
                tkDTO.HoTen = dr[2].ToString();
                tkDTO.Email = dr[3].ToString();
                tkDTO.SoDT = dr[4].ToString();
                tkDTO.DiaChi = dr[5].ToString();
                tkDTO.LaAdmin = Convert.ToInt32(dr[6]);
                tkDTO.TrangThai = Convert.ToInt32(dr[7]);
                DuaDuLieuChoThongTinTaiKhoan();
                string tenTK = ((frmMain)this.ParentForm).getTenTK();
                if (radChu.Checked)
                {
                    if (tenTK == TaiKhoanBUS.PhanQuyenQuanLyTK(0))
                    {
                        btnXoa.Enabled = false;
                    }else if (tenTK == TaiKhoanBUS.PhanQuyenQuanLyTK(1))
                    {
                        btnXoa.Enabled = false;
                        radChu.Enabled = false;
                    }
                }


            }
            else
                tkDTO = null;
        }

        private void dgvDSTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDSTaiKhoan.Columns["colLaAdmin"].Index)
            {
                if (Convert.ToInt32(e.Value) == 0)
                    e.Value = "CHỦ";
                else if (Convert.ToInt32(e.Value) == 1)
                    e.Value = "QUẢN LÝ";
                else if (Convert.ToInt32(e.Value) == 2)
                    e.Value = "CA TRƯỞNG";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtEmail.Text == "" || txtSDT.Text == "" || rtbDiaChi.Text.Trim() == "")
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                GanGiaTriChoTaiKhoan();
                if (TaiKhoanBUS.TaoTaiKhoanMoi(tkDTO))
                {
                    //MessageBox.Show("Tạo tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LoadDSTaiKhoan();
                }
                else
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            GanGiaTriChoTaiKhoan();
            if (tkDTO != null)
            {
                if (txtMatKhau.Text == "")
                    tkDTO.MatKhau = TaiKhoanBUS.LayMatKhau(tkDTO.TenTaiKhoan);
                else
                    tkDTO.MatKhau = txtMatKhau.Text;
            }
            if (TaiKhoanBUS.CapNhatTaiKhoan(tkDTO))
            {
                //MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtMatKhau.Text = "";
                LoadDSTaiKhoan();
            }
            else
                MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tkDTO != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (TaiKhoanBUS.CapNhatTrangThai(tkDTO.TenTaiKhoan, 0))
                    {
                        //MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSTaiKhoan();
                    }
                    else
                        MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 

        private void chkTaiKhoanBiXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaiKhoanBiXoa.Checked)
            {
                XoaForm();   
                dgvDSTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoanBiXoa();
                btnThem.Hide();
                btnCapNhat.Hide();
                btnXoa.Hide();
                btnLamMoi.Hide();
                txtTenTaiKhoan.Enabled = txtMatKhau.Enabled = txtHoTen.Enabled = txtEmail.Enabled = txtSDT.Enabled = rtbDiaChi.Enabled = false;
                radChu.Enabled = radQuanLy.Enabled = radCaTruong.Enabled = false;
                btnKhoiPhuc.Visible = true;
                if (dgvDSTaiKhoan.Rows.Count > 0)
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
                txtTenTaiKhoan.Enabled = txtMatKhau.Enabled = txtHoTen.Enabled = txtEmail.Enabled = txtSDT.Enabled = rtbDiaChi.Enabled = true;
                radChu.Enabled = radQuanLy.Enabled = radCaTruong.Enabled = true;
                btnKhoiPhuc.Visible = false;
                btnLamMoi.Show();
                LoadDSTaiKhoan();
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(chkTaiKhoanBiXoa.Checked == true)
            {
                if (tkDTO != null)
                {
                    if (TaiKhoanBUS.CapNhatTrangThai(tkDTO.TenTaiKhoan, 1))
                    {
                        //MessageBox.Show("Khôi phục tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadDSTaiKhoan();
                    }
                    else
                        MessageBox.Show("Khôi phục tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void txtTimKiemTK_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemTK.Text == "")
                LoadDSTaiKhoan();
            else
            {
                string tKiem = "%" + txtTimKiemTK.Text + "%";
                dgvDSTaiKhoan.DataSource = TaiKhoanBUS.TimKiemTaiKhoan(tKiem);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Functions
        private void LoadDSTaiKhoan()
        {
            if(chkTaiKhoanBiXoa.Checked == false)
            {
                dgvDSTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoan();
            }
            else
            {              
                dgvDSTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoanBiXoa();              
            }
            dgvDSTaiKhoan.CurrentCell = null;
        }

        private void DuaDuLieuChoThongTinTaiKhoan()
        {
            if (tkDTO != null)
            {
                txtTenTaiKhoan.Text = tkDTO.TenTaiKhoan;
                txtMatKhau.Text = tkDTO.MatKhau;
                txtHoTen.Text = tkDTO.HoTen;
                txtEmail.Text = tkDTO.Email;
                txtSDT.Text = tkDTO.SoDT;
                rtbDiaChi.Text = tkDTO.DiaChi;
                if (tkDTO.LaAdmin == 0)
                    radChu.Checked = true;
                else if (tkDTO.LaAdmin == 1)
                    radQuanLy.Checked = true;
                else if (tkDTO.LaAdmin == 2)
                    radCaTruong.Checked = true;
                chkTrangThai.Checked = (tkDTO.TrangThai == 1) ? true : false;
            }
            else
            {
                txtTenTaiKhoan.Enabled = true;
                txtTenTaiKhoan.Text = txtHoTen.Text = txtMatKhau.Text = txtEmail.Text = txtSDT.Text = string.Empty;
                rtbDiaChi.Text = string.Empty;
                chkTrangThai.Checked = true;
                radChu.Checked = true;
            }
        }

        private void GanGiaTriChoTaiKhoan()
        {
            if (tkDTO == null)
            {
                tkDTO = new TaiKhoanDTO();
            }
            tkDTO.TenTaiKhoan = txtTenTaiKhoan.Text;
            tkDTO.MatKhau = txtMatKhau.Text;
            tkDTO.HoTen = txtHoTen.Text;
            tkDTO.Email = txtEmail.Text;
            tkDTO.SoDT = txtSDT.Text;
            tkDTO.DiaChi = rtbDiaChi.Text;
            if (radChu.Checked)
                tkDTO.LaAdmin = 0;
            if (radQuanLy.Checked)
                tkDTO.LaAdmin = 1;
            if (radCaTruong.Checked)
                tkDTO.LaAdmin = 2;
            tkDTO.TrangThai = (chkTrangThai.Checked) ? 1 : 0;
        }

        private void XuLyAnHienButton(bool chk)
        {
            btnThem.Visible = chk;
            btnCapNhat.Visible = !chk;
            btnXoa.Enabled = !chk;
            chkTrangThai.Enabled = chk;
        }

        void XoaForm()
        {
            txtTenTaiKhoan.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            rtbDiaChi.Clear();
            radChu.Checked = radCaTruong.Checked = radQuanLy.Checked = false;
            chkTrangThai.Checked = false;
        }
        #endregion   

    }
}
