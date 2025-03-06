using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX202_BaiTapPhanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Diem diem;
            diem = new Diem();  
            while (true) {
                option = Menu();
                switch (option)
                {
                    case 1:
                        //thuc hien nhap
                        diem.HienThi();
                        break;
                    case 2:
                        break;
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine("1. Nhap Diem");
            Console.WriteLine("2. thoat");
            int index = Convert.ToInt32(Console.ReadLine());
            return index;
        }

    } 
    
}
