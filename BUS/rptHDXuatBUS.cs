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
    public static class rptHDXuatBUS
    {
        public static List<rptHDXuatDTO> ReportLayDSHDXuat()
        {
            return rptHDXuatDAO.ReportLayDSHDXuat();
        }

        public static DataTable ReportNgayXuat()
        {
            return rptHDXuatDAO.ReportNgayXuat();
        }

        public static List<rptHDXuatDTO> ReportLayHDXuatTheoNgay(DateTime ngayXuat)
        {
            return rptHDXuatDAO.ReportLayHDXuatTheoNgay(ngayXuat);
        }
    }
}
