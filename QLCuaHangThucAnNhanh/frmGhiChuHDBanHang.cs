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
    public partial class frmGhiChuHDBanHang : Form
    {
        private int _maHD;
        private int _tTai;
        public frmGhiChuHDBanHang()
        {
            InitializeComponent();
        }
        public frmGhiChuHDBanHang(int maHD, int tTai) : this()
        {
            _maHD = maHD;
            _tTai = tTai;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool kq = HDBanHangBUS.CapNhatTrangThaiHDBanHang(_maHD, _tTai, txtGhiChu.Text);
            if (kq)
            {
                //MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
               
                this.FormClosed += FrmGhiChuHDBanHang_FormClosed;
                this.Close();

            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void FrmGhiChuHDBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHoaDonBanHang frmBH = new frmHoaDonBanHang();
            frmBH.LoadDSHdBanHang();
            frmBH.MdiParent = this.MdiParent;
        }
    }
}
