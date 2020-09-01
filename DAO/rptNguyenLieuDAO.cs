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
    public static class rptNguyenLieuDAO
    {
        public static List<rptNguyenLieuDTO> ReportLayDSNguyenLieu()
        {
            List<rptNguyenLieuDTO> result = new List<rptNguyenLieuDTO>();
            string query = "select tblNguyenLieu.MaNL, TenNL, tblLoaiNguyenLieu.TenLoaiNL, tblNhaCungCap.TenNhaCC, DonViTinh, DonGia, SoLuongTonKho from tblNguyenLieu,tblLoaiNguyenLieu,tblNhaCungCap where tblNguyenLieu.MaLoaiNL = tblLoaiNguyenLieu.MaLoaiNL AND tblNguyenLieu.MaNCC = tblNhaCungCap.MaNCC";
            SqlParameter[] pars = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptNguyenLieuDTO rptNL = new rptNguyenLieuDTO();
                rptNL.MaNL = dr["MaNL"].ToString();
                rptNL.TenNL = dr["TenNL"].ToString();
                rptNL.TenLoaiNL = dr["TenLoaiNL"].ToString();
                rptNL.TenNCC = dr["TenNhaCC"].ToString();
                rptNL.DonViTinh = dr["DonViTinh"].ToString();
                rptNL.DonGia = Convert.ToInt32(dr["DonGia"]);
                rptNL.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
                result.Add(rptNL);
            }
            return result;
        }

        public static List<rptNguyenLieuDTO> ReportLayDSMonAnTheoMaLoaiNL(string maLoaiNL)
        {
            List<rptNguyenLieuDTO> result = new List<rptNguyenLieuDTO>();
            string query = "select tblNguyenLieu.MaNL, TenNL, tblNhaCungCap.TenNhaCC, DonViTinh, DonGia, SoLuongTonKho from tblNguyenLieu,tblLoaiNguyenLieu,tblNhaCungCap where tblNguyenLieu.MaLoaiNL = tblLoaiNguyenLieu.MaLoaiNL AND tblNguyenLieu.MaNCC = tblNhaCungCap.MaNCC AND tblLoaiNguyenLieu.MaLoaiNL = @MaLoaiNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaLoaiNL", maLoaiNL);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptNguyenLieuDTO rptNL = new rptNguyenLieuDTO();
                rptNL.MaNL = dr["MaNL"].ToString();
                rptNL.TenNL = dr["TenNL"].ToString();
                rptNL.TenNCC = dr["TenNhaCC"].ToString();
                rptNL.DonViTinh = dr["DonViTinh"].ToString();
                rptNL.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
                rptNL.DonGia = Convert.ToInt32(dr["DonGia"]);
                result.Add(rptNL);
            }
            return result;
        }

        public static LoaiNguyenLieuDTO ReportLayMaLoaiNL(string maLoaiNL)
        {
            LoaiNguyenLieuDTO result = null;
            string query = "select MaLoaiNL,TenLoaiNL from tblLoaiNguyenLieu where MaLoaiNL = @MaLoaiNL";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaLoaiNL", maLoaiNL);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                LoaiNguyenLieuDTO rptNL = new LoaiNguyenLieuDTO();
                rptNL.MaLoaiNL = dr["MaLoaiNL"].ToString();
                rptNL.TenLoaiNL = dr["TenLoaiNL"].ToString();
                result = (rptNL);
            }
            return result;
        }
    }
}
