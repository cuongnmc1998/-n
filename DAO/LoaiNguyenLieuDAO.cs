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
    public static class LoaiNguyenLieuDAO
    {
        public static DataTable LayDSLoaiNguyenLieu()
        {
            string query = "SELECT MaLoaiNL, TenLoaiNL, TrangThai FROM tblLoaiNguyenLieu WHERE TrangThai = 1";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static bool ThemLoaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            string query = "INSERT INTO [tblLoaiNguyenLieu]([MaLoaiNL],[TenLoaiNL],[TrangThai]) VALUES(@MaLoaiNL,@TenLoaiNL,@TrangThai)";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaLoaiNL", loaiNL.MaLoaiNL);
            pars[1] = new SqlParameter("@TenLoaiNL", loaiNL.TenLoaiNL);
            pars[2] = new SqlParameter("@TrangThai",true);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool CapNhatLoaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            string query = "UPDATE [tblLoaiNguyenLieu] SET [TenLoaiNL] = @TenLoaiNL,[TrangThai] = @TrangThai WHERE MaLoaiNL = @MaLoaiNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaLoaiNL", loaiNL.MaLoaiNL);
            pars[1] = new SqlParameter("@TenLoaiNL", loaiNL.TenLoaiNL);
            pars[2] = new SqlParameter("@TrangThai", loaiNL.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool XoaLoaiNguyenLieu(string maLoaiNL)
        {
            string query = "UPDATE tblLoaiNguyenLieu SET TrangThai = 0 WHERE MaLoaiNL = @MaLoaiNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaLoaiNL", maLoaiNL);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static DataTable TimKiemTheoTenLoaiNguyenLieu(string tenLoaiNL)
        {
            string query = "SELECT [MaLoaiNL],[TenLoaiNL],[TrangThai] FROM [tblLoaiNguyenLieu] WHERE TrangThai = 1 AND TenLoaiNL = @TenLoaiNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenLoaiNL", tenLoaiNL);
            return DataProvider.ExecuteSelectQuery(query, pars);

        }

        // Load danh sách loại nguyên liệu trạng thái false (không còn sử dụng)
        public static DataTable LayDSLoaiNguyenLieuKhongConSuDung()
        {
            string query = "SELECT MaLoaiNL, TenLoaiNL, TrangThai FROM tblLoaiNguyenLieu WHERE TrangThai = 0";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        // Khôi phục trạng thái loại nguyên liệu 
        public static bool KhoiPhucTrangThaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            string query = "UPDATE [tblLoaiNguyenLieu] SET [TenLoaiNL] = @TenLoaiNL,[TrangThai] = @TrangThai WHERE MaLoaiNL = @MaLoaiNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaLoaiNL", loaiNL.MaLoaiNL);
            pars[1] = new SqlParameter("@TenLoaiNL", loaiNL.TenLoaiNL);
            pars[2] = new SqlParameter("@TrangThai", true);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static string LayMaLoaiNLLonNhat()
        {
            string query = "SELECT MAX(MaLoaiNL) FROM tblLoaiNguyenLieu";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
    }
}
