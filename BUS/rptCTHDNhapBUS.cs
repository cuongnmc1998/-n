using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class rptCTHDNhapBUS
    {
        public static List<rptCTHDNhapDTO> ReportLayDSCTHDNhap(int maHD)
        {
            return rptCTHDNhapDAO.ReportLayDSCTHDNhap(maHD);
        }
    }
}
