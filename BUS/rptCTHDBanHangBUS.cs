using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class rptCTHDBanHangBUS
    {
        public static List<rptCTHDBanHangDTO> ReportLayDSCTHDBanHang(int maHD)
        {
            return rptCTHDBanHangDAO.ReportLayDSCTHDBanHang(maHD);
        }

        public static List<rptCTHDBanHangDTO> ReportLaySubCTHDBanHang(int maHD)
        {
            return rptCTHDBanHangDAO.ReportLaySubCTHDBanHang(maHD);
        }

        public static rptCTHDBanHangDTO ReportLaySoLuongCTHDBH(int maHD)
        {
            return rptCTHDBanHangDAO.ReportLaySoLuongCTHDBH(maHD);
        }

        public static List<rptCTHDBanHangDTO> ReportSubPhieuDatMon(int maHD)
        {
            return rptCTHDBanHangDAO.ReportSubPhieuDatMon(maHD);
        }
    }
}
