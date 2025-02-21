using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex202_XayDungClassNhanVien
{
    public partial class NhanVien
    {
        //        Viết lớp NhanVien gồm:
        //Thuộc tính: MaNV, HoTen, LuongCoBan, HeSoLuong
        //Phương thức: Tính tổng lương.
        public static int tuoi = 0;
        //Field - luon luon la private
        private string maNV, hoTen;
        private  double luongCanBan, heSoLuong;
        //Properties--phim tat: Ctrl+R+E

        
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double LuongCanBan { get => luongCanBan; set => luongCanBan = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

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
            LuongCanBan = 0.0;
            HeSoLuong = 0.0;
        }
        //Loaị 2: hàm tạo có tham số
        public NhanVien(string maNV, string hoTen, double luongCanBan, double heSoLuong)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.LuongCanBan = luongCanBan;
            this.HeSoLuong = heSoLuong;
        }
        public NhanVien(string maNV) {
            this.maNV = maNV;
            hoTen = string.Empty;
            LuongCanBan = 0.0;
            HeSoLuong = 0.0;
        }
        //Loại 3: Hàm tạo sao chép - copy contructor
        public NhanVien(NhanVien nv)
        {
            this.maNV = nv.maNV;
            this.hoTen = nv.hoTen;
            this.LuongCanBan = nv.LuongCanBan;
            this.HeSoLuong = nv.HeSoLuong;
        }

        //Method --Phương thức (void) hay (trả về giá trị)
        //1. loại void

        public void CapNhatLuongCanBan(double luongCanBan)
        {
            this.luongCanBan = luongCanBan;
        }
        public void XuatDuLieu()
        {
            Console.WriteLine("MaNV: {0} ; HoTen: {1}; LCB:{2}; HSL:{3}; Luong: {4}", maNV, hoTen, LuongCanBan, HeSoLuong, LuongCanBan * HeSoLuong);
        }
        public void XuatDuLieu(bool coFormat)
        {
            Console.WriteLine("+------------+--------------------+------------+------------+------------+");
            Console.WriteLine("| MaNV       | HoTen              |     LCB    |     HSL    |   Luong    |");
            Console.WriteLine("+------------+--------------------+------------+------------+------------+");
            Console.WriteLine("| {0,-10} | {1,-18} | {2,10:N0} | {3,10:N1} | {4,10:N0} |",
                maNV, hoTen, LuongCanBan, HeSoLuong, LuongCanBan * HeSoLuong);
            Console.WriteLine("+------------+--------------------+------------+------------+------------+");
        }
        //2.Loai phuong thuc co gia tri tra ve
        public string XuatDuLieuTraVe()
        {
            return $"MaNV: {maNV} ; HoTen: {hoTen}; LCB: {LuongCanBan:N0}; HSL: {HeSoLuong:N1}; Luong: {LuongCanBan * HeSoLuong:N0}";
        }
        public double TinhLuong()
        {
            if (tuoi > 0)
            {
                return LuongCanBan * HeSoLuong;
            }
            return 0;
        }
        //Method - bao gồm thủ tục (void) hàm trả về giá trì
        //1. Phương thức void không tham số
        public void TenPhuongThuc() { }
        //2. Phương thức void có tham số đầu vào không có tham số trả về
        public void TenPhuongThuc(double luongCanBan,double heSoLuong) { }
        public void TenPhuongThuc(double luongCanBan, decimal heSoLuong) { }
        public void TenPhuongThuc(decimal luong, double heSoLuong) { }

      
        //3. Phương thức void có tham số đầu vào có tham số trả về
        public void TenPhuongThuc(double luongCanBan, double heSoLuong, out double luong) {
            luong = luongCanBan * heSoLuong;
        }
        public void TenPhuongThuc(double luongCanBan, double heSoLuong, ref decimal luong)
        {
            luong =(decimal) (luongCanBan * heSoLuong);
        }

        public void TenPhuongThuc( ref decimal luong)
        {
            int luongCanBan;
            luong = (decimal)(luongCanBan * HeSoLuong);
        }
        
        
    }
}
