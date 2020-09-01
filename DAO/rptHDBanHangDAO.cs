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
    public class rptHDBanHangDAO
    {
        public static List<rptHDBanHangDTO> ReportLayDSHDBanHang()
        {
            List<rptHDBanHangDTO> result = new List<rptHDBanHangDTO>();
            string query = "select MaHD,tblTaiKhoan.HoTen,NgayLapHD,TongTien,TienCuaKH,TienThua,GhiChu from tblHDBanHang,tblTaiKhoan where tblHDBanHang.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan";
            SqlParameter[] pars = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDBanHangDTO rptHDBanHang = new rptHDBanHangDTO();
                rptHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptHDBanHang.HoTen = dr["HoTen"].ToString();
                rptHDBanHang.NgayLapHD = Convert.ToDateTime(dr["NgayLapHD"]);
                rptHDBanHang.TongTien = Convert.ToInt32(dr["TongTien"]);
                rptHDBanHang.TienCuaKH = Convert.ToInt32(dr["TienCuaKH"]);
                rptHDBanHang.TienThua = Convert.ToInt32(dr["TienThua"]);
                rptHDBanHang.GhiChu = dr["GhiChu"].ToString();
                result.Add(rptHDBanHang);
            }
            return result;
        }

        public static List<rptHDBanHangDTO> ReportLayHDBanHang(int maHD)
        {
            List<rptHDBanHangDTO> result = new List<rptHDBanHangDTO>();
            string query = "select MaHD,tblTaiKhoan.HoTen,NgayLapHD,TongTien,TienCuaKH,TienThua,GhiChu from tblHDBanHang,tblTaiKhoan where tblHDBanHang.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan AND tblHDBanHang.MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDBanHangDTO rptHDBanHang = new rptHDBanHangDTO();
                rptHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptHDBanHang.HoTen = dr["HoTen"].ToString();
                rptHDBanHang.NgayLapHD = Convert.ToDateTime(dr["NgayLapHD"]);
                rptHDBanHang.TongTien = Convert.ToInt32(dr["TongTien"]);
                rptHDBanHang.TienCuaKH = Convert.ToInt32(dr["TienCuaKH"]);
                rptHDBanHang.TienThua = Convert.ToInt32(dr["TienThua"]);
                rptHDBanHang.GhiChu = dr["GhiChu"].ToString();
                result.Add(rptHDBanHang);
            }
            return result;
        }

        public static List<rptHDBanHangDTO> ReportPhieuDatMon(int maHD)
        {
            List<rptHDBanHangDTO> result = new List<rptHDBanHangDTO>();
            string query = "select MaHD,tblTaiKhoan.HoTen,NgayLapHD from tblHDBanHang,tblTaiKhoan where tblHDBanHang.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan AND tblHDBanHang.MaHD = @MaHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("MaHD", maHD);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDBanHangDTO rptHDBanHang = new rptHDBanHangDTO();
                rptHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptHDBanHang.HoTen = dr["HoTen"].ToString();
                rptHDBanHang.NgayLapHD = Convert.ToDateTime(dr["NgayLapHD"]);
                result.Add(rptHDBanHang);
            }
            return result;
        }

        public static DataTable ReportNgayLap()
        {
            string query = "select distinct NgayLapHD from tblHDBanHang";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }

        public static List<rptHDBanHangDTO> ReportLayHDBanHangTheoNgay(DateTime ngayLap)
        {
            List<rptHDBanHangDTO> result = new List<rptHDBanHangDTO>();
            string query = "select MaHD,tblTaiKhoan.HoTen,NgayLapHD,TongTien,TienCuaKH,TienThua,GhiChu from tblHDBanHang,tblTaiKhoan where tblHDBanHang.TenTaiKhoan = tblTaiKhoan.TenTaiKhoan AND NgayLapHD = @NgayLapHD";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@NgayLapHD", ngayLap);
            DataTable dt = DataProvider.ExecuteSelectQuery(query, pars);
            foreach (DataRow dr in dt.Rows)
            {
                rptHDBanHangDTO rptHDBanHang = new rptHDBanHangDTO();
                rptHDBanHang.MaHD = Convert.ToInt32(dr["MaHD"]);
                rptHDBanHang.HoTen = dr["HoTen"].ToString();
                rptHDBanHang.NgayLapHD = Convert.ToDateTime(dr["NgayLapHD"]);
                rptHDBanHang.TongTien = Convert.ToInt32(dr["TongTien"]);
                rptHDBanHang.TienCuaKH = Convert.ToInt32(dr["TienCuaKH"]);
                rptHDBanHang.TienThua = Convert.ToInt32(dr["TienThua"]);
                rptHDBanHang.GhiChu = dr["GhiChu"].ToString();
                result.Add(rptHDBanHang);
            }
            return result;
        }

        
    }
}
