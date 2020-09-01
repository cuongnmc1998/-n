using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptHDBanHangDTO
    {
        int _maHD;
        string _hoTen;
        DateTime _ngayLapHD;
        int _tongTien;
        int _tienCuaKH;
        int _tienThua;
        string _ghiChu;
        int _trangThai;
        bool _tonTai;
        int _soLuong;
        int _tongThu;


        public int MaHD { get => _maHD; set => _maHD = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public DateTime NgayLapHD { get => _ngayLapHD; set => _ngayLapHD = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
        public bool TonTai { get => _tonTai; set => _tonTai = value; }
        public int TienCuaKH { get => _tienCuaKH; set => _tienCuaKH = value; }
        public int TienThua { get => _tienThua; set => _tienThua = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int TongThu { get => _tongThu; set => _tongThu = value; }
    }
}
