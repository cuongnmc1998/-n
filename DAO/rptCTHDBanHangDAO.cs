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
    public static class rptCTHDBanHangDAO
    {
        public static List<rptCTHDBanHangDTO> ReportLayDSCTHDBanHang(int maHD)
        {
            List<rptCTHDBanHangDTO> result = new List<rptCTHDBanHangDTO>();
            string query = "select tblCTHDBanHang.MaHD, tblMonAn.TenMon,tblCTHDBanHang.GhiChu, tblCTHDBanHang.DonGia,SoLuong from tblCTHDBanHang,tblMonAn, tblHDBanHang where tblCTHDBanHang.MaMon = tblMonAn.MaMon AND tblCTHDBanHang.MaHD= tblHDBanHang.MaHD AND tblCTHDBanHang.MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDBanHangDTO rptCTHDBanHang = new rptCTHDBanHangDTO();
                rptCTHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptCTHDBanHang.TenMon = dr["TenMon"].ToString();
                rptCTHDBanHang.GhiChu = dr["GhiChu"].ToString();
                rptCTHDBanHang.DonGia = Convert.ToInt32(dr["DonGia"]);
                rptCTHDBanHang.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                result.Add(rptCTHDBanHang);
            }
            return result;
        }

        public static List<rptCTHDBanHangDTO> ReportLaySubCTHDBanHang(int maHD)
        {
            List<rptCTHDBanHangDTO> result = new List<rptCTHDBanHangDTO>();
            string query = "select tblCTHDBanHang.MaHD, tblMonAn.TenMon,tblCTHDBanHang.GhiChu, tblCTHDBanHang.DonGia,SoLuong, (tblCTHDBanHang.DonGia * SoLuong) AS ThanhTien from tblCTHDBanHang,tblMonAn, tblHDBanHang  where tblCTHDBanHang.MaMon = tblMonAn.MaMon AND tblCTHDBanHang.MaHD= tblHDBanHang.MaHD AND tblCTHDBanHang.MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDBanHangDTO rptCTHDBanHang = new rptCTHDBanHangDTO();
                rptCTHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptCTHDBanHang.TenMon = dr["TenMon"].ToString();
                rptCTHDBanHang.GhiChu = dr["GhiChu"].ToString();
                rptCTHDBanHang.DonGia = Convert.ToInt32(dr["DonGia"]);
                rptCTHDBanHang.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                rptCTHDBanHang.ThanhTien = Convert.ToInt32(dr["ThanhTien"]);
                result.Add(rptCTHDBanHang);
            }
            return result;
        }

        public static rptCTHDBanHangDTO ReportLaySoLuongCTHDBH(int maHD)
        {
            rptCTHDBanHangDTO result = null;
            string query = "select MaHD,SUM(SoLuong)AS TongSoLuong from tblCTHDBanHang where MaHD = @MaHD group by MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDBanHangDTO rptCTHDBanHang = new rptCTHDBanHangDTO();
                rptCTHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptCTHDBanHang.TongSoLuong = Convert.ToInt32(dr["TongSoLuong"]);
                result = (rptCTHDBanHang);
            }
            return result;
        }

        public static List<rptCTHDBanHangDTO> ReportSubPhieuDatMon(int maHD)
        {
            List<rptCTHDBanHangDTO> result = new List<rptCTHDBanHangDTO>();
            string query = "select tblCTHDBanHang.MaHD, tblMonAn.TenMon,tblCTHDBanHang.GhiChu, SoLuong from tblCTHDBanHang,tblMonAn, tblHDBanHang where tblCTHDBanHang.MaMon = tblMonAn.MaMon AND tblCTHDBanHang.MaHD= tblHDBanHang.MaHD AND tblCTHDBanHang.MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptCTHDBanHangDTO rptCTHDBanHang = new rptCTHDBanHangDTO();
                rptCTHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptCTHDBanHang.TenMon = dr["TenMon"].ToString();
                rptCTHDBanHang.GhiChu = dr["GhiChu"].ToString();
                rptCTHDBanHang.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                result.Add(rptCTHDBanHang);
            }
            return result;
        }
    }
}
