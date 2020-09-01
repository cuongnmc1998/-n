using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        string _maNCC;
        string _tenNhaCC;
        string _diaChiNCC;
        string _SDTNCC;
        string _emailNCC;
        int _trangThai;

        public string MaNCC { get => _maNCC; set => _maNCC = value; }
        public string TenNhaCC { get => _tenNhaCC; set => _tenNhaCC = value; }
        public string DiaChiNCC { get => _diaChiNCC; set => _diaChiNCC = value; }
        public string SDTNCC { get => _SDTNCC; set => _SDTNCC = value; }
        public string EmailNCC { get => _emailNCC; set => _emailNCC = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
