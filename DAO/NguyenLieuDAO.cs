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
    public static class NguyenLieuDAO
    {
        public static DataTable LayDSNguyenLieu()
        {
            string query = "SELECT [MaNL],tblNguyenLieu.[MaLoaiNL],[MaNCC],[TenNL],[DonViTinh],[DonGia],[SoLuongTonKho],tblNguyenLieu.[TrangThai] FROM [tblNguyenLieu],tblLoaiNguyenLieu WHERE tblNguyenLieu.MaLoaiNL = tblLoaiNguyenLieu.MaLoaiNL AND tblLoaiNguyenLieu.TrangThai = 1";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static bool ThemNguyenLieu(NguyenLieuDTO nl)
        {
            string query = "INSERT INTO [tblNguyenLieu]([MaNL],[MaLoaiNL],[MaNCC],[TenNL],[DonViTinh],[DonGia],[SoLuongTonKho],[TrangThai]) VALUES(@MaNL,@MaLoaiNL,@MaNCC,@TenNL,@DonViTinh,@DonGia,@SLTK,@TrangThai)";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaNL", nl.MaNL);
            pars[1] = new SqlParameter("@MaLoaiNL", nl.MaLoaiNL);
            pars[2] = new SqlParameter("@MaNCC", nl.MaNCC);
            pars[3] = new SqlParameter("@TenNL", nl.TenNL);
            pars[4] = new SqlParameter("@DonViTinh", nl.DonViTinh);
            pars[5] = new SqlParameter("@DonGia", nl.DonGia);
            pars[6] = new SqlParameter("@SLTK", nl.SoLuongTonKho);
            pars[7] = new SqlParameter("@TrangThai", true);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool CapNhatNguyenLieu(NguyenLieuDTO nl)
        {
            string query = "UPDATE [tblNguyenLieu] SET [MaLoaiNL] = @MaLoaiNL,[MaNCC] = @MaNCC,[TenNL] = @TenNL,[DonViTinh] = @DonViTinh,[DonGia] = @DonGia,[SoLuongTonKho] = @SLTK,[TrangThai] = @TrangThai WHERE MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaNL", nl.MaNL);
            pars[1] = new SqlParameter("@MaLoaiNL", nl.MaLoaiNL);
            pars[2] = new SqlParameter("@MaNCC", nl.MaNCC);
            pars[3] = new SqlParameter("@TenNL", nl.TenNL);
            pars[4] = new SqlParameter("@DonViTinh", nl.DonViTinh);
            pars[5] = new SqlParameter("@DonGia", nl.DonGia);
            pars[6] = new SqlParameter("@SLTK", nl.SoLuongTonKho);
            pars[7] = new SqlParameter("@TrangThai", nl.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool XoaNguyenLieu(string maNL)
        {
            string query = "UPDATE tblNguyenLieu SET TrangThai = 0 WHERE MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static DataTable TimKiemTheoTenNguyenLieu(string tenNL)
        {
            string query = "SELECT [MaNL],[MaLoaiNL],[MaNCC],[TenNL],[DonViTinh],[DonGia],[SoLuongTonKho],[TrangThai] FROM [tblNguyenLieu] WHERE TrangThai = 1 AND TenNL = @TenNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenNL", tenNL);
            return DataProvider.ExecuteSelectQuery(query, pars);

        }

        // Load danh sách nguyên liệu trạng thái false (không còn sử dụng)
        public static DataTable LayDSNguyenLieuKhongConSuDung()
        {
            string query = "SELECT [MaNL],[MaLoaiNL],[MaNCC],[TenNL],[DonViTinh],[DonGia],[SoLuongTonKho],[TrangThai] FROM [tblNguyenLieu] WHERE TrangThai = 0";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        // Khôi phục trạng thái nguyên liệu 
        public static bool KhoiPhucTrangThaiNguyenLieu(NguyenLieuDTO nl)
        {
            string query = "UPDATE [tblNguyenLieu] SET [MaLoaiNL] = @MaLoaiNL,[MaNCC] = @MaNCC,[TenNL] = @TenNL,[DonViTinh] = @DonViTinh,[DonGia] = @DonGia,[SoLuongTonKho] = @SLTK,[TrangThai] = @TrangThai WHERE MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaNL", nl.MaNL);
            pars[1] = new SqlParameter("@MaLoaiNL", nl.MaLoaiNL);
            pars[2] = new SqlParameter("@MaNCC", nl.MaNCC);
            pars[3] = new SqlParameter("@TenNL", nl.TenNL);
            pars[4] = new SqlParameter("@DonViTinh", nl.DonViTinh);
            pars[5] = new SqlParameter("@DonGia", nl.DonGia);
            pars[6] = new SqlParameter("@SLTK", nl.SoLuongTonKho);
            pars[7] = new SqlParameter("@TrangThai", true);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static string LayMaNLLonNhat()
        {
            string query = "SELECT MAX(MaNL) FROM tblNguyenLieu";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }

        // Lấy đơn giá load từ cboMaNL bên frmHDNhap/Xuat
        public static int LayDonGiaTuMaNL(string maNL)
        {
            try
            {
                string query = "SELECT DonGia FROM tblNguyenLieu WHERE MaNL = @MaNL";
                SqlParameter[] pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MaNL", maNL);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        // Lấy đơn vị tính load từ cboMaNL bên frmHDNhap/Xuat
        public static string LayDonViTinhTuMaNL(string maNL)
        {
            string query = "SELECT DonViTinh FROM tblNguyenLieu WHERE MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }

        // Lấy số lượng tồn kho nguyên liệu
        public static int LaySoLuongTKNL(string maNL)
        {
            try
            {
                string query = "SELECT SoLuongTonKho FROM tblNguyenLieu WHERE MaNL = @MaNL";
                SqlParameter[] pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MaNL", maNL);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        // Cập nhật số lượng tồn kho khi xuất hóa đơn NL 
        public static bool CapNhatSoLuongTonKhoGiam(int maHD, string maNL,int sltk)
        {
            string query = "UPDATE tblNguyenLieu SET SoLuongTonKho = @SoLuongTonKho FROM tblCTHDXuat WHERE tblNguyenLieu.MaNL = tblCTHDXuat.MaNL AND tblCTHDXuat.MaHDXuat = @MaHDXuat AND tblCTHDXuat.MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@MaNL",maNL);
            pars[2] = new SqlParameter("@SoLuongTonKho", sltk);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        // Cập nhật số lượng tồn kho khi nhập hóa đơn NL 
        public static bool CapNhatSoLuongTonKhoTang(int maHD, string maNL, int sltk)
        {
            string query = "UPDATE tblNguyenLieu SET SoLuongTonKho = @SoLuongTonKho FROM tblCTHDNhap WHERE tblNguyenLieu.MaNL = tblCTHDNhap.MaNL AND tblCTHDNhap.MaHDNhap = @MaHDNhap AND tblCTHDNhap.MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            pars[1] = new SqlParameter("@MaNL", maNL);
            pars[2] = new SqlParameter("@SoLuongTonKho", sltk);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static DataTable LayDSMaNL()
        {
            string query = "SELECT MaNL FROM tblNguyenLieu";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
    }
}
