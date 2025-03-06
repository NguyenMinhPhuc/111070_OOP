using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX302_KeThua_QuanLyNhanVien
{
    public class NhanVienCongNhat:NhanVien
    {
        int so_San_Pham, luong_SanPham;

        public int So_San_Pham { get => so_San_Pham; set => so_San_Pham = value; }
        public int Luong_SanPham { get => luong_SanPham; set => luong_SanPham = value; }

        public NhanVienCongNhat() : base()
        {
            this.so_San_Pham = 0;
            this.luong_SanPham = 10000;
        }
        public NhanVienCongNhat(string ma_So, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh, int so_San_Pham, int luong_SanPham) : base(ma_So, ho_Ten, dia_Chi, so_Dien_Thoai, ngay_Sinh)
        {
            this.so_San_Pham = so_San_Pham;
            this.luong_SanPham = luong_SanPham;
        }
        public NhanVienCongNhat( int so_San_Pham, int luong_SanPham) : base()
        {
            this.so_San_Pham = so_San_Pham;
            this.luong_SanPham = luong_SanPham;
        }

        public NhanVienCongNhat(NhanVienCongNhat nhanVienCongNhat) : base(nhanVienCongNhat)
        {
            this.so_San_Pham = nhanVienCongNhat.so_San_Pham;
            this.luong_SanPham = nhanVienCongNhat.luong_SanPham;
        }
        public double TinhLuong()
        {
            return so_San_Pham * luong_SanPham;
        }
    }
}
