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
    public static class rptCTHDNhapDAO
    {
        public static List<rptCTHDNhapDTO> ReportLayDSCTHDNhap(int maHD)
        {
            List<rptCTHDNhapDTO> result = new List<rptCTHDNhapDTO>();
            string query = "select tblCTHDNhap.MaHDNhap, tblNguyenLieu.TenNL, tblCTHDNhap.DonGia,SoLuong from tblCTHDNhap,tblNguyenLieu, tblHDNhap where tblCTHDNhap.MaNL = tblNguyenLieu.MaNL AND tblCTHDNhap.MaHDNhap = tblHDNhap.MaHDNhap AND tblCTHDNhap.MaHDNhap = @MaHDNhap";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDNhap",maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDNhapDTO rptCTHDNhap = new rptCTHDNhapDTO();
                rptCTHDNhap.MaHDNhap = Convert.ToInt32(dr["MaHDNhap"]);
                rptCTHDNhap.TenNL = dr["TenNL"].ToString();
                rptCTHDNhap.DonGia = Convert.ToInt32(dr["DonGia"]);
                rptCTHDNhap.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                result.Add(rptCTHDNhap);
            }
            return result;
        }
    }
}
