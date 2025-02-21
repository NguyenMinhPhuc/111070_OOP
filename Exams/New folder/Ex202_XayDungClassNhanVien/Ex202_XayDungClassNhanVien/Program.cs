using Ex202_XayDungClassNhanVien.Commons;
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
            String.Concat("", "");
            string chuoi;
            chuoi = "";
           
            NhanVien nhanVien2;//khai báo
            nhanVien2 = new NhanVien("NV001","Nguyen Minh Phuc",2600000,3.15);//Khởi tạo

            NhanVien nhanVien3;//khai báo
            nhanVien3 = new NhanVien()
            {
                MaNV = "NV002",
                HoTen = "Nguyen Thi Be",
                LuongCanBan = 2600000,
                HeSoLuong = 5.34
            };
            NhanVien nhanVien4= new NhanVien(nhanVien3);//Khởi tạo
            //Kết quả
            nhanVien1.XuatDuLieu();
            nhanVien2.XuatDuLieu();
            nhanVien3.XuatDuLieu(true);
            Console.WriteLine(nhanVien4.XuatDuLieuTraVe());

            //tính lương của nhan vien 2
           // nhanVien2.LuongCanBan = 15000000;
            nhanVien2.CapNhatLuongCanBan(15000000);
            double luong1=nhanVien2.TinhLuong();
            double luong = ClsTinhLuong.TinhLuong(nhanVien2.LuongCanBan, nhanVien2.HeSoLuong);
            Console.ReadLine();
            
        }
    }
}
