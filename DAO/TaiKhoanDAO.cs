using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public static class TaiKhoanDAO
    {
        //Kiểm tra tài khoản tồn tại
        public static bool KiemTraTaiKhoanTonTai(string tenTK)
        {
            string query = "SELECT COUNT(*) FROM tblTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]) > 0;
        }
        //Lấy tên tài khoản
        public static string LayTenNVTaiKhoan(string tenTK)
        {
            string query = "SELECT HoTen FROM tblTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
        //Lấy loại tài khoản của tài khoản
        public static int LayLoaiTaiKhoan(string tenTK)
        {
            string query = "SELECT LaAdmin FROM tblTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
        }
        //Lấy mật khẩu của tài khoản
        public static string LayMatKhau(string tenTK)
        {
            string query = "SELECT MatKhau FROM tblTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
        //Lấy DS tài khoản
        public static DataTable LayDSTaiKhoan()
        {
            string query = "SELECT * FROM tblTaiKhoan WHERE TrangThai = 1";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Lấy DS tài khoản bị xóa
        public static DataTable LayDSTaiKhoanBiXoa()
        {
            string query = "SELECT * FROM tblTaiKhoan WHERE TrangThai = 0";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Tìm kiếm tài khoản theo tên tài khoản
        public static DataTable TimKiemTaiKhoan(string tKiem)
        {
            string query = "SELECT * FROM tblTaiKhoan WHERE TenTaiKhoan LIKE @TimKiem AND TrangThai = 1" ;
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TimKiem", tKiem);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Thêm tài khoản mới
        public static bool TaoTaiKhoanMoi(TaiKhoanDTO tkDTO)
        {
            string query = "INSERT INTO tblTaiKhoan(TenTaiKhoan, MatKhau, HoTen, Email, SoDT, DiaChi, LaAdmin, TrangThai) VALUES(@TenTaiKhoan, @MatKhau, @HoTen, @Email, @SoDT, @DiaChi, @LaAdmin, @TrangThai)";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@TenTaiKhoan", tkDTO.TenTaiKhoan);
            pars[1] = new SqlParameter("@MatKhau", tkDTO.MatKhau);
            pars[2] = new SqlParameter("@HoTen", tkDTO.HoTen);
            pars[3] = new SqlParameter("@Email", tkDTO.Email);
            pars[4] = new SqlParameter("@SoDT", tkDTO.SoDT);
            pars[5] = new SqlParameter("@DiaChi", tkDTO.DiaChi);
            pars[6] = new SqlParameter("@LaAdmin", tkDTO.LaAdmin);
            pars[7] = new SqlParameter("@TrangThai", tkDTO.TrangThai);
            return Convert.ToInt32(DataProvider.ExecuteInsertQuery(query, pars)) > 0;
        }
        //Cập nhật tài khoản
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tkDTO)
        {
            string query = "UPDATE tblTaiKhoan SET MatKhau = @MatKhau, HoTen = @HoTen, Email = @Email, SoDT = @SoDT, DiaChi = @DiaChi, LaAdmin = @LaAdmin, TrangThai = @TrangThai WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@TenTaiKhoan", tkDTO.TenTaiKhoan);
            pars[1] = new SqlParameter("@MatKhau", tkDTO.MatKhau);
            pars[2] = new SqlParameter("@HoTen", tkDTO.HoTen);
            pars[3] = new SqlParameter("@Email", tkDTO.Email);
            pars[4] = new SqlParameter("@SoDT", tkDTO.SoDT);
            pars[5] = new SqlParameter("@DiaChi", tkDTO.DiaChi);
            pars[6] = new SqlParameter("@LaAdmin", tkDTO.LaAdmin);
            pars[7] = new SqlParameter("@TrangThai", tkDTO.TrangThai);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(query, pars)) > 0;
        }
        //Cập nhật trạng thái(0: Xóa / 1: Hoạt động)
        public static bool CapNhatTrangThai(string tenTK, int trThai)
        {
            string query = "UPDATE tblTaiKhoan SET TrangThai = @TrangThai WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            pars[1] = new SqlParameter("@TrangThai", trThai);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static DataRow LayDSNhanVienChuCH()
        {
            string query = "SELECT TenTaiKhoan,MatKhau FROM tblTaiKhoan WHERE LaAdmin = 0";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0];
        }

        public static DataRow LayDSNhanVienQuanLy()
        {
            string query = "SELECT TenTaiKhoan,MatKhau FROM tblTaiKhoan WHERE LaAdmin = 1";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0];
        }

        public static DataRow LayDSNhanVienCaTruong()
        {
            string query = "SELECT TenTaiKhoan,MatKhau FROM tblTaiKhoan WHERE LaAdmin = 2";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0];
        }

        public static string PhanQuyenQuanLyTK(int laAdmin)
        {
            string query = "select TenTaiKhoan from tblTaiKhoan where LaAdmin = @LaAdmin";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@LaAdmin",laAdmin);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
    }
}
