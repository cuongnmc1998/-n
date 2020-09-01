using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDNhapDTO
    {
        int _maHDNhap;
        string _maNL;
        int _donGia;
        int _soLuong;

        public int MaHDNhap { get => _maHDNhap; set => _maHDNhap = value; }
        public string MaNL { get => _maNL; set => _maNL = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
