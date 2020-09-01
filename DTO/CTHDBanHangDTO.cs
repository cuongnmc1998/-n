using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDBanHangDTO
    {
        int _maHD;
        string _maMon;
        int _donGia;
        int _soLuong;
        string _ghiChu;

        public int MaHD { get => _maHD; set => _maHD = value; }
        public string MaMon { get => _maMon; set => _maMon = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
    }
}
