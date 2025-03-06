using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX302_KeThua_QuanLyNhanVien
{
    public class NhanVienQuanLy:NhanVien
    {
        int luong_Khoan;

        public int Luong_Khoan { get => luong_Khoan; set => luong_Khoan = value; }

        public NhanVienQuanLy() : base()
        {
            this.luong_Khoan = 20000000;
           
        }
        public NhanVienQuanLy(string ma_So, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh, int luong_Khoan) : base(ma_So, ho_Ten, dia_Chi, so_Dien_Thoai, ngay_Sinh)
        {
            this.luong_Khoan = luong_Khoan;
         
        }

        public NhanVienQuanLy(NhanVienQuanLy nhanVienQuanLy) : base(nhanVienQuanLy)
        {
            this.luong_Khoan = nhanVienQuanLy.luong_Khoan;
           
        }
        public double TinhLuong()
        {
            return luong_Khoan;
        }
    }
}
