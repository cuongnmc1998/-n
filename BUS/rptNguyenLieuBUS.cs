using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class rptNguyenLieuBUS
    {
        public static List<rptNguyenLieuDTO> ReportLayDSNguyenLieu()
        {
            return rptNguyenLieuDAO.ReportLayDSNguyenLieu();
        }

        public static List<rptNguyenLieuDTO> ReportLayDSMonAnTheoMaLoaiNL(string maLoaiNL)
        {
            return rptNguyenLieuDAO.ReportLayDSMonAnTheoMaLoaiNL(maLoaiNL);
        }

        public static LoaiNguyenLieuDTO ReportLayMaLoaiNL(string maLoaiMon)
        {
            return rptNguyenLieuDAO.ReportLayMaLoaiNL(maLoaiMon);
        }
    }
}
