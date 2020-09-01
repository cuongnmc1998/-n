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
    public static class MonDAO
    {
        public static List<MonDTO> LayDanhSachMon(string timKiem, bool trangThai)
        {
            List<MonDTO> result = new List<MonDTO>();
            string query = "select MaMon,tblMonAn.MaLoaiMon,TenMon,DonGia,HinhAnh,tblMonAn.TrangThai from tblMonAn,tblLoaiMonAn Where tblMonAn.MaLoaiMon = tblLoaiMonAn.MaLoaiMon AND tblLoaiMonAn.TrangThai = 1 AND 1 = 1 ";
            SqlParameter[] parameter;
            if (timKiem != "")
            {
                query += "AND TenMon LIKE N'%'+@timKiem+'%'";
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@timKiem", timKiem);
            }
            else
            {
                parameter = new SqlParameter[0];
            }

            if (trangThai)
            {
                query += " AND tblMonAn.TrangThai = 1";
            }
            else
            {
                query += " AND tblMonAn.TrangThai = 0";
            }

            DataTable dtb = DataProvider.ExecuteSelectQuery(query, parameter);
            foreach (DataRow r in dtb.Rows)
            {
                MonDTO mon = new MonDTO();
                mon.MaMon = r["MaMon"].ToString();
                mon.MaLoaiMon = r["MaLoaiMon"].ToString();
                mon.TenMon = r["TenMon"].ToString();
                mon.DonGia = Convert.ToInt32(r["DonGia"]);
                mon.HinhAnh = r["HinhAnh"].ToString();
                mon.TrangThai = Convert.ToBoolean(r["TrangThai"]);
                result.Add(mon);
            }
            return result;
        }

        //Lấy DS món theo loại
        public static List<MonDTO> LayDSMonAnTheoLoai(string maLoai)
        {
            List<MonDTO> result = new List<MonDTO>();
            string query = "select MaMon,MaLoaiMon,TenMon,DonGia,HinhAnh,TrangThai from tblMonAn Where MaLoaiMon = @MaLoaiMon AND TrangThai = 1 ";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaLoaiMon", maLoai);
            DataTable dtb = DataProvider.ExecuteSelectQuery(query, parameter);
            foreach (DataRow r in dtb.Rows)
            {
                MonDTO mon = new MonDTO();
                mon.MaMon = r["MaMon"].ToString();
                mon.MaLoaiMon = r["MaLoaiMon"].ToString();
                mon.TenMon = r["TenMon"].ToString();
                mon.DonGia = Convert.ToInt32(r["DonGia"]);
                mon.HinhAnh = r["HinhAnh"].ToString();
                mon.TrangThai = Convert.ToBoolean(r["TrangThai"]);
                result.Add(mon);
            }
            return result;
        }

        //Lấy tên món ăn 
        public static string LayTenMonAn(string maMon)
        {
            string query = "SELECT TenMon FROM tblMonAn WHERE MaMon = @MaMon";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@MaMon", maMon);
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
        //Lấy Ds  món ăn có trạng thái hủy 0
        public static DataTable LayDSMonAnBiXoa()
        {
            string query = "SELECT * FROM tblMonAn WHERE TrangThai = 0";
            SqlParameter[] parameter = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, parameter);
        }

        //Lấy đơn giá của món ăn
        public static int LayDonGiaMonAn(string maMon)
        {
            string query = "SELECT DonGia FROM tblMonAn WHERE MaMon = @MaMon";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@MaMon", maMon);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, parameter).Rows[0][0]);
        }

        public static bool XoaMon(string maMon)
        {
            string query = "UPDATE tblMonAn SET TrangThai=0 WHERE MaMon=@maMon ";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@maMon", maMon);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }

        public static bool ThemMon(MonDTO mon)
        {
            string query = "INSERT INTO tblMonAn ([MaMon],[MaLoaiMon],[TenMon],[DonGia],[HinhAnh],[TrangThai]) VALUES (@maMon,@maLoaiMon,@tenMon,@donGia,@hinhAnh,@trangThai)";
            SqlParameter[] parameter = new SqlParameter[6];
            parameter[0] = new SqlParameter("@maMon",mon.MaMon);
            parameter[1] = new SqlParameter("@maLoaiMon", mon.MaLoaiMon);
            parameter[2] = new SqlParameter("@tenMon", mon.TenMon);
            parameter[3] = new SqlParameter("@donGia", mon.DonGia);
            parameter[4] = new SqlParameter("@hinhAnh", mon.HinhAnh);
            parameter[5] = new SqlParameter("@trangThai", true);
        

            int result = DataProvider.ExecuteInsertQuery(query, parameter);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool SuaMon(MonDTO mon)
        {
            string query = "UPDATE tblMonAn SET MaLoaiMon=@maLoaiMon,TenMon=@tenMon,DonGia=@donGia,HinhAnh=@hinhAnh,TrangThai=@trangThai WHERE MaMon=@maMon";
            SqlParameter[] parameter = new SqlParameter[6];
            parameter[0] = new SqlParameter("@maMon", mon.MaMon);
            parameter[1] = new SqlParameter("@maLoaiMon", mon.MaLoaiMon);
            parameter[2] = new SqlParameter("@tenMon", mon.TenMon);
            parameter[3] = new SqlParameter("@donGia", mon.DonGia);
            parameter[4] = new SqlParameter("@hinhAnh", mon.HinhAnh);
            parameter[5] = new SqlParameter("@trangThai", mon.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }

        public static bool KhoiPhuc(MonDTO mon)
        {
            string query = "UPDATE tblMonAn SET MaLoaiMon=@maLoaiMon,TenMon=@tenMon,DonGia=@donGia,TrangThai=@trangThai WHERE MaMon=@maMon";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@maMon", mon.MaMon);
            parameter[1] = new SqlParameter("@maLoaiMon", mon.MaLoaiMon);
            parameter[2] = new SqlParameter("@tenMon", mon.TenMon);
            parameter[3] = new SqlParameter("@donGia", mon.DonGia);
            parameter[4] = new SqlParameter("@trangThai", mon.TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, parameter) == 1;
        }

        public static string LayTenHinhHienTai(string maMon)
        {
            string query = "SELECT HinhAnh FROM tblMonAn WHERE MaMon = @maMon";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@maMon", maMon);    
            return DataProvider.ExecuteSelectQuery(query, parameter).Rows[0][0].ToString();
        }

        public static string LayMaMonLonNhat()
        {
            string query = "SELECT MAX(MaMon) FROM tblMonAn";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
       
        
    }
}
