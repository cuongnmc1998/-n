using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public static class CTHDXuatBUS
    {
        public static DataTable LayDSCTHDXuat(int maHD)
        {
            return CTHDXuatDAO.LayDSCTHDXuat(maHD);
        }

        // Kiểm tra MaNL
        public static bool KiemTraMaNLTonTai(int maHD, string maNL)
        {
            return CTHDXuatDAO.KiemTraMaNLTonTai(maHD, maNL);
        }

        public static bool CapNhatSoLuong(int soLuong, int maHD, string maNL)
        {
            return CTHDXuatDAO.CapNhatSoLuong(soLuong, maHD, maNL);
        }

        public static bool ThemCTHDHDXuat(CTHDXuatDTO cthd)
        {
            return CTHDXuatDAO.ThemCTHDHDXuat(cthd);
        }

        public static bool CapNhatCTHDXuat(CTHDXuatDTO cthd)
        {
            return CTHDXuatDAO.CapNhatCTHDXuat(cthd);
        }

        public static bool XoaCTHDXuat(int maHDNhap, string maNL)
        {
            return CTHDXuatDAO.XoaCTHDXuat(maHDNhap, maNL);
        }

        public static int LaySoLuongHienTai(int maHD, string maNL)
        {
            return CTHDXuatDAO.LaySoLuongHienTai(maHD, maNL);
        }

        public static int LayMaHDXuatTrongCTHDXuat(int maHD)
        {
            return CTHDXuatDAO.LayMaHDXuatTrongCTHDXuat(maHD);
        }

        public static string LayMaNLTrongCTHDXuat(int maHD)
        {
            return CTHDXuatDAO.LayMaNLTrongCTHDXuat(maHD);
        }

        public static int DemSoLuongMaNLCoTrongCTHD(int maHD)
        {
            return CTHDXuatDAO.DemSoLuongMaNLCoTrongCTHD(maHD);
        }

    }
}
