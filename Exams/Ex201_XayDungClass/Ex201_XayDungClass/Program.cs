using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex201_XayDungClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1;//khai báo
            sv1 = new SinhVien();//khởi tạo - gọi hàm tạo

            SinhVien sv2;//khai báo
            sv2 = new SinhVien("123000123","Nguyen Van","Toan","Dong Nai","toan@lhu.edu.vn","091112229",new DateTime(2000,2,19));//khởi tạo - gọi hàm tạo

            SinhVien sv3;//khai báo
            sv3 = new SinhVien("123000987",new DateTime(2000,9,9));//khởi tạo - gọi hàm tạo

            SinhVien sv4;//khai báo
            sv4 = new SinhVien(sv3);//khởi tạo - gọi hàm tạo

            Console.WriteLine("Sinh vien 1: "); sv1.XuatDuLieu();
            Console.WriteLine("Sinh vien 2: "); sv2.XuatDuLieu(true);
            Console.WriteLine("Sinh vien 3: "); sv3.XuatDuLieu();
            Console.WriteLine("Sinh vien 4: "); sv4.XuatDuLieu();

            Console.ReadLine();
        }
    }
}
