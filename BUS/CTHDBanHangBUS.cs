using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHDBanHangBUS
    {
        #region PhanBanHang
        //Kiểm tra món ăn có tồn tại trong 1 HD
        public static bool KiemTraMonAnTonTai(int maHD, string maMon)
        {
            return CTHDBanHangDAO.KiemTraMonAnTonTai(maHD, maMon);
        }
        //Lấy DS CTHDBanHang theo Hóa đơn
        public static DataTable LayDSCTHDBanHang(int maHD)
        {
            return CTHDBanHangDAO.LayDSCTHDBanHang(maHD);
        }
        //Lấy sl món ăn trong CTHD
        public static int SoLuongCTHDBanHang(int maHD, string maMon)
        {
            return CTHDBanHangDAO.SoLuongCTHDBanHang(maHD, maMon);
        }
        //Đếm sl món ăn trong CTHD
        public static int SoLuongMonAnCTHD(int maHD)
        {
            return CTHDBanHangDAO.SoLuongMonAnCTHD(maHD);
        }
        //Thêm món ăn vào CTHDBanHang
        public static bool ThemMonAnVaoCTHD(CTHDBanHangDTO cthd)
        {
            return CTHDBanHangDAO.ThemMonAnVaoCTHD(cthd);
        }
        //Cập nhật món ăn trong CTHD(SoLuong, Ghi chú)
        public static bool CapNhatMonAn(CTHDBanHangDTO cthd)
        {
            return CTHDBanHangDAO.CapNhatMonAn(cthd);
        }
        //Cập nhật số lượng món ăn đã có sẵn trong 1 HD
        public static bool CapNhatSLMonAn(int maHD, string maMon, int sLuong)
        {
            return CTHDBanHangDAO.CapNhatSLMonAn(maHD, maMon, sLuong);

        }
        //Xóa 1 món ăn trong CTHD
        public static bool XoaMonAn(int maHD, string maMon)
        {
            return CTHDBanHangDAO.XoaMonAn(maHD, maMon);
        }
        //Xóa tất cả món ăn trong CTHD của 1 HD
        public static bool XoaTatCaMonAnHD(int maHD)
        {
            return CTHDBanHangDAO.XoaTatCaMonAnHD(maHD);
        }
        #endregion

        #region QuanLyHDBanHang
        //Lấy DS chi tiết hóa đơn bán hàng
        public static DataTable LayChiTietHD(int maHD)
        {
            return CTHDBanHangDAO.LayChiTietHD(maHD);
        }
        #endregion
    }
}
