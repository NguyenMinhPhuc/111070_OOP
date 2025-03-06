using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_DaHinh_QuanLyNhanVien
{
    internal class NhanVienCongNhat:NhanVien
    {
        #region field,properties
        int ngayCong;

        public int NgayCong { get => ngayCong; set => ngayCong = value; }
        #endregion
        public NhanVienCongNhat():base() {
            ngayCong = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ngay cong: ");
            ngayCong=Convert.ToInt32(Console.ReadLine());
        }

        public override void Xuat() { 
            base.Xuat();
            Console.WriteLine("{0}",ngayCong);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public override double TinhLuong()
        {
            return ngayCong * 200000;
        }

    }
}
