using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNguyenLieuDTO
    {
        string _maLoaiNL;
        string _tenLoaiNL;
        bool _trangThai;
        public string MaLoaiNL { get => _maLoaiNL; set => _maLoaiNL = value; }
        public string TenLoaiNL { get => _tenLoaiNL; set => _tenLoaiNL = value; }
        public bool TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
