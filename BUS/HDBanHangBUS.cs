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
    public class HDBanHangBUS
    {
        #region PhanBanHang
        //Lấy mã HD lớn nhất
        public static int LayMaHDLonNhat()
        {
            int maHD = HDBanHangDAO.LayMaHDLonNhat();
            if (maHD == 0)
                return 1;
            return maHD + 1;
        }
        public static HDBanHangDTO LayHDTrangThaiChuaThanhToan()
        {
            HDBanHangDTO hd = new HDBanHangDTO();
            DataRow dr = HDBanHangDAO.LayHDTrangThaiChuaThanhToan();
            if (dr == null)
                return null;
            hd.MaHD = Convert.ToInt32(dr[0]);
            hd.TenTaiKhoan = dr[1].ToString();
            hd.NgayLapHD = DateTime.Now;
            hd.TongTien = Convert.ToInt32(dr[3]);
            hd.GhiChu = dr[4].ToString();
            hd.TrangThai = Convert.ToInt32(dr[5]);
            return hd;
        }
        //Tạo HD bán hàng
        public static bool TaoHDBanHang(HDBanHangDTO hdBH)
        {
            return HDBanHangDAO.TaoHDBanHang(hdBH);
        }
        //Cập nhật hóa đơn
        public static bool CapNhatHoaDon(HDBanHangDTO hdBH)
        {
            return HDBanHangDAO.CapNhatHoaDon(hdBH);
        }
        //Cập nhật tổng tiền
        public static bool CapNhatTongTien(int maHD, int tTien)
        {
            return HDBanHangDAO.CapNhatTongTien(maHD, tTien);
        }
        //Lấy tổng tiền hiện tại của 1 hóa đơn
        public static int TongTienHienTaiHoaDon(int maHD)
        {
            return HDBanHangDAO.TongTienHienTaiHoaDon(maHD);
        }

        #endregion

        #region QuanLyHDBanHang
        //Lấy DSHD bán hàng
        public static DataTable LayDSHDBanHang(int tTai)
        {
            return HDBanHangDAO.LayDSHDBanHang(tTai);
        }
        //Cập nhật trạng thái HĐ bán hàng
        public static bool CapNhatTrangThaiHDBanHang(int maHD, int tTai, string gChu)
        {
            return HDBanHangDAO.CapNhatTrangThaiHDBanHang(maHD, tTai, gChu);
        }
        #endregion
    }
}
