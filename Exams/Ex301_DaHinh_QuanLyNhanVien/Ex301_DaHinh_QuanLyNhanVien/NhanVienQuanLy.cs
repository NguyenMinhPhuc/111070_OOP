using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_DaHinh_QuanLyNhanVien
{
    internal class NhanVienQuanLy:NhanVien
    {
        #region field,properties
        double heSoLuong;
        int luongCanBan;

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public int LuongCanBan { get => luongCanBan; set => luongCanBan = value; }

        #endregion
        public NhanVienQuanLy() : base()
        {
            heSoLuong = 3.16;
            luongCanBan = 2650000;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            heSoLuong =Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap luong can ban: ");
            luongCanBan =Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("{0}*{1}={2}",heSoLuong,luongCanBan,heSoLuong*luongCanBan);
        }
        public override double TinhLuong()
        {
            return heSoLuong*luongCanBan;
        }
    }
}
