using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptMonAnDTO
    {
        string _maMon;
        string _tenMon;
        string _tenLoaiMon;
        int _donGia;

        public string MaMon { get => _maMon; set => _maMon = value; }
        public string TenMon { get => _tenMon; set => _tenMon = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public string TenLoaiMon { get => _tenLoaiMon; set => _tenLoaiMon = value; }
    }
}
