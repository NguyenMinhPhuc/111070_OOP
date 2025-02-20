using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex202_XayDungClassNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanVien1;//khai báo
            nhanVien1=new NhanVien();//Khởi tạo

            NhanVien nhanVien2;//khai báo
            nhanVien2 = new NhanVien("NV001","Nguyen Minh Phuc",2600000,3.15);//Khởi tạo

            NhanVien nhanVien3;//khai báo
            nhanVien3 = new NhanVien()
            {
                MaNV = "NV002",
                HoTen = "Nguyen Thi B",
                LuongCanBan = 2600000,
                HeSoLuong = 5.34
            };
            NhanVien nhanVien4;//khai báo
            nhanVien4 = new NhanVien(nhanVien3);//Khởi tạo
            //Kết quả
            nhanVien1.XuatDuLieu();
            nhanVien2.XuatDuLieu();
            nhanVien3.XuatDuLieu(true);
            Console.WriteLine(nhanVien4.XuatDuLieuTraVe());
            Console.ReadLine();
        }
    }
}
