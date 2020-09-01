using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DTO;
using BUS;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmBaoCao : Form
    {
        string s = "QLCuaHangThucAnNhanh.";
        public static string _tienMat = string.Empty;
        public static string _tienThua = string.Empty;
        //private static frmBaoCao _Instance = null;
        public frmBaoCao()
        {
            InitializeComponent();
        }

        //public static frmBaoCao Instance
        //{
        //    get
        //    {
        //        if (_Instance == null)
        //        {
        //            _Instance = new frmBaoCao();
        //        }
        //        return _Instance;
        //    }
        //}

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            this.rpvBaoCao.RefreshReport();
        }

        public void HienDSMon()
        {
            List<rptMonAnDTO> lsMon = rptMonAnBUS.ReportLayDSMonAn();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSMonAn.rdlc";
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSMonAn", lsMon));
            rpvBaoCao.RefreshReport();
        }

        public void HienDSLoaiMon()
        {
            List<LoaiMonDTO> lsLoaiMon = LoaiMonBUS.LayDanhSachLoaiMon();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSLoaiMonAn.rdlc";
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSLoaiMonAn", lsLoaiMon));
            rpvBaoCao.RefreshReport();
        }

        public void HienDSNguyenLieu()
        {
            List<rptNguyenLieuDTO> lsNguyenLieu = rptNguyenLieuBUS.ReportLayDSNguyenLieu();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSNguyenLieu.rdlc";
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSNguyenLieu", lsNguyenLieu));
            rpvBaoCao.RefreshReport();
        }

        public void HienDSLoaiNL()
        {
            DataTable dtLoaiNL = LoaiNguyenLieuBUS.LoadDSLoaiNguyenLieu();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSLoaiNL.rdlc";
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSLoaiNL", dtLoaiNL));
            rpvBaoCao.RefreshReport();
        }

        public void HienDSTheLoaiMon(string maLoaiMon)
        {
            List<rptMonAnDTO> lsMon = rptMonAnBUS.ReportLayDSMonAnTheoMaLoaiMon(maLoaiMon);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSTheLoaiMonAn.rdlc";
            LoaiMonDTO loaiMon = rptMonAnBUS.ReportLayMaLoaiMon(maLoaiMon);
            rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paLoaiMon",loaiMon.TenLoaiMon));
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSMonAn", lsMon));
            rpvBaoCao.RefreshReport();
        }

        public void HienDSTheLoaiNL(string maLoaiNL)
        {
            List<rptNguyenLieuDTO> lsNL = rptNguyenLieuBUS.ReportLayDSMonAnTheoMaLoaiNL(maLoaiNL);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSTheLoaiNguyenLieu.rdlc";
            LoaiNguyenLieuDTO loaiNL = rptNguyenLieuBUS.ReportLayMaLoaiNL(maLoaiNL);
            rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paLoaiNL", loaiNL.TenLoaiNL));
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSNguyenLieu", lsNL));
            rpvBaoCao.RefreshReport();
        }

        #region HienDSHDNhap
        public void HienDSHDNhap()
        {
            List<rptHDNhapDTO> lsHDNhap = rptHDNhapBUS.ReportLayDSHDNhap();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSHDNhap.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDNhap", lsHDNhap));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int maHDNhap = int.Parse(e.Parameters["paMaHDNhap"].Values[0]);
            List<rptCTHDNhapDTO> lsCTHDNhap = rptCTHDNhapBUS.ReportLayDSCTHDNhap(maHDNhap);
            e.DataSources.Add(new ReportDataSource("DSCTHDNhap", lsCTHDNhap));
        }
        #endregion

        #region HienDSHDXuat
        public void HienDSHDXuat()
        {
            List<rptHDXuatDTO> lsHDXuat = rptHDXuatBUS.ReportLayDSHDXuat();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSHDXuat.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing1);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDXuat", lsHDXuat));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing1(object sender, SubreportProcessingEventArgs e)
        {
            int maHDXuat = int.Parse(e.Parameters["paMaHDXuat"].Values[0]);
            List<rptCTHDXuatDTO> lsCTHDXuat = rptCTHDXuatBUS.ReportLayDSCTHDXuat(maHDXuat);
            e.DataSources.Add(new ReportDataSource("DSCTHDXuat", lsCTHDXuat));
        }
        #endregion

        #region HienDSHDBanHang
        public void HienDSHDBanHang()
        {
            List<rptHDBanHangDTO> lsHDBanHang = rptHDBanHangBUS.ReportLayDSHDBanHang();
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptDSHDBanHang.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing2);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDBanHang", lsHDBanHang));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing2(object sender, SubreportProcessingEventArgs e)
        {
            int maHD = int.Parse(e.Parameters["paMaHD"].Values[0]);
            List<rptCTHDBanHangDTO> lsCTHDBanHang = rptCTHDBanHangBUS.ReportLayDSCTHDBanHang(maHD);
            e.DataSources.Add(new ReportDataSource("DSCTHDBanHang", lsCTHDBanHang));
        }
        #endregion

        #region HienHDBanHang
        public void HienHDBanHang(int maHD)
        {
            List<rptHDBanHangDTO> lsHDBanHang = rptHDBanHangBUS.ReportLayHDBanHang(maHD);
            string tienMat = "";
            string tienThua = "";
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptHDBanHang.rdlc";
            rptCTHDBanHangDTO rptCTHD = rptCTHDBanHangBUS.ReportLaySoLuongCTHDBH(maHD);
            rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paSoLuong", rptCTHD.TongSoLuong.ToString()));
            frmBanHang frmBH = new frmBanHang();
            if (!string.IsNullOrEmpty(_tienMat) && !string.IsNullOrEmpty(_tienThua))
            {
                
                tienMat = String.Format("{0:#,##0 VND}", _tienMat);
                tienThua = _tienThua;
            }
            rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paTienMat", tienMat));
            rpvBaoCao.LocalReport.SetParameters(new ReportParameter("paTienThua", tienThua));
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing3);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDBanHang", lsHDBanHang));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing3(object sender, SubreportProcessingEventArgs e)
        {
            int maHD = int.Parse(e.Parameters["paMaHD"].Values[0]);
            List<rptCTHDBanHangDTO> lsCTHDBanHang = rptCTHDBanHangBUS.ReportLaySubCTHDBanHang(maHD);
            e.DataSources.Add(new ReportDataSource("SubCTHDBanHang", lsCTHDBanHang));
        }
        #endregion

        #region HienPhieuDatMon
        public void HienPhieuDatMon(int maHD)
        {
            List<rptHDBanHangDTO> lsHDBanHang = rptHDBanHangBUS.ReportPhieuDatMon(maHD);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptPhieuDatMon.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing4);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("PhieuDatMon", lsHDBanHang));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing4(object sender, SubreportProcessingEventArgs e)
        {
            int maHD = int.Parse(e.Parameters["paMaHD"].Values[0]);
            List<rptCTHDBanHangDTO> lsCTHDBanHang = rptCTHDBanHangBUS.ReportSubPhieuDatMon(maHD);
            e.DataSources.Add(new ReportDataSource("SubPhieuDatMon", lsCTHDBanHang));
        }
        #endregion

        #region HDTheoNgay
        // HoaDonNhap
        public void HienHDNhapTheoNgay(DateTime ngay)
        {
            List<rptHDNhapDTO> lsHDNhap = rptHDNhapBUS.ReportLayHDNhapTheoNgay(ngay);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptHDNhapTheoNgay.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing5);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDNhap", lsHDNhap));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing5(object sender, SubreportProcessingEventArgs e)
        {
            int maHDNhap = int.Parse(e.Parameters["paMaHDNhap"].Values[0]);
            List<rptCTHDNhapDTO> lsCTHDNhap = rptCTHDNhapBUS.ReportLayDSCTHDNhap(maHDNhap);
            e.DataSources.Add(new ReportDataSource("DSCTHDNhap", lsCTHDNhap));
        }

        // HoaDonXuat
        public void HienHDXuatTheoNgay(DateTime ngay)
        {
            List<rptHDXuatDTO> lsHDXuat = rptHDXuatBUS.ReportLayHDXuatTheoNgay(ngay);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptHDXuatTheoNgay.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing6);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDXuat", lsHDXuat));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing6(object sender, SubreportProcessingEventArgs e)
        {
            int maHDXuat = int.Parse(e.Parameters["paMaHDXuat"].Values[0]);
            List<rptCTHDXuatDTO> lsCTHDXuat = rptCTHDXuatBUS.ReportLayDSCTHDXuat(maHDXuat);
            e.DataSources.Add(new ReportDataSource("DSCTHDXuat", lsCTHDXuat));
        }

        // HoaDonBanHang
        public void HienHDBanHangTheoNgay(DateTime ngay)
        {
            List<rptHDBanHangDTO> lsHDBanHang = rptHDBanHangBUS.ReportLayHDBanHangTheoNgay(ngay);
            rpvBaoCao.LocalReport.ReportEmbeddedResource = s + "rptHDBanHangTheoNgay.rdlc";
            rpvBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing7);
            rpvBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSHDBanHang", lsHDBanHang));
            rpvBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing7(object sender, SubreportProcessingEventArgs e)
        {
            int maHD = int.Parse(e.Parameters["paMaHD"].Values[0]);
            List<rptCTHDBanHangDTO> lsCTHDBanHang = rptCTHDBanHangBUS.ReportLayDSCTHDBanHang(maHD);
            e.DataSources.Add(new ReportDataSource("DSCTHDBanHang", lsCTHDBanHang));
        }
        #endregion
    }
}
