using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public static class rptHDBanHangBUS
    {
        public static List<rptHDBanHangDTO> ReportLayDSHDBanHang()
        {
            return rptHDBanHangDAO.ReportLayDSHDBanHang();
        }

        public static List<rptHDBanHangDTO> ReportLayHDBanHang(int maHD)
        {
            return rptHDBanHangDAO.ReportLayHDBanHang(maHD);
        }

        public static List<rptHDBanHangDTO> ReportPhieuDatMon(int maHD)
        {
            return rptHDBanHangDAO.ReportPhieuDatMon(maHD);
        }

        public static DataTable ReportNgayLap()
        {
            return rptHDBanHangDAO.ReportNgayLap();
        }

        public static List<rptHDBanHangDTO> ReportLayHDBanHangTheoNgay(DateTime ngayLap)
        {
            return rptHDBanHangDAO.ReportLayHDBanHangTheoNgay(ngayLap);
        }
    }
}
