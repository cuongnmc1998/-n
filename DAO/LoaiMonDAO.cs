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
    public static class LoaiMonDAO
    {
        public static List<LoaiMonDTO> LayDanhSachLoaiMon(string timKiem, bool trangThai)
        {
            List<LoaiMonDTO> result = new List<LoaiMonDTO>();
            string query = "select MaLoaiMon,TenLoaiMon,TrangThai from tblLoaiMonAn Where 1 = 1";
            SqlParameter[] parameter;
            if (timKiem != "")
            {
                query += " AND TenLoaiMon LIKE N'%'+@timKiem+'%'";
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@timKiem", timKiem);
            }
            else
            {
                parameter = new SqlParameter[0];
            }

            if (trangThai)
            {
                query += " AND TrangThai = 1";
            }
            else
            {
                query += " AND TrangThai = 0";
            }

            DataTable dtb = DataProvider.ExecuteSelectQuery(query, parameter);
            foreach (DataRow r in dtb.Rows)
            {
                LoaiMonDTO loaiMon = new LoaiMonDTO();
                loaiMon.MaLoaiMon = r["MaLoaiMon"].ToString();
                loaiMon.TenLoaiMon = r["TenLoaiMon"].ToString();
                loaiMon.TrangThai = Convert.ToBoolean(r["TrangThai"]);
                result.Add(loaiMon);
            }
            return result;
        }
        //Lấy Ds loại món ăn có trạng thái hủy 0
        public static DataTable LayDSLoaiMonAnBiXoa()
        {
            string query = "SELECT * FROM tblLoaiMonAn WHERE TrangThai = 0";
            SqlParameter[] parameter = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }
        public static bool ThemLoaiMon(LoaiMonDTO loaiMon)
        {
            string query = "INSERT INTO tblLoaiMonAn ([MaLoaiMon],[TenLoaiMon],[TrangThai]) VALUES (@maLoaiMon,@tenLoaiMon,@TrangThai)";
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@maloaiMon", loaiMon.MaLoaiMon);
            parameter[1] = new SqlParameter("@tenLoaiMon", loaiMon.TenLoaiMon);
            parameter[2] = new SqlParameter("@trangThai", true);

            int result = DataProvider.ExecuteInsertQuery(query, parameter);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool SuaLoaiMon(LoaiMonDTO loaiMon)
        {
            string query = "UPDATE tblLoaiMonAn SET TenLoaiMon=@tenLoaiMon,TrangThai=@trangThai WHERE MaLoaiMon=@maLoaiMon";
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@maLoaiMon", loaiMon.MaLoaiMon);    
            parameter[1] = new SqlParameter("@tenLoaiMon", loaiMon.TenLoaiMon);
            parameter[2] = new SqlParameter("@trangThai", loaiMon.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }

        public static bool XoaLoaiMon(string maLoaiMon)
        {
            string query = "UPDATE tblLoaiMonAn SET TrangThai=0 WHERE MaLoaiMon=@maLoaiMon ";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@maLoaiMon", maLoaiMon);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;

        }

        public static string LayMaLoaiMonLonNhat()
        {
            string query = "SELECT MAX(MaLoaiMon) FROM tblLoaiMonAn";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }

        
    }
}
