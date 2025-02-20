using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex201_XayDungClass
{
    public class SinhVien
    {
        //Field

        #region khai bao Field
        string mSSV, hoSV, tenSV, diaChi, email;
        private DateTime ngaySinh;
        string soDienThoai;
        #endregion

        #region Khai bao Properties
        //Properties
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }


        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }


        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string MSSV
        {
            get { return mSSV; }
            set { mSSV = value; }
        }
        //snipet - prop
        public string HoSV { get { return hoSV; } set { hoSV = value; } }
        //dung phim tat = ctrl+R+E
        #endregion
        //Contructor
        //1.Hàm tạo mặc định
        public SinhVien()
        {
            mSSV = string.Empty;
            this.hoSV = string.Empty;
            this.tenSV = string.Empty;
            this.diaChi = string.Empty;
            this.email = string.Empty;
            this.soDienThoai = string.Empty;
            this.ngaySinh = new DateTime(1900, 1, 1);
        }
        //2. Hàm tạo có tham số
        public SinhVien(string mSSV,string hoSV,string tenSV,string diaChi,string email,string soDienThoai,DateTime ngaySinh)
        {
            this.mSSV = mSSV;
            this.hoSV = hoSV;
            this.tenSV = tenSV;
            this.diaChi = diaChi;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
        }
        public SinhVien(string mSSV, DateTime ngaySinh)
        {
            
            this.ngaySinh = ngaySinh;
            this.mSSV = mSSV;
            this.hoSV = string.Empty;
            this.tenSV = string.Empty;
            this.diaChi = string.Empty;
            this.email = string.Empty;
            this.soDienThoai = string.Empty;
            this.ngaySinh = ngaySinh;
        }
        //khởi tạo 3 tham số mSSV, soDienThoai, ngaySinh
        //Hàm tạo sao chép - Copy contructor
        public SinhVien(SinhVien sv)
        {
            this.mSSV = sv.mSSV;
            this.hoSV = sv.hoSV;
            this.tenSV = sv.tenSV;
            this.diaChi = sv.diaChi;
            this.email = sv.email;
            this.soDienThoai = sv.soDienThoai;
            this.ngaySinh = sv.ngaySinh;
        }
        //Method
        //1. thủ tục có void
        public void XuatDuLieu()
        {
            Console.WriteLine(string.Format("MSSV:{0}-HoSV:{1}-TenSV:{2}-Ngay sinh:{3}-DiaChi:{4}-Email:{5}-SDT:{6}",mSSV,hoSV,tenSV,ngaySinh.ToShortDateString(),diaChi,email,soDienThoai));
        }
        public void XuatDuLieu(bool coformat)
        {
            Console.WriteLine("{0,-10} | {1,-15} | {2,-10} | {3,-12} | {4,-20} | {5,-25} | {6,-12}",
    "MSSV", "Họ SV", "Tên SV", "Ngày sinh", "Địa chỉ", "Email", "SĐT");
            Console.WriteLine(new string('-', 110)); // Dòng kẻ ngang
            Console.WriteLine("{0,-10} | {1,-15} | {2,-10} | {3,-12} | {4,-20} | {5,-25} | {6,-12}",
                mSSV, hoSV, tenSV, ngaySinh.ToString("dd/MM/yyyy"), diaChi, email, soDienThoai);

        }
        //2. hàm

    }
}
