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
    public static class rptMonAnDAO
    {
        public static List<rptMonAnDTO> ReportLayDSMonAn()
        {
            List<rptMonAnDTO> result = new List<rptMonAnDTO>();
            string query = "SELECT tblMonAn.MaMon,tblMonAn.TenMon, tblLoaiMonAn.TenLoaiMon, tblMonAn.DonGia FROM tblMonAn,tblLoaiMonAn WHERE tblMonAn.MaLoaiMon=tblLoaiMonAn.MaLoaiMon";
            SqlParameter[] pars = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptMonAnDTO rptMon = new rptMonAnDTO();
                rptMon.MaMon = dr["MaMon"].ToString();
                rptMon.TenMon = dr["TenMon"].ToString();
                rptMon.TenLoaiMon = dr["TenLoaiMon"].ToString();
                rptMon.DonGia = Convert.ToInt32(dr["DonGia"]);
                result.Add(rptMon);
            }
            return result;
        }

        public static List<rptMonAnDTO> ReportLayDSMonAnTheoMaLoaiMon(string maLoaiMon)
        {
            List<rptMonAnDTO> result = new List<rptMonAnDTO>();
            string query = "SELECT tblMonAn.MaMon,tblMonAn.TenMon, tblMonAn.DonGia FROM tblMonAn,tblLoaiMonAn WHERE tblMonAn.MaLoaiMon=tblLoaiMonAn.MaLoaiMon AND tblLoaiMonAn.MaLoaiMon = @MaLoaiMon";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaLoaiMon",maLoaiMon);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptMonAnDTO rptMon = new rptMonAnDTO();
                rptMon.MaMon = dr["MaMon"].ToString();
                rptMon.TenMon = dr["TenMon"].ToString();
                rptMon.DonGia = Convert.ToInt32(dr["DonGia"]);
                result.Add(rptMon);
            }
            return result;
        }

        public static LoaiMonDTO ReportLayMaLoaiMon(string maLoaiMon)
        {
            LoaiMonDTO result = null;
            string query = "select MaLoaiMon,TenLoaiMon from tblLoaiMonAn where MaLoaiMon = @MaLoaiMon";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaLoaiMon", maLoaiMon);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                LoaiMonDTO rptMon = new LoaiMonDTO();
                rptMon.MaLoaiMon = dr["MaLoaiMon"].ToString();
                rptMon.TenLoaiMon = dr["TenLoaiMon"].ToString();
                result = (rptMon);
            }
            return result;
        }
    }
}
