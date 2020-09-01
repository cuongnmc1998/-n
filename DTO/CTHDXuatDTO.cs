using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDXuatDTO
    {
        int _maHDXuat;
        string _maNL;
        int _donGia;
        int _soLuong;
        string _ghiChu;

        public int MaHDXuat { get => _maHDXuat; set => _maHDXuat = value; }
        public string MaNL { get => _maNL; set => _maNL = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
    }
}
