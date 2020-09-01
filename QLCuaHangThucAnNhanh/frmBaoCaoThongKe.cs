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
    public partial class frmBaoCaoThongKe : Form
    {
        private static frmBaoCaoThongKe _Instance = null;
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        public static frmBaoCaoThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmBaoCaoThongKe();
                }
                return _Instance;
            }
        }

        private void frmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            cboLoaiMon.DataSource = LoaiMonBUS.LayDanhSachLoaiMon();
            cboLoaiMon.DisplayMember = "TenLoaiMon";
            cboLoaiMon.ValueMember = "MaLoaiMon";

            cboLoaiNL.DataSource = LoaiNguyenLieuBUS.LoadDSLoaiNguyenLieu();
            cboLoaiNL.DisplayMember = "TenLoaiNL";
            cboLoaiNL.ValueMember = "MaLoaiNL";
 
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frmBaoCao = new frmBaoCao();
            if (radMon.Checked)
            {
                frmBaoCao.HienDSMon();
            }else if (radLoaiMon.Checked)
            {
                frmBaoCao.HienDSLoaiMon();
            }else if (radNguyenLieu.Checked)
            {
                frmBaoCao.HienDSNguyenLieu();
            }else if (radLoaiNL.Checked)
            {
                frmBaoCao.HienDSLoaiNL();
            }else if (radHDNhap.Checked)
            {
                frmBaoCao.HienDSHDNhap();
            }else if (radHDXuat.Checked)
            {
                frmBaoCao.HienDSHDXuat();
            }else if (radHDBanHang.Checked)
            {
                frmBaoCao.HienDSHDBanHang();
            }else if (radTheLoaiMon.Checked)
            {
                frmBaoCao.HienDSTheLoaiMon(cboLoaiMon.SelectedValue.ToString());
            }else if (radTheLoaiNL.Checked)
            {
                frmBaoCao.HienDSTheLoaiNL(cboLoaiNL.SelectedValue.ToString());
            }else if (radHDNhapTheoNgay.Checked)
            {
                frmBaoCao.HienHDNhapTheoNgay(Convert.ToDateTime(cboNgayLapHD.SelectedValue));
            }else if (radHDXuatTheoNgay.Checked)
            {
                frmBaoCao.HienHDXuatTheoNgay(Convert.ToDateTime(cboNgayLapHD.SelectedValue));
            }else if (radHDBanHangTheoNgay.Checked)
            {
                frmBaoCao.HienHDBanHangTheoNgay(Convert.ToDateTime(cboNgayLapHD.SelectedValue));
            }


            frmBaoCao.Show();
        }

        private void radHDNhapTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radHDNhapTheoNgay.Checked)
            {
                cboNgayLapHD.DataSource = rptHDNhapBUS.ReportNgayNhap();
                cboNgayLapHD.DisplayMember = "NgayNhap";
                cboNgayLapHD.ValueMember = "NgayNhap";
            }
        }

        private void radHDXuatTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radHDXuatTheoNgay.Checked)
            {
                cboNgayLapHD.DataSource = rptHDXuatBUS.ReportNgayXuat();
                cboNgayLapHD.DisplayMember = "NgayXuat";
                cboNgayLapHD.ValueMember = "NgayXuat";
            }
        }

        private void radHDBanHangTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radHDBanHangTheoNgay.Checked)
            {
                cboNgayLapHD.DataSource = rptHDBanHangBUS.ReportNgayLap();
                cboNgayLapHD.DisplayMember = "NgayLapHD";
                cboNgayLapHD.ValueMember = "NgayLapHD";
            }
        }
    }
}
