using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_DaHinh_QuanLyNhanVien
{
    internal class NhanVien
    {
        #region field
        string maNV, hoTen,diaChi;
        DateTime ngaySinh;
        #endregion
        #region Properties

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        #endregion
        #region Contructor
        public NhanVien()
        {
            this.maNV = string.Empty;
            this.hoTen = string.Empty;
            this.diaChi = string.Empty;
            this.ngaySinh = DateTime.MinValue;
        }
        #endregion

        #region method
        public virtual void Nhap() {
            Console.Write("Nhap maNV: ");
            maNV=Console.ReadLine();
            Console.Write("Nhap Ho va te: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh =Convert.ToDateTime( Console.ReadLine());
        }
        public virtual void Xuat() {
            Console.WriteLine("{0}-{1}-{2}-{3}",maNV,hoTen,diaChi,ngaySinh);
        }

        public virtual double TinhLuong()
        {
            return 0;
        }
        #endregion
    }
}
