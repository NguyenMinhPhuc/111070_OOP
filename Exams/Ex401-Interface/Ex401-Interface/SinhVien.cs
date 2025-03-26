using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_Interface
{
    public class SinhVien : IComparable
    {
        string mSSV, hoTen;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public SinhVien(string mSSV,string hoTen) { this.mSSV = mSSV; this.hoTen = hoTen; }
        public void XuatSinhVien()
        {
            Console.WriteLine($"{mSSV}-{hoTen}");
        }
        public int CompareTo(object obj)
        {
            SinhVien sinhVien = obj as SinhVien;
            return this.hoTen.CompareTo(sinhVien.hoTen);
        }
    }
}
