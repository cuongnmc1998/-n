using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        string _maNL;
        string _maLoaiNL;
        string _maNCC;
        string _tenNL;
        string _donViTinh;
        int _donGia;
        int _soLuongTonKho;
        bool _trangThai;

        public string MaNL { get => _maNL; set => _maNL = value; }
        public string MaLoaiNL { get => _maLoaiNL; set => _maLoaiNL = value; }
        public string MaNCC { get => _maNCC; set => _maNCC = value; }
        public string TenNL { get => _tenNL; set => _tenNL = value; }
        public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuongTonKho { get => _soLuongTonKho; set => _soLuongTonKho = value; }
        public bool TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
