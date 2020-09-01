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
    public partial class frmDangNhap : Form
    {
        //int LoaiTK = 0; //0: Chủ 1: Quản lý 2: Ca trưởng
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cboLoaiTK.SelectedItem = "CHỦ";
            //txtTenTK.Text = "chucuahang";
            //txtMatKhau.Text = "123456789";
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            int LoaiTK = Convert.ToInt32(cboLoaiTK.SelectedIndex.ToString());
            if (e.KeyChar == (char)Keys.Enter)
            {
                XuLyDangNhap(txtTenTK.Text, txtMatKhau.Text, LoaiTK);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int LoaiTK = Convert.ToInt32(cboLoaiTK.SelectedIndex.ToString());
            XuLyDangNhap(txtTenTK.Text, txtMatKhau.Text, LoaiTK);
        }

        private void cboLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiTK.SelectedIndex == 0)
            {
                TaiKhoanDTO tk = TaiKhoanBUS.LayDSNhanVienChuCH();
                txtTenTK.Text = tk.TenTaiKhoan;
                txtMatKhau.Text = tk.MatKhau;
            }
            else if (cboLoaiTK.SelectedIndex == 1)
            {
                TaiKhoanDTO tk = TaiKhoanBUS.LayDSNhanVienQuanLy();
                txtTenTK.Text = tk.TenTaiKhoan;
                txtMatKhau.Text = tk.MatKhau;
            }else if (cboLoaiTK.SelectedIndex == 2)
            {
                TaiKhoanDTO tk = TaiKhoanBUS.LayDSNhanVienCaTruong();
                txtTenTK.Text = tk.TenTaiKhoan;
                txtMatKhau.Text = tk.MatKhau;
            }
        }

        #region Functions
        private void XuLyDangNhap(string tenTK, string mKhau, int loaiTK)
        {   
            if(TaiKhoanBUS.KiemTraDangNhap(tenTK, mKhau, loaiTK))
            {
                string tenNV = TaiKhoanBUS.LayTenNVTaiKhoan(tenTK);
                frmMain frm = new frmMain(tenTK, tenNV, loaiTK);
                frm.Show();
                this.Hide();           
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        #endregion

        
    }
}
