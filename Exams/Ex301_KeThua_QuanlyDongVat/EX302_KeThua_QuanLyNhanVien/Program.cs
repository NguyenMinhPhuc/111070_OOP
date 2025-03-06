using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX302_KeThua_QuanLyNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            nhanViens.Add(new NhanVienCongNhat(200,1000));
            nhanViens.Add(new NhanVienCongNhat(255,1000));
            nhanViens.Add(new NhanVienHanhChanh(26,200000));
            nhanViens.Add(new NhanVienHanhChanh(25,200000));
            nhanViens.Add(new NhanVienQuanLy());
           
            foreach (var item in nhanViens)
            {
                if (item is NhanVienCongNhat)
                    Console.WriteLine($"{((NhanVienCongNhat)item).TinhLuong():N0}"); 
                if (item is NhanVienHanhChanh)
                    Console.WriteLine($"{((NhanVienHanhChanh)item).TinhLuong():N0}") ;
                if (item is NhanVienQuanLy)
                    Console.WriteLine($"{((NhanVienQuanLy)item).TinhLuong():N0}");

            }
        }
    }
}
