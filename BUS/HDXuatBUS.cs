using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public static class HDXuatBUS
    {
        public static DataTable LayDSHDXuat(string tenTK)
        {
            return HDXuatDAO.LayDSHDXuat(tenTK);
        }

        public static DataTable LayDSHDXuatBiXoa(string tenTK)
        {
            return HDXuatDAO.LayDSHDXuatBiXoa(tenTK);
        }

        //Lấy tổng tiền trong HD
        public static int LayTongTienHDXuat(int maHD)
        {
            return HDXuatDAO.LayTongTienHD(maHD);
        }

        public static bool ThemHDXuat(HDXuatDTO hd)
        {
            hd.MaHDXuat = (HDXuatDAO.LayMaHDXuatLonNhat() + 1);
            if (!HDXuatDAO.ThemHDXuat(hd))
            {
                return false;
            }
            return true;
        }

        public static bool CapNhatHDXuat(int maHD, int tTien)
        {
            return HDXuatDAO.CapNhatHDXuat(maHD, tTien);
        }

        public static bool HoanTatHD(HDXuatDTO hd)
        {
            return HDXuatDAO.HoanTatHD(hd);
        }

        //Cập nhật trạng thái của hóa đơn(chưa thanh toán/đã thanh toán)
        public static bool CapNhatTrangThaiHD(int maHD, int tThai)
        {
            return HDXuatDAO.CapNhatTrangThaiHD(maHD, tThai);
        }

        public static bool CapNhatTrangThaiHuy(int maHD, int tTai)
        {
            return HDXuatDAO.CapNhatTrangThaiHuy(maHD, tTai);
        }

        public static int LayMaHDXuatLonNhat()
        {
            int maxHDXuat = HDXuatDAO.LayMaHDXuatLonNhat();
            if (maxHDXuat != 0)
                return maxHDXuat + 1;
            return 1;
        }
    }
}
