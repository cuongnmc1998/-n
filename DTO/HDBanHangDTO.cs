using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDBanHangDTO
    {
        int _maHD; 
        string _tenTaiKhoan;
        DateTime _ngayLapHD;
        int _tongTien;
        int _tienCuaKH;
        int _tienThua;
        string _ghiChu;
        int _trangThai;
        int _tonTai;

        public int MaHD { get => _maHD; set => _maHD = value; }
        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public DateTime NgayLapHD { get => _ngayLapHD; set => _ngayLapHD = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public int TonTai { get => _tonTai; set => _tonTai = value; }
        public int TienCuaKH { get => _tienCuaKH; set => _tienCuaKH = value; }
        public int TienThua { get => _tienThua; set => _tienThua = value; }
    }
}
