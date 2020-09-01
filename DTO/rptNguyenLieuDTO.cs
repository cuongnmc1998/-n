using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptNguyenLieuDTO
    {
        string _maNL;
        string _tenNL;
        string _tenLoaiNL;
        string _TenNCC;
        string _donViTinh;
        int _donGia;
        int _soLuongTonKho;

        public string MaNL { get => _maNL; set => _maNL = value; }
        public string TenNL { get => _tenNL; set => _tenNL = value; }
        public string TenLoaiNL { get => _tenLoaiNL; set => _tenLoaiNL = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuongTonKho { get => _soLuongTonKho; set => _soLuongTonKho = value; }
    }
}
