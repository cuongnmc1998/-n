using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptCTHDBanHangDTO
    {
        int _maHD;
        string _tenMon;
        int _donGia;
        int _soLuong;
        string _ghiChu;
        int _thanhTien;
        int _tongSoLuong;

        public int MaHD { get => _maHD; set => _maHD = value; }
        public string TenMon { get => _tenMon; set => _tenMon = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public int ThanhTien { get => _thanhTien; set => _thanhTien = value; }
        public int TongSoLuong { get => _tongSoLuong; set => _tongSoLuong = value; }
    }
}
