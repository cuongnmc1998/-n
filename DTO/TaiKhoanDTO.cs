using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        string _tenTaiKhoan;
        string _matKhau;
        string _hoTen;
        string _email;
        string _soDT;
        string _diaChi;
        int _laAdmin;
        int _trangThai;

        public string TenTaiKhoan { get => _tenTaiKhoan; set => _tenTaiKhoan = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string Email { get => _email; set => _email = value; }
        public string SoDT { get => _soDT; set => _soDT = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public int LaAdmin { get => _laAdmin; set => _laAdmin = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
