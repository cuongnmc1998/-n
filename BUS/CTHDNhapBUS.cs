using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public static class CTHDNhapBUS
    {
        public static DataTable LayDSCTHDNhap(int maHD)
        {
            return CTHDNhapDAO.LayDSCTHDNhap(maHD);
        }

        // Kiểm tra MaNL
        public static bool KiemTraMaNLTonTai(int maHD, string maNL)
        {
            return CTHDNhapDAO.KiemTraMaNLTonTai(maHD, maNL);
        }

        public static bool CapNhatSoLuong(int soLuong, int maHD,string maNL)
        {
            return CTHDNhapDAO.CapNhatSoLuong(soLuong,maHD,maNL);
        }

        public static bool ThemCTHDHDNhap(CTHDNhapDTO cthd)
        {
            return CTHDNhapDAO.ThemCTHDHDNhap(cthd);
        }

        public static bool CapNhatCTHDNhap(CTHDNhapDTO cthd)
        {
            return CTHDNhapDAO.CapNhatCTHDNhap(cthd);
        }

        public static bool XoaCTHDNhap(int maHDNhap, string maNL)
        {
            return CTHDNhapDAO.XoaCTHDNhap(maHDNhap, maNL);
        }

        public static int LaySoLuongHienTai(int maHD, string maNL)
        {
            return CTHDNhapDAO.LaySoLuongHienTai(maHD, maNL);
        }

    }
}
