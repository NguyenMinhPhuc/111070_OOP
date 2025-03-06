using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX302_KeThua_QuanLyNhanVien
{
    public class NhanVien
    {
        string ma_So, ho_Ten, dia_Chi,so_Dien_Thoai;
        DateTime ngay_Sinh;

        public string Ma_So { get => ma_So; set => ma_So = value; }
        public string Ho_Ten { get => ho_Ten; set => ho_Ten = value; }
        public string Dia_Chi { get => dia_Chi; set => dia_Chi = value; }
        public string So_Dien_Thoai { get => so_Dien_Thoai; set => so_Dien_Thoai = value; }
        public DateTime Ngay_Sinh { get => ngay_Sinh; set => ngay_Sinh = value; }

        public NhanVien()
        {
            this.ma_So= string.Empty;
            this.ho_Ten= string.Empty;
           this.dia_Chi= string.Empty;
            this.so_Dien_Thoai= string.Empty;
            this.ngay_Sinh = DateTime.MinValue;

        }

        public NhanVien(string ma_So, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh)
        {
            this.ma_So = ma_So;
            this.ho_Ten = ho_Ten;
            this.dia_Chi= dia_Chi;
            this.so_Dien_Thoai = so_Dien_Thoai;
            this.ngay_Sinh = ngay_Sinh;
            
        }
        public NhanVien(NhanVien nhanVien) {
            this.ma_So = nhanVien.ma_So;
            this.ho_Ten = nhanVien.ho_Ten;
            this.dia_Chi = nhanVien.dia_Chi;
            this.so_Dien_Thoai = nhanVien.so_Dien_Thoai;
            this.ngay_Sinh = nhanVien.ngay_Sinh;
        }

        public void NhapNhanVien()
        {
            Console.Write("Nhập mã số:");
            ma_So = Console.ReadLine();
            Console.Write("Nhập họ và tên:");
            ho_Ten = Console.ReadLine();
            Console.Write("Nhập Ngày sinh:");
            ngay_Sinh =Convert.ToDateTime( Console.ReadLine());
            Console.Write("Nhập địa chỉ:");
            dia_Chi = Console.ReadLine();
            Console.Write("Nhập Số điện thoại:");
            so_Dien_Thoai = Console.ReadLine();
        }
        public void XuatNhanVien()
        {
            Console.WriteLine("Mã số: {0} - Họ và tên: {1} - Ngày sinh: {2} - Địa chỉ: {3} - Số điện thoại: {4}",ma_So,ho_Ten,ngay_Sinh,dia_Chi,so_Dien_Thoai);
        }
    }
}
