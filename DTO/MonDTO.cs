using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonDTO
    {
        string _maMon;
        string _maLoaiMon;
        string _tenMon;
        int _donGia;
        string _hinhAnh;
        bool _trangThai;

        public string MaMon { get => _maMon; set => _maMon = value; }
        public string MaLoaiMon { get => _maLoaiMon; set => _maLoaiMon = value; }
        public string TenMon { get => _tenMon; set => _tenMon = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public string HinhAnh { get => _hinhAnh; set => _hinhAnh = value; }
        public bool TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
