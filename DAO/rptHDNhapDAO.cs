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
    public static class rptHDNhapDAO
    {
        public static List<rptHDNhapDTO> ReportLayDSHDNhap()
        {
            List<rptHDNhapDTO> result = new List<rptHDNhapDTO>();
            string query = "select MaHDNhap, tblTaiKhoan.HoTen,tblNhaCungCap.TenNhaCC,NgayNhap,TongTien,tblHDNhap.TrangThai,TonTai from tblHDNhap,tblNhaCungCap,tblTaiKhoan where tblHDNhap.MaNCC = tblNhaCungCap.MaNCC AND tblHDNhap.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDNhapDTO rptHDNhap = new rptHDNhapDTO();
                rptHDNhap.MaHDNhap = Convert.ToInt32(dr["MaHDNhap"]);
                rptHDNhap.HoTen = dr["HoTen"].ToString();
                rptHDNhap.TenNhaCC = dr["TenNhaCC"].ToString();
                rptHDNhap.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
                rptHDNhap.TongTien = Convert.ToInt32(dr["TongTien"]);
                result.Add(rptHDNhap);
            }
            return result;
        }

        public static DataTable ReportNgayNhap()
        {
            string query = "select distinct NgayNhap from tblHDNhap";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static List<rptHDNhapDTO> ReportLayHDNhapTheoNgay(DateTime ngayNhap)
        {
            List<rptHDNhapDTO> result = new List<rptHDNhapDTO>();
            string query = "select MaHDNhap, tblTaiKhoan.HoTen,tblNhaCungCap.TenNhaCC,NgayNhap,TongTien from tblHDNhap,tblNhaCungCap,tblTaiKhoan where tblHDNhap.MaNCC = tblNhaCungCap.MaNCC AND tblHDNhap.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan AND NgayNhap = @NgayNhap";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@NgayNhap", ngayNhap);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDNhapDTO rptHDNhap = new rptHDNhapDTO();
                rptHDNhap.MaHDNhap = Convert.ToInt32(dr["MaHDNhap"]);
                rptHDNhap.HoTen = dr["HoTen"].ToString();
                rptHDNhap.TenNhaCC = dr["TenNhaCC"].ToString();
                rptHDNhap.NgayNhap = Convert.ToDateTime(dr["NgayNhap"]);
                rptHDNhap.TongTien = Convert.ToInt32(dr["TongTien"]);
                result.Add(rptHDNhap);
            }
            return result;
        }

 
    }
}
