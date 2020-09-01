using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public static class CTHDBanHangDAO
    {
        #region PhanBanHang
        //Kiểm tra món ăn có tồn tại trong 1 HD
        public static bool KiemTraMonAnTonTai(int maHD, string maMon)
        {
            string query = "SELECT COUNT(*) FROM tblCTHDBanHang WHERE MaHD = @MaHD AND MaMon = @MaMon";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@MaMon", maMon);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]) > 0;
        }
        //Đếm sl món ăn trong CTHD
        public static int SoLuongMonAnCTHD(int maHD)
        {
            string query = "SELECT COUNT(*) FROM tblCTHDBanHang WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }
        //Lấy sl món ăn trong CTHD
        public static int SoLuongCTHDBanHang(int maHD, string maMon)
        {
            string query = "SELECT SoLuong FROM tblCTHDBanHang WHERE MaHD = @MaHD AND MaMon = @MaMon";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@MaMon", maMon);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }
        //Lấy DS CTHDBanHang theo Hóa đơn
        public static DataTable LayDSCTHDBanHang(int maHD)
        {
            string query = "SELECT * FROM tblCTHDBanHang WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Thêm món ăn vào CTHDBanHang
        public static bool ThemMonAnVaoCTHD(CTHDBanHangDTO cthd)
        {
            string query = "INSERT INTO tblCTHDBanHang(MaHD, MaMon, DonGia, SoLuong, GhiChu) VALUES(@MaHD, @MaMon, @DonGia, @SoLuong, @GhiChu)";
            SqlParameter[] pars = new SqlParameter[5];
            pars[0] = new SqlParameter("@MaHD", cthd.MaHD);
            pars[1] = new SqlParameter("@MaMon", cthd.MaMon);
            pars[2] = new SqlParameter("@DonGia", cthd.DonGia);
            pars[3] = new SqlParameter("@SoLuong", cthd.SoLuong);
            pars[4] = new SqlParameter("@GhiChu", cthd.GhiChu);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }
        //Cập nhật món ăn trong CTHD(SoLuong, Ghi chú)
        public static bool CapNhatMonAn(CTHDBanHangDTO cthd)
        {
            string query = "UPDATE tblCTHDBanHang SET SoLuong = @SoLuong, GhiChu = @GhiChu WHERE MaMon = @MaMon AND MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@MaHD", cthd.MaHD);
            pars[1] = new SqlParameter("@MaMon", cthd.MaMon);
            pars[2] = new SqlParameter("@SoLuong", cthd.SoLuong);
            pars[3] = new SqlParameter("@GhiChu", cthd.GhiChu);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }
        //Cập nhật số lượng món ăn đã có sẵn trong 1 HD
        public static bool CapNhatSLMonAn(int maHD, string maMon, int sLuong)
        {
            string query = "UPDATE tblCTHDBanHang SET SoLuong = @SoLuong WHERE MaMon = @MaMon AND MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@MaMon", maMon);
            pars[2] = new SqlParameter("@SoLuong", sLuong);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }
        //Xóa 1 món ăn trong CTHD
        public static bool XoaMonAn(int maHD, string maMon)
        {
            string query = "DELETE FROM tblCTHDBanHang WHERE MaHD = @MaHD AND MaMon = @MaMon";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHD", maHD);
            pars[1] = new SqlParameter("@MaMon", maMon);
            return DataProvider.ExecuteDeleteQuery(query, pars) == 1;
        }
        //Xóa tất cả món ăn trong CTHD của 1 HD
        public static bool XoaTatCaMonAnHD(int maHD)
        {
            string query = "DELETE FROM tblCTHDBanHang WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return DataProvider.ExecuteDeleteQuery(query, pars) >  0;
        }
        #endregion

        #region QuanLyHDBanHang
        //Lấy chi tiết hóa đơn bán hàng
        public static DataTable LayChiTietHD(int maHD)
        {
            string query = "SELECT * FROM tblCTHDBanHang WHERE MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        #endregion
    }
}
