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
    public static class rptCTHDXuatDAO
    {
        public static List<rptCTHDXuatDTO> ReportLayDSCTHDXuat(int maHD)
        {
            List<rptCTHDXuatDTO> result = new List<rptCTHDXuatDTO>();
            string query = "select tblCTHDXuat.MaHDXuat, tblNguyenLieu.TenNL, tblCTHDXuat.DonGia,SoLuong from tblCTHDXuat,tblNguyenLieu, tblHDXuat where tblCTHDXuat.MaNL = tblNguyenLieu.MaNL AND tblCTHDXuat.MaHDXuat = tblHDXuat.MaHDXuat AND tblCTHDXuat.MaHDXuat = @MaHDXuat ";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHDXuat",maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDXuatDTO rptCTHDXuat = new rptCTHDXuatDTO();
                rptCTHDXuat.MaHDXuat = Convert.ToInt32(dr["MaHDXuat"]);
                rptCTHDXuat.TenNL = dr["TenNL"].ToString();
                rptCTHDXuat.DonGia = Convert.ToInt32(dr["DonGia"]);
                rptCTHDXuat.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                result.Add(rptCTHDXuat);
            }
            return result;
        }
    }
}
