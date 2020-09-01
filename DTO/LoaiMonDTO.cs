using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMonDTO
    {
        string _maLoaiMon;
        string _tenLoaiMon;
        bool _trangThai;

        public string MaLoaiMon { get => _maLoaiMon; set => _maLoaiMon = value; }
        public string TenLoaiMon { get => _tenLoaiMon; set => _tenLoaiMon = value; }
        public bool TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
