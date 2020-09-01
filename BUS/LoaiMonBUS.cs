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
    public static class LoaiMonBUS
    {
        public static List<LoaiMonDTO> LayDanhSachLoaiMon(string timKiem = "", bool trangThai = true)
        {
            return LoaiMonDAO.LayDanhSachLoaiMon(timKiem, trangThai);
        }
        //Lấy Ds loại món ăn có trạng thái hủy 0
        public static DataTable LayDSLoaiMonAnBiXoa()
        {
            return LoaiMonDAO.LayDSLoaiMonAnBiXoa();

        } 
        public static bool XoaLoaiMon(string maLoaiMon)
        {
            return LoaiMonDAO.XoaLoaiMon(maLoaiMon);
        }

        public static bool SuaLoaiMon(LoaiMonDTO loaiMon)
        {
            return LoaiMonDAO.SuaLoaiMon(loaiMon);
        }

        public static bool ThemLoaiMon(LoaiMonDTO loaiMon)
        {
            return LoaiMonDAO.ThemLoaiMon(loaiMon);
        }

        public static string LayMaLoaiMonLonNhat()
        {
            string maLoaiMonMax = LoaiMonDAO.LayMaLoaiMonLonNhat();
            if (maLoaiMonMax != null)
            {
                int chuyenSo = int.Parse(maLoaiMonMax.Replace("LM", ""));
                return "LM" + (chuyenSo + 1).ToString("00");
            }
            return "LM01";
        }

    }
}
