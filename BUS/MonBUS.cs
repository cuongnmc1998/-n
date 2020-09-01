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
    public static class MonBUS
    {
        public static List<MonDTO> LayDanhSachMon(string timKiem, bool trangThai = true)
        {
            return MonDAO.LayDanhSachMon(timKiem, trangThai);
        }
        //Lấy DS món theo loại
        public static List<MonDTO> LayDSMonAnTheoLoai(string maLoai)
        {
            return MonDAO.LayDSMonAnTheoLoai(maLoai);
        }
        //Lấy tên món ăn 
        public static string LayTenMonAn(string maMon)
        {
            return MonDAO.LayTenMonAn(maMon);
        }
        //Lấy đơn giá món ăn
        public static int LayDonGiaMonAn(string maMon)
        {
            return MonDAO.LayDonGiaMonAn(maMon);
        }
        public static bool ThemMon(MonDTO mon)
        {
            return MonDAO.ThemMon(mon);
        }

        public static bool XoaMon(string maMon)
        {
            return MonDAO.XoaMon(maMon);
        }

        public static bool SuaMon(MonDTO mon)
        {
            return MonDAO.SuaMon(mon);
        }
        
        public static bool KhoiPhuc(MonDTO mon)
        {
            return MonDAO.KhoiPhuc(mon);
        }

        public static DataTable LayDSMonAnBiXoa()
        {
            return MonDAO.LayDSMonAnBiXoa();
        }

        public static string LayMaMonLonNhat()
        {
            string maMonMax = MonDAO.LayMaMonLonNhat();
            if (maMonMax != null)
            {
                int chuyenSo = int.Parse(maMonMax.Replace("MA", ""));
                return "MA" + (chuyenSo + 1).ToString("000");
            }
            return "MA001";
        }

        public static string LayTenHinhHienTai(string maMon)
        {
            return MonDAO.LayTenHinhHienTai(maMon);
        }

        
    }
}
