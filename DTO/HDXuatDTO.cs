using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDXuatDTO
    {
        int _maHDXuat;
        string _tenTaiKhoan;
        DateTime _ngayXuat;
        int _tongTien;
        int _trangThai;
        int _tonTai;

        public int MaHDXuat { get => _maHDXuat; set => _maHDXuat = value; }
        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public DateTime NgayXuat { get => _ngayXuat; set => _ngayXuat = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public int TonTai { get => _tonTai; set => _tonTai = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
