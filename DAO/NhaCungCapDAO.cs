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
    public class NhaCungCapDAO
    {
        //Lấy DS nhà cung cấp
        public static DataTable LayDSNhaCungCap()
        {
            string query = "SELECT * FROM tblNhaCungCap WHERE TrangThai =  1";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Lấy DS nhà cung cấp bị xóa
        public static DataTable LayDSNhaCungCapBiXoa()
        {
            string query = "SELECT * FROM tblNhaCungCap WHERE TrangThai =  0";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Lấy mã nhà cung cấp lớn nhất
        public static string LayMaxMaNCC()
        {
            string query = "SELECT MAX(MaNCC) FROM tblNhaCungCap";
            SqlParameter[] pars = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, pars).Rows[0][0].ToString();
        }
        //Tìm kiếm nhà cung cấp theo tên nhà cung cấp
        public static DataTable TimKiemNCC(string tKiem)
        {
            string query = "SELECT * FROM tblNhaCungCap WHERE TenNhaCC LIKE @TenNhaCC AND TrangThai = 1";
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@TenNhaCC", tKiem);
            return DataProvider.ExecuteSelectQuery(query, pars);
        }
        //Thêm nhà cung cấp mới
        public static bool ThemNhaCungCap(NhaCungCapDTO nccDTO)
        {
            string query = "INSERT INTO tblNhaCungCap(MaNCC, TenNhaCC, DiaChiNCC, SDTNCC, EmailNCC, TrangThai) VALUES(@MaNCC, @TenNhaCC, @DiaChiNCC, @SDTNCC, @EmailNCC, @TrangThai)";
            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("@MaNCC", nccDTO.MaNCC);
            pars[1] = new SqlParameter("@TenNhaCC", nccDTO.TenNhaCC);
            pars[2] = new SqlParameter("@DiaChiNCC", nccDTO.DiaChiNCC);
            pars[3] = new SqlParameter("@SDTNCC", nccDTO.SDTNCC);
            pars[4] = new SqlParameter("@EmailNCC", nccDTO.EmailNCC);
            pars[5] = new SqlParameter("@TrangThai", nccDTO.TrangThai);
            return Convert.ToInt32(DataProvider.ExecuteInsertQuery(query, pars)) > 0;
        }
        //Cập nhật nhà cung cấp
        public static bool CapNhatNhaCungCap(NhaCungCapDTO nccDTO)
        {
            string query = "UPDATE tblNhaCungCap SET TenNhaCC = @TenNhaCC, DiaChiNCC = @DiaChiNCC, SDTNCC = @SDTNCC, EmailNCC = @EmailNCC, TrangThai = @TrangThai WHERE MaNCC = @MaNCC";
            SqlParameter[] pars = new SqlParameter[6];
            pars[0] = new SqlParameter("@MaNCC", nccDTO.MaNCC);
            pars[1] = new SqlParameter("@TenNhaCC", nccDTO.TenNhaCC);
            pars[2] = new SqlParameter("@DiaChiNCC", nccDTO.DiaChiNCC);
            pars[3] = new SqlParameter("@SDTNCC", nccDTO.SDTNCC);
            pars[4] = new SqlParameter("@EmailNCC", nccDTO.EmailNCC);
            pars[5] = new SqlParameter("@TrangThai", nccDTO.TrangThai);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(query, pars)) > 0;
        }
        //Cập nhật trạng thái (0: Xóa / 1: Tồn tại)
        public static bool CapNhatTrangThai(string maNCC, int trThai)
        {
            string query = "UPDATE tblNhaCungCap SET TrangThai = @TrangThai WHERE MaNCC = @MaNCC";
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("@MaNCC", maNCC);
            pars[1] = new SqlParameter("@TrangThai", trThai);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(query, pars)) > 0;
        }
    }
}
