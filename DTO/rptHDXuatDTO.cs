using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class rptHDXuatDTO
    {
        int _maHDXuat;
        string _hoTen;
        DateTime _ngayXuat;
        int _tongTien;
        int _trangThai;
        int _tonTai;

        public int MaHDXuat { get => _maHDXuat; set => _maHDXuat = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public DateTime NgayXuat { get => _ngayXuat; set => _ngayXuat = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
        public int TonTai { get => _tonTai; set => _tonTai = value; }
    }
}
