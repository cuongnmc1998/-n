using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public static class HDXuatDAO
    {
        public static DataTable LayDSHDXuat(string tenTK)
        {
            string query = "SELECT [MaHDXuat],[TenTaiKhoan],[NgayXuat],[TongTien],[TrangThai] FROM [tblHDXuat] WHERE TenTaiKhoan = @TenTaiKhoan AND TonTai = 1";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static DataTable LayDSHDXuatBiXoa(string tenTK)
        {
            string query = "SELECT [MaHDXuat],[TenTaiKhoan],[NgayXuat],[TongTien],[TrangThai] FROM [tblHDXuat] WHERE TenTaiKhoan = @TenTaiKhoan AND TonTai = 0";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        //Tìm kiếm hóa đơn
        //Lấy tổng tiền trong HD
        public static int LayTongTienHDXuat(int maHD)
        {
            string query = "SELECT TongTien FROM tblHDXuat WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }

        public static bool ThemHDXuat(HDXuatDTO hd)
        {
            string query = "INSERT INTO [tblHDXuat]([MaHDXuat],[TenTaiKhoan],[NgayXuat],[TongTien],[TrangThai],[TonTai]) VALUES(@MaHDXuat,@TenTaiKhoan,@NgayXuat,@TongTien,@TrangThai,@TonTai)";
            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("@MaHDXuat", hd.MaHDXuat);
            pars[1] = new SqlParameter("@TenTaiKhoan", hd.TenTaiKhoan);
            pars[2] = new SqlParameter("@NgayXuat", hd.NgayXuat);
            pars[3] = new SqlParameter("@TongTien", hd.TongTien);
            pars[4] = new SqlParameter("@TrangThai", hd.TrangThai);
            pars[5] = new SqlParameter("@TonTai", hd.TonTai);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool HoanTatHD(HDXuatDTO hd)
        {
            string query = "UPDATE tblHDXuat SET NgayXuat = @NgayXuat WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDXuat", hd.MaHDXuat);
            pars[1] = new SqlParameter("@NgayXuat", hd.NgayXuat);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool CapNhatHDXuat(int maHD, int tTien)
        {
            string query = "UPDATE tblHDXuat SET TongTien = @TongTien WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@TongTien", tTien);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        //Cập nhật trạng thái của hóa đơn(0: Chờ xử lý - 1: Đã xử lý)
        public static bool CapNhatTrangThaiHD(int maHD, int tThai)
        {
            string query = "UPDATE tblHDXuat SET TrangThai = @TrangThai WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@TrangThai", tThai);
            pars[1] = new SqlParameter("@MaHDXuat", maHD);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        //0: đã hủy || 1: chưa hủy
        public static bool CapNhatTrangThaiHuy(int maHD, int tTai)
        {
            string query = "UPDATE tblHDXuat SET TonTai = @TonTai WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@TonTai", tTai);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static int LayMaHDXuatLonNhat()
        {
            try
            {
                string query = "SELECT MAX(MaHDXuat) FROM tblHDXuat";
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
            string query = "SELECT TongTien FROM tblHDXuat WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }


    }
}
