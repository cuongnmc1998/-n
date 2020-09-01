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
    public static class HDNhapDAO
    {
        public static DataTable LayDSHDNhap(string tenTK)
        {
            string query = "SELECT [MaHDNhap],[TenTaiKhoan],[MaNCC],[NgayNhap],[TongTien],[TrangThai] FROM [tblHDNhap] WHERE TenTaiKhoan = @TenTaiKhoan AND TonTai = 1";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static DataTable LayDSHDNhapBiXoa(string tenTK)
        {
            string query = "SELECT [MaHDNhap],[TenTaiKhoan],[MaNCC],[NgayNhap],[TongTien],[TrangThai] FROM [tblHDNhap] WHERE TenTaiKhoan = @TenTaiKhoan AND TonTai = 0";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        //Tìm kiếm hóa đơn
        //Lấy tổng tiền trong HD
        public static int LayTongTienHDNhap(int maHD)
        {
            string query = "SELECT TongTien FROM tblHDNhap WHERE MaHDNhap = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }

        public static bool ThemHDNhap(HDNhapDTO hd)
        {
            string query = "INSERT INTO [tblHDNhap]([MaHDNhap],[TenTaiKhoan],[MaNCC],[NgayNhap],[TongTien],[TrangThai],[TonTai]) VALUES(@MaHDNhap,@TenTaiKhoan,@MaNCC,@NgayNhap,@TongTien,@TrangThai,@TonTai)";
            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("@MaHDNhap", hd.MaHDNhap);
            pars[1] = new SqlParameter("@TenTaiKhoan", hd.TenTaiKhoan);
            pars[2] = new SqlParameter("@MaNCC", hd.MaNCC);
            pars[3] = new SqlParameter("@NgayNhap", hd.NgayNhap);
            pars[4] = new SqlParameter("@TongTien", hd.TongTien);
            pars[5] = new SqlParameter("@TrangThai", hd.TrangThai);
            pars[6] = new SqlParameter("@TonTai", hd.TonTai);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool HoanTatHD(HDNhapDTO hd)
        {
            string query = "UPDATE tblHDNhap SET MaNCC = @MaNCC, NgayNhap = @NgayNhap WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDNhap", hd.MaHDNhap);
            pars[1] = new SqlParameter("@MaNCC", hd.MaNCC);
            pars[2] = new SqlParameter("@NgayNhap", hd.NgayNhap);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool CapNhatHDNhap(int maHD, int tTien)
        {
            string query = "UPDATE tblHDNhap SET TongTien = @TongTien WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            pars[1] = new SqlParameter("@TongTien", tTien);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        //Cập nhật trạng thái của hóa đơn(0: chưa thanh toán - 1: đã thanh toán)
        public static bool CapNhatTrangThaiHD(int maHD, int tThai)
        {
            string query = "UPDATE tblHDNhap SET TrangThai = @TrangThai WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@TrangThai", tThai);
            pars[1] = new SqlParameter("@MaHDNhap", maHD);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        //0: đã hủy || 1: chưa hủy
        public static bool CapNhatTrangThaiHuy(int maHDNhap, int tTai)
        {
            string query = "UPDATE tblHDNhap SET TonTai = @TonTai WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDNhap", maHDNhap);
            pars[1] = new SqlParameter("@TonTai", tTai);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static int LayMaHDNhapLonNhat()
        {
            try
            {
                string query = "SELECT MAX(MaHDNhap) FROM tblHDNhap";
                SqlParameter[] pars = new SqlParameter[0];
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        public static int LayTongTienHD(int maHD)
        {
            string query = "SELECT TongTien FROM tblHDNhap WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }
  
    }
}
