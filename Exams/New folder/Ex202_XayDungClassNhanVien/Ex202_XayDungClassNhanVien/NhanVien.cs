using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex202_XayDungClassNhanVien
{
    public class NhanVien
    {
        //        Viết lớp NhanVien gồm:
        //Thuộc tính: MaNV, HoTen, LuongCoBan, HeSoLuong
        //Phương thức: Tính tổng lương.

        //Field - luon luon la private
        private string maNV, hoTen;
        private double luongCanBan, heSoLuong;
        //Properties--phim tat: Ctrl+R+E
     
        public double LuongCanBan { get => luongCanBan; set => luongCanBan = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string MaNV { get =>maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        //contructor - Hàm tạo
        //3 loại contructor
        //Quy tắc:
        //+ Luôn luôn sử dụng public
        //+ Tên của hàm tạo là tên của Class
        //+ không có kiểu trả về, không có void
        //Loại 1: hàm tạo không tham số - hàm tạo mặc định
        public NhanVien()
        {
            maNV = string.Empty;
            hoTen = string.Empty;
            luongCanBan = 0.0;
            heSoLuong = 0.0;
        }
        //Loaị 2: hàm tạo có tham số
        public NhanVien(string maNV,string hoTen,double luongCanBan,double heSoLuong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.luongCanBan = luongCanBan;
            this.heSoLuong=heSoLuong;
        }
        public NhanVien(string maNV) {  
            this.maNV = maNV;
            hoTen = string.Empty;
            luongCanBan = 0.0;
            heSoLuong = 0.0;
        }
        //Loại 3: Hàm tạo sao chép - copy contructor
        public NhanVien(NhanVien nv)
        {
            this.maNV = nv.maNV;
            this.hoTen = nv.hoTen;
            this.luongCanBan = nv.luongCanBan;
            this.heSoLuong = nv.heSoLuong;
        }

        //Method --Phương thức (void) hay (trả về giá trị)
        //1. loại void
        public void XuatDuLieu()
        {
            Console.WriteLine("MaNV: {0} ; HoTen: {1}; LCB:{2}; HSL:{3}; Luong: {4}",maNV,hoTen,luongCanBan,heSoLuong,luongCanBan*heSoLuong);
        }
        public void XuatDuLieu(bool coFormat)
        {


            Console.WriteLine("+------------+--------------------+------------+------------+------------+");
            Console.WriteLine("| MaNV       | HoTen              |     LCB    |     HSL    |   Luong    |");
            Console.WriteLine("+------------+--------------------+------------+------------+------------+");
            Console.WriteLine("| {0,-10} | {1,-18} | {2,10:N0} | {3,10:N1} | {4,10:N0} |",
                maNV, hoTen, luongCanBan, heSoLuong, luongCanBan * heSoLuong);
            Console.WriteLine("+------------+--------------------+------------+------------+------------+");


        }
        //2.Loai phuong thuc co gia tri tra ve
        public string XuatDuLieuTraVe()
        {
            return string.Format($"MaNV: {maNV} ; HoTen: {hoTen}; LCB:{luongCanBan}; HSL:{heSoLuong}; Luong: {luongCanBan*heSoLuong}");
        }
        public double TinhLuong()
        {
            return luongCanBan*heSoLuong;
        }
        
    }
}
