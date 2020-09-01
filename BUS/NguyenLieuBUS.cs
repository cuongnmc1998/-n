using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public static class NguyenLieuBUS
    {
        public static DataTable LoadDSNguyenLieu()
        {
            return NguyenLieuDAO.LayDSNguyenLieu();
        }

        public static bool ThemNguyenLieu(NguyenLieuDTO nl)
        {
            return NguyenLieuDAO.ThemNguyenLieu(nl);
        }

        public static bool CapNhatNguyenLieu(NguyenLieuDTO nl)
        {
            return NguyenLieuDAO.CapNhatNguyenLieu(nl);
        }

        public static bool XoaNguyenLieu(string maNL)
        {
            return NguyenLieuDAO.XoaNguyenLieu(maNL);
        }

        public static DataTable TimKiemTheoTenNguyenLieu(string tenNL)
        {
            return NguyenLieuDAO.TimKiemTheoTenNguyenLieu(tenNL);
        }

        public static DataTable LoadDSNguyenLieuKhongConSuDung()
        {
            return NguyenLieuDAO.LayDSNguyenLieuKhongConSuDung();
        }

        public static bool KhoiPhucTrangThaiNguyenLieu(NguyenLieuDTO nl)
        {
            return NguyenLieuDAO.KhoiPhucTrangThaiNguyenLieu(nl);
        }

        public static string LayMaNLLonNhat()
        {
            string maNLMax = NguyenLieuDAO.LayMaNLLonNhat();
            if(maNLMax != null)
            {
                int chuyenSo = int.Parse(maNLMax.Replace("NL", ""));
                return "NL" + (chuyenSo + 1).ToString("000");
            }
            return "NL001";
        }

        // Lấy đơn giá load từ cboMaNL bên frmHDNhap
        public static int LayDonGiaTuMaNL(string maNL)
        {
            return NguyenLieuDAO.LayDonGiaTuMaNL(maNL);
        }

        // Lấy đơn vị tính load từ cboMaNL bên frmHDNhap/Xuat
        public static string LayDonViTinhTuMaNL(string maNL)
        {
            return NguyenLieuDAO.LayDonViTinhTuMaNL(maNL);
        }

        // Lấy số lượng tồn kho nguyên liệu
        public static int LaySoLuongTKNL(string maNL)
        {
            return NguyenLieuDAO.LaySoLuongTKNL(maNL);
        }

        // Cập nhật số lượng tồn kho khi xuất hóa đơn 
        public static bool CapNhatSoLuongTonKhoGiam(int maHD, string maNL,int sltk)
        {
            return NguyenLieuDAO.CapNhatSoLuongTonKhoGiam(maHD, maNL,sltk);
        }

        // Cập nhật số lượng tồn kho khi nhập hóa đơn 
        public static bool CapNhatSoLuongTonKhoTang(int maHD, string maNL, int sltk)
        {
            return NguyenLieuDAO.CapNhatSoLuongTonKhoTang(maHD, maNL, sltk);
        }

        public static DataTable LayDSMaNL()
        {
            return NguyenLieuDAO.LayDSMaNL();
        }
    }
}
