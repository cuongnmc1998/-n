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
    public static class CTHDXuatDAO
    {
        public static DataTable LayDSCTHDXuat(int maHD)
        {
            string query = "SELECT [MaHDXuat],[MaNL],[DonGia],[SoLuong] FROM [tblCTHDXuat] WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static bool ThemCTHDHDXuat(CTHDXuatDTO cthd)
        {
            string query = "INSERT INTO tblCTHDXuat(MaHDXuat,MaNL,DonGia,SoLuong) VALUES(@MaHDXuat,@MaNL,@DonGia,@SoLuong)";
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@MaHDXuat", cthd.MaHDXuat);
            pars[1] = new SqlParameter("@MaNL", cthd.MaNL);
            pars[2] = new SqlParameter("@DonGia", cthd.DonGia);
            pars[3] = new SqlParameter("@SoLuong", cthd.SoLuong);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool CapNhatCTHDXuat(CTHDXuatDTO cthd)
        {
            string query = "UPDATE tblCTHDXuat SET SoLuong = @SoLuong WHERE MaHDXuat = @MaHDXuat AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDXuat", cthd.MaHDXuat);
            pars[1] = new SqlParameter("@MaNL", cthd.MaNL);
            pars[2] = new SqlParameter("@SoLuong", cthd.SoLuong);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool XoaCTHDXuat(int maHD, string maNL)
        {
            string query = "DELETE FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteDeleteQuery(query, pars) == 1;
        }

        public static bool KiemTraMaNLTonTai(int maHD, string maNL)
        {
            string query = "SELECT COUNT(*) FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@MaNL", maNL);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]) == 1;
        }

        public static bool CapNhatSoLuong(int soLuong, int maHD, string maNL)
        {
            string query = "UPDATE tblCTHDXuat SET SoLuong = @SoLuong WHERE MaHDXuat = @MaHDXuat AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDXuat", maHD);
            pars[1] = new SqlParameter("@SoLuong", soLuong);
            pars[2] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static int LaySoLuongHienTai(int maHD, string maNL)
        {
            try
            {
                string query = "SELECT SoLuong FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat AND MaNL = @MaNL";
                SqlParameter[] pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@MaHDXuat", maHD);
                pars[1] = new SqlParameter("@MaNL", maNL);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

        public static int LayMaHDXuatTrongCTHDXuat(int maHD)
        {
            try
            {
                string query = "SELECT MaHDXuat FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat";
                SqlParameter[] pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MaHDXuat", maHD);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }

        }

        public static string LayMaNLTrongCTHDXuat(int maHD)
        {
            string query = "SELECT MaNL FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("MaHDXuat", maHD);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }

        // Dem so luong MaNL trong CTHDXuat
        public static int DemSoLuongMaNLCoTrongCTHD(int maHD)
        {
            try
            {
                string query = "SELECT COUNT(MaNL) FROM tblCTHDXuat WHERE MaHDXuat = @MaHDXuat";
                SqlParameter[] pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MaHDXuat",maHD);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }

    }
}
