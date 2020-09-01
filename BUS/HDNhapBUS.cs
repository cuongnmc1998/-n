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
    public static class HDNhapBUS
    {
        public static DataTable LayDSHDNhap(string tenTK)
        {
            return HDNhapDAO.LayDSHDNhap(tenTK);
        }

        public static DataTable LayDSHDNhapBiXoa(string tenTK)
        {
            return HDNhapDAO.LayDSHDNhapBiXoa(tenTK);
        }

        //Lấy tổng tiền trong HD
        public static int LayTongTienHDNhap(int maHD)
        {
            return HDNhapDAO.LayTongTienHD(maHD);
        }

        public static bool ThemHDNhap(HDNhapDTO hd)
        {
            hd.MaHDNhap = (HDNhapDAO.LayMaHDNhapLonNhat() + 1);
            if (!HDNhapDAO.ThemHDNhap(hd))
            {
                return false;
            }
            return true;
        }

        public static bool CapNhatHDNhap(int maHD, int tTien)
        {
            return HDNhapDAO.CapNhatHDNhap(maHD, tTien);
        }

        public static bool HoanTatHD(HDNhapDTO hd)
        {
            return HDNhapDAO.HoanTatHD(hd);
        }

        //Cập nhật trạng thái của hóa đơn(0: chưa thanh toán - 1: đã thanh toán)
        public static bool CapNhatTrangThaiHD(int maHD, int tThai)
        {
            return HDNhapDAO.CapNhatTrangThaiHD(maHD, tThai);
        }

        public static bool CapNhatTrangThaiHuy(int maHDNhap, int tTai)
        {
            return HDNhapDAO.CapNhatTrangThaiHuy(maHDNhap, tTai);
        }

        public static int LayMaHDNhapLonNhat()
        {
            int maxHDNhap = HDNhapDAO.LayMaHDNhapLonNhat();
            if (maxHDNhap != 0)
               return maxHDNhap + 1;
            return 1;         
        }
    }
}
