using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public static class LoaiNguyenLieuBUS
    {
        public static DataTable LoadDSLoaiNguyenLieu()
        {
            return LoaiNguyenLieuDAO.LayDSLoaiNguyenLieu();
        }

        public static bool ThemLoaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            return LoaiNguyenLieuDAO.ThemLoaiNguyenLieu(loaiNL);
        }

        public static bool CapNhatLoaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            return LoaiNguyenLieuDAO.CapNhatLoaiNguyenLieu(loaiNL);
        }

        public static bool XoaLoaiNguyenLieu(string maLoaiNL)
        {
            return LoaiNguyenLieuDAO.XoaLoaiNguyenLieu(maLoaiNL);
        }

        public static DataTable TimKiemTheoTenLoaiNguyenLieu(string tenLoaiNL)
        {
            return LoaiNguyenLieuDAO.TimKiemTheoTenLoaiNguyenLieu(tenLoaiNL);
        }

        public static DataTable LayDSLoaiNguyenLieuKhongConSuDung()
        {
            return LoaiNguyenLieuDAO.LayDSLoaiNguyenLieuKhongConSuDung();
        }

        public static bool KhoiPhucTrangThaiNguyenLieu(LoaiNguyenLieuDTO loaiNL)
        {
            return LoaiNguyenLieuDAO.KhoiPhucTrangThaiNguyenLieu(loaiNL);
        }

        public static string LayMaLoaiNLLonNhat()
        {
            string maLoaiNLMax = LoaiNguyenLieuDAO.LayMaLoaiNLLonNhat();
            if (maLoaiNLMax != null)
            {
                int chuyenSo = int.Parse(maLoaiNLMax.Replace("LNL", ""));
                return "LNL" + (chuyenSo + 1).ToString("00");
            }
            return "LNL01";
        }
    }
}
