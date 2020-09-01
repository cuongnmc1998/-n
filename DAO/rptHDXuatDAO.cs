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
    public static class rptHDXuatDAO
    {
        public static List<rptHDXuatDTO> ReportLayDSHDXuat()
        {
            List<rptHDXuatDTO> result = new List<rptHDXuatDTO>();
            string query = "select MaHDXuat, tblTaiKhoan.HoTen,NgayXuat,TongTien,tblHDXuat.TrangThai,TonTai from tblHDXuat,tblTaiKhoan where tblHDXuat.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDXuatDTO rptHDXuat = new rptHDXuatDTO();
                rptHDXuat.MaHDXuat = Convert.ToInt32(dr["MaHDXuat"]);
                rptHDXuat.HoTen = dr["HoTen"].ToString();
                rptHDXuat.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
                rptHDXuat.TongTien = Convert.ToInt32(dr["TongTien"]);
                result.Add(rptHDXuat);
            }
            return result;
        }

        public static DataTable ReportNgayXuat()
        {
            string query = "select distinct NgayXuat from tblHDXuat";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static List<rptHDXuatDTO> ReportLayHDXuatTheoNgay(DateTime ngayXuat)
        {
            List<rptHDXuatDTO> result = new List<rptHDXuatDTO>();
            string query = "select MaHDXuat, tblTaiKhoan.HoTen,NgayXuat,TongTien from tblHDXuat,tblTaiKhoan where tblHDXuat.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan AND NgayXuat = @NgayXuat";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@NgayXuat", ngayXuat);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDXuatDTO rptHDXuat = new rptHDXuatDTO();
                rptHDXuat.MaHDXuat = Convert.ToInt32(dr["MaHDXuat"]);
                rptHDXuat.HoTen = dr["HoTen"].ToString();
                rptHDXuat.NgayXuat = Convert.ToDateTime(dr["NgayXuat"]);
                rptHDXuat.TongTien = Convert.ToInt32(dr["TongTien"]);
                result.Add(rptHDXuat);
            }
            return result;
        }
    }
}
