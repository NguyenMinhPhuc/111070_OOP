using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX302_KeThua_QuanLyNhanVien
{
    public class NhanVienHanhChanh : NhanVien
    {
        int so_Ngay_Cong, luong_Ngay;

        public int So_Ngay_Cong { get => so_Ngay_Cong; set => so_Ngay_Cong = value; }
        public int Luong_Ngay { get => luong_Ngay; set => luong_Ngay = value; }

        public NhanVienHanhChanh() : base()
        {
            this.so_Ngay_Cong = 0;
            this.luong_Ngay = 200000;
        }
        public NhanVienHanhChanh(string ma_So,string ho_Ten,string dia_Chi,string so_Dien_Thoai,DateTime ngay_Sinh,int so_Ngay_Cong,int luong_Ngay) : base(ma_So,ho_Ten,dia_Chi,so_Dien_Thoai,ngay_Sinh)
        {
            this.so_Ngay_Cong = so_Ngay_Cong;
            this.luong_Ngay = luong_Ngay;
        }
        public NhanVienHanhChanh( int so_Ngay_Cong, int luong_Ngay) : base()
        {
            this.so_Ngay_Cong = so_Ngay_Cong;
            this.luong_Ngay = luong_Ngay;
        }

        public NhanVienHanhChanh(NhanVienHanhChanh nhanVienHanhChanh):base(nhanVienHanhChanh) {
            this.so_Ngay_Cong = nhanVienHanhChanh.so_Ngay_Cong;
            this.luong_Ngay = nhanVienHanhChanh.luong_Ngay;
        }
        public Double TinhLuong()
        {
            return so_Ngay_Cong * luong_Ngay;
        }
    }
}
