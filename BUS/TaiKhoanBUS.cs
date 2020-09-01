using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public static class TaiKhoanBUS
    {
        //Kiểm tra đăng nhập
       public static bool KiemTraDangNhap(string tenTK, string mKhau, int loaiTK)
       {
           if(TaiKhoanDAO.KiemTraTaiKhoanTonTai(tenTK))
           {
               if (TaiKhoanDAO.LayMatKhau(tenTK) == mKhau && TaiKhoanDAO.LayLoaiTaiKhoan(tenTK) == loaiTK)
                   return true;
               return false;
           }
           return false;
       }
        //Lấy tên tài khoản
        public static string LayTenNVTaiKhoan(string tenTK)
        {
            return TaiKhoanDAO.LayTenNVTaiKhoan(tenTK);
        }
        //Lấy DS tài khoản
        public static DataTable LayDSTaiKhoan()
        {
            return TaiKhoanDAO.LayDSTaiKhoan();
        }
        //Lấy DS tài khoản bị xóa
        public static DataTable LayDSTaiKhoanBiXoa()
        {
            return TaiKhoanDAO.LayDSTaiKhoanBiXoa();
        }
        //Lấy mật khẩu của tài khoản
        public static string LayMatKhau(string tenTK)
        {
            return TaiKhoanDAO.LayMatKhau(tenTK);
        }
        //Tìm kiếm tài khoản
        public static DataTable TimKiemTaiKhoan(string tKiem)
        {
            return TaiKhoanDAO.TimKiemTaiKhoan(tKiem);
        }
        //Tạo tài khoản mới
        public static bool TaoTaiKhoanMoi(TaiKhoanDTO tkDTO)
        {
            if (!TaiKhoanDAO.KiemTraTaiKhoanTonTai(tkDTO.TenTaiKhoan))
            {
                return TaiKhoanDAO.TaoTaiKhoanMoi(tkDTO);
            }
            return false;
        }
        //Cập nhật tài khoản
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tkDTO)
        {
            return TaiKhoanDAO.CapNhatTaiKhoan(tkDTO);
        }
        //Cập nhật trạng thái(0: Xóa / 1: Hoạt động)
        public static bool CapNhatTrangThai(string tenTK, int trThai)
        {
            return TaiKhoanDAO.CapNhatTrangThai(tenTK, trThai);
        }

        public static TaiKhoanDTO LayDSNhanVienChuCH()
        {
            DataRow dr = TaiKhoanDAO.LayDSNhanVienChuCH();
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            tk.MatKhau = dr["MatKhau"].ToString();
            return tk;
        }

        public static TaiKhoanDTO LayDSNhanVienQuanLy()
        {
            DataRow dr = TaiKhoanDAO.LayDSNhanVienQuanLy();
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            tk.MatKhau = dr["MatKhau"].ToString();
            return tk;
        }

        public static TaiKhoanDTO LayDSNhanVienCaTruong()
        {
            DataRow dr = TaiKhoanDAO.LayDSNhanVienCaTruong();
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            tk.MatKhau = dr["MatKhau"].ToString();
            return tk;
        }

        public static string PhanQuyenQuanLyTK(int laAdmin)
        {
            return TaiKhoanDAO.PhanQuyenQuanLyTK(laAdmin);
        }
    }
}
