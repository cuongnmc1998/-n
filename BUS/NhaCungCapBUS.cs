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
    public class NhaCungCapBUS
    {
        //Lấy DS nhà cung cấp
        public static DataTable LayDSNhaCungCap()
        {
            return NhaCungCapDAO.LayDSNhaCungCap();
        }
        //Lấy DS nhà cung cấp bị xóa
        public static DataTable LayDSNhaCungCapBiXoa()
        {
            return NhaCungCapDAO.LayDSNhaCungCapBiXoa();
        }
            //Lấy mã nhà cung cấp lớn nhất
        public static string LayMaxMaNCC()
        {
            string MaxMaNCC = NhaCungCapDAO.LayMaxMaNCC();
            if (MaxMaNCC != null)
            {
                int ChuyenSo = int.Parse(MaxMaNCC.Replace("NCC", ""));
                return "NCC" + (ChuyenSo + 1).ToString("000");
            }
            return "NCC001";
        }
        //Tìm kiếm nhà cung cấp theo tên nhà cung cấp
        public static DataTable TimKiemNCC(string tKiem)
        {
            return NhaCungCapDAO.TimKiemNCC(tKiem);
        }
        //Thêm nhà cung cấp mới
        public static bool ThemNhaCungCap(NhaCungCapDTO nccDTO)
         {
            return NhaCungCapDAO.ThemNhaCungCap(nccDTO);
        }
        //Cập nhật nhà cung cấp
        public static bool CapNhatNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return NhaCungCapDAO.CapNhatNhaCungCap(nccDTO);
        }
        //Cập nhật trạng thái (0: Xóa / 1: Tồn tại)
        public static bool CapNhatTrangThai(string maNCC, int trThai)
        {
            return NhaCungCapDAO.CapNhatTrangThai(maNCC, trThai);
        }
    }
}
