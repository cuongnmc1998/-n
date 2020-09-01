using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public static class rptMonAnBUS
    {
        public static List<rptMonAnDTO> ReportLayDSMonAn()
        {
            return rptMonAnDAO.ReportLayDSMonAn();
        }

        public static List<rptMonAnDTO> ReportLayDSMonAnTheoMaLoaiMon(string maLoaiMon)
        {
            return rptMonAnDAO.ReportLayDSMonAnTheoMaLoaiMon(maLoaiMon);
        }

        public static LoaiMonDTO ReportLayMaLoaiMon(string maLoaiMon)
        {
            return rptMonAnDAO.ReportLayMaLoaiMon(maLoaiMon);
        }
    }
}
