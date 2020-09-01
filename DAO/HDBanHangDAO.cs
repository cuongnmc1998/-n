    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public static class HDBanHangDAO
    {
        #region PhanBanHang
        //Lấy mã HD lớn nhất
        public static int LayMaHDLonNhat()
        {
            try
            {
                string query = "SELECT MAX(MaHD) FROM tblHDBanHang";
                SqlParameter[] pars = new SqlParameter[0];
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }
        //Lấy hóa đơn chưa thanh toán
        public static DataRow LayHDTrangThaiChuaThanhToan()
        {
            try
            {
                string query = "SELECT MaHD,TenTaiKhoan,NgayLapHD,TongTien,GhiChu,TrangThai FROM tblHDBanHang WHERE TrangThai = 0";
                SqlParameter[] pars = new SqlParameter[0];
                return DataProvider.ExecuteSelectQuery(query, pars).Rows[0];
            }
            catch (IndexOutOfRangeException)
            {
                return null;
            }
        }       
        //Tạo HD bán hàng
        public static bool TaoHDBanHang(HDBanHangDTO hdBH)
        {
            string query = "INSERT INTO tblHDBanHang(MaHD, TenTaiKhoan, NgayLapHD, TongTien, GhiChu, TrangThai, TonTai) VALUES (@MaHD, @TenTaiKhoan, @NgayLapHD, @TongTien, @GhiChu, @TrangThai, @TonTai)";
            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("@MaHD", hdBH.MaHD);
            pars[1] = new SqlParameter("@TenTaiKhoan", hdBH.TenTaiKhoan);
            pars[2] = new SqlParameter("@NgayLapHD", hdBH.NgayLapHD);
            pars[3] = new SqlParameter("@TongTien", hdBH.TongTien);
            pars[4] = new SqlParameter("@GhiChu", hdBH.GhiChu);
            pars[5] = new SqlParameter("@TrangThai", hdBH.TrangThai);
            pars[6] = new SqlParameter("@TonTai", hdBH.TonTai);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }
        //Cập nhật hóa đơn
        public static bool CapNhatHoaDon(HDBanHangDTO hdBH)
        {
            string query = "UPDATE tblHDBanHang SET TenTaiKhoan = @TenTaiKhoan, NgayLapHD = @NgayLapHD, TongTien = @TongTien, TienCuaKH =@TienCuaKH, TienThua = @TienThua, GhiChu = @GhiChu, TrangThai = @TrangThai, TonTai = @TonTai WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[9];
            pars[0] = new SqlParameter("@MaHD", hdBH.MaHD);
            pars[1] = new SqlParameter("@TenTaiKhoan", hdBH.TenTaiKhoan);
            pars[2] = new SqlParameter("@NgayLapHD", hdBH.NgayLapHD);
            pars[3] = new SqlParameter("@TongTien", hdBH.TongTien);
            pars[4] = new SqlParameter("@GhiChu", hdBH.GhiChu);
            pars[5] = new SqlParameter("@TrangThai", hdBH.TrangThai);
            pars[6] = new SqlParameter("@TonTai", hdBH.TonTai);
            pars[7] = new SqlParameter("@TienCuaKH", hdBH.TienCuaKH);
            pars[8] = new SqlParameter("@TienThua", hdBH.TienThua);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
         }
        //Cập nhật tổng tiền
        public static bool CapNhatTongTien(int maHD, int tTien)
        {
            string query = "UPDATE tblHDBanHang SET TongTien = @TongTien WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@TongTien", tTien);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }
        //Lấy tổng tiền hiện tại của 1 hóa đơn
        public static int TongTienHienTaiHoaDon(int maHD)
        {
            string query = "SELECT TongTien FROM tblHDBanHang WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }
        #endregion

        #region QuanLyHDBanHang
        //Lấy DS hóa đơn bán hàng
        public static DataTable LayDSHDBanHang(int tTai)
        {
            string query = "SELECT * FROM tblHDBanHang WHERE TonTai = @TonTai";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TonTai", tTai);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Cập nhật trạng thái HĐ bán hàng
        public static bool CapNhatTrangThaiHDBanHang(int maHD, int tTai, string gChu)
        {
            string query = "UPDATE tblHDBanHang SET TonTai = @TonTai, GhiChu = @GhiChu WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@TonTai", tTai);
            pars[2] = new SqlParameter("@GhiChu", gChu);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(query, pars)) == 1;
        }
        #endregion
    }
}
