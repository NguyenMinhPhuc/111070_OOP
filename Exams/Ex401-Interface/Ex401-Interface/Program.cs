using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> sinhViens = new List<SinhVien>() { 
                new SinhVien("123000123","Nguyen Van A"),
                new SinhVien("123000534","Nguyen Van b"),
                new SinhVien("123000313","Nguyen Van c"),
                new SinhVien("123000432","Nguyen Van d")
            };


           
            foreach (var item in sinhViens)
            {
                item.XuatSinhVien();
            }
            Console.WriteLine( "");
           sinhViens.Sort();
            foreach (var item in sinhViens)
            {
                item.XuatSinhVien();
            }

            List<int> ints = new List<int>() { 12, 2, 31, 5, 6, 7 };

            foreach (var item in ints) { Console.WriteLine(item.ToString()); }
            ints.Sort();
            foreach (var item in ints) { Console.WriteLine(item.ToString()); }
            Console.ReadLine();
        }
    }
}
