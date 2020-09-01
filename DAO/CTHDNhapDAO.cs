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
    public static class CTHDNhapDAO
    {
        public static DataTable LayDSCTHDNhap(int maHD)
        {
            string query = "SELECT [MaHDNhap],[MaNL],[DonGia],[SoLuong] FROM [tblCTHDNhap] WHERE MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static bool ThemCTHDHDNhap(CTHDNhapDTO cthd)
        {
            string query = "INSERT INTO tblCTHDNhap(MaHDNhap,MaNL,DonGia,SoLuong) VALUES(@MaHDNhap,@MaNL,@DonGia,@SoLuong)";
            SqlParameter[] pars = new SqlParameter[4];
            pars[0] = new SqlParameter("@MaHDNhap",cthd.MaHDNhap);
            pars[1] = new SqlParameter("@MaNL", cthd.MaNL);
            pars[2] = new SqlParameter("@DonGia", cthd.DonGia);
            pars[3] = new SqlParameter("@SoLuong", cthd.SoLuong);
            return DataProvider.ExecuteInsertQuery(query, pars) == 1;
        }

        public static bool CapNhatCTHDNhap(CTHDNhapDTO cthd)
        {
            string query = "UPDATE tblCTHDNhap SET SoLuong = @SoLuong WHERE MaHDNhap = @MaHDNhap AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDNhap", cthd.MaHDNhap);
            pars[1] = new SqlParameter("@MaNL", cthd.MaNL);
            pars[2] = new SqlParameter("@SoLuong", cthd.SoLuong);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static bool XoaCTHDNhap(int maHDNhap, string maNL)
        {
            string query = "DELETE FROM tblCTHDNhap WHERE MaHDNhap = @MaHDNhap AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDNhap",maHDNhap);
            pars[1] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteDeleteQuery(query, pars) == 1;
        }

        public static bool KiemTraMaNLTonTai(int maHD, string maNL)
        {
            string query = "SELECT COUNT(*) FROM tblCTHDNhap WHERE MaHDNhap = @MaHDNhap AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            pars[1] = new SqlParameter("@MaNL", maNL);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]) == 1;
        }

        public static bool CapNhatSoLuong(int soLuong,int maHD,string maNL)
        {
            string query = "UPDATE tblCTHDNhap SET SoLuong = @SoLuong WHERE MaHDNhap = @MaHDNhap AND MaNL = @MaNL";
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@MaHDNhap", maHD);
            pars[1] = new SqlParameter("@SoLuong",soLuong);
            pars[2] = new SqlParameter("@MaNL", maNL);
            return DataProvider.ExecuteUpdateQuery(query, pars) == 1;
        }

        public static int LaySoLuongHienTai(int maHD, string maNL)
        {
            try
            {
                string query = "SELECT SoLuong FROM tblCTHDNhap WHERE MaHDNhap = @MaHDNhap AND MaNL = @MaNL";
                SqlParameter[] pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@MaHDNhap",maHD);
                pars[1] = new SqlParameter("@MaNL", maNL);
                return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0]);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }
    }
}
