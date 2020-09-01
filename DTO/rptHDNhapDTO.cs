using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptHDNhapDTO
    {
        int _maHDNhap;
        string _hoTen;
        string _tenNhaCC;
        DateTime _ngayNhap;
        int _tongTien;
        int _trangThai;
        int _TonTai;

        public int MaHDNhap { get => _maHDNhap; set => _maHDNhap = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string TenNhaCC { get => _tenNhaCC; set => _tenNhaCC = value; }
        public DateTime NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
        public int TonTai { get => _TonTai; set => _TonTai = value; }
    }
}
