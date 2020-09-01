using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptCTHDXuatDTO
    {
        int _maHDXuat;
        string _tenNL;
        int _donGia;
        int _soLuong;

        public int MaHDXuat { get => _maHDXuat; set => _maHDXuat = value; }
        public string TenNL { get => _tenNL; set => _tenNL = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
