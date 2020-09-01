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
    public static class rptHDNhapBUS
    {
        public static List<rptHDNhapDTO> ReportLayDSHDNhap()
        {
            return rptHDNhapDAO.ReportLayDSHDNhap();
        }

        public static DataTable ReportNgayNhap()
        {
            return rptHDNhapDAO.ReportNgayNhap();
        }

        public static List<rptHDNhapDTO> ReportLayHDNhapTheoNgay(DateTime ngayNhap)
        {
            return rptHDNhapDAO.ReportLayHDNhapTheoNgay(ngayNhap);
        }
    }
}
