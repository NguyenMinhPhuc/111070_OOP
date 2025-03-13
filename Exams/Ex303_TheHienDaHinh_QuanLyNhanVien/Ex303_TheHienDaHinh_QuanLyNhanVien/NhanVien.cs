using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex303_TheHienDaHinh_QuanLyNhanVien
{
   abstract public class NhanVien
    {
        #region field & properties
        //field
        string maNV, ho_Ten, dia_Chi, so_Dien_Thoai;
        DateTime ngay_Sinh;
        //properties -- Sử dụng Ctrl+R+E để tạo properties
        public string MaNV { get => maNV; set => maNV = value; }
        public string Ho_Ten { get => ho_Ten; set => ho_Ten = value; }
        public string Dia_Chi { get => dia_Chi; set => dia_Chi = value; }
        public string So_Dien_Thoai { get => so_Dien_Thoai; set => so_Dien_Thoai = value; }
        public DateTime Ngay_Sinh { get => ngay_Sinh; set => ngay_Sinh = value; }
        #endregion
        # region Contructor
        //Contructor không tham số
        public NhanVien()
        {
            this.maNV = string.Empty;
            this.ho_Ten = string.Empty;
            this.dia_Chi = string.Empty;
            this.so_Dien_Thoai = string.Empty;
            this.ngay_Sinh = DateTime.MinValue;
        }
        //contructor có tham số
        public NhanVien(string maNV, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh)
        {
            this.maNV = maNV;
            this.ho_Ten = ho_Ten;
            this.dia_Chi = dia_Chi;
            this.so_Dien_Thoai = so_Dien_Thoai;
            this.ngay_Sinh = ngay_Sinh;
        }
        //Contructor sao chep
        public NhanVien(NhanVien nhanVien)
        {
            this.maNV = nhanVien.maNV;
            this.ho_Ten = nhanVien.ho_Ten;
            this.dia_Chi = nhanVien.dia_Chi;
            this.so_Dien_Thoai = nhanVien.so_Dien_Thoai;
            this.ngay_Sinh = nhanVien.ngay_Sinh;
        }
        #endregion

        #region Method
        public void NhapNhanVien()
        {
            Console.Write("Nhập Mã NV: ");
            maNV = Console.ReadLine();
            Console.Write("Nhập họ và tên: ");
            ho_Ten = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            ngay_Sinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập địa chỉ: ");
            dia_Chi = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            so_Dien_Thoai = Console.ReadLine();
        }
        public virtual void XuatNhanVien()
        {
            Console.WriteLine($"Mã số: {maNV} - Họ và tên: {ho_Ten} - Ngày sinh: {ngay_Sinh:dd/MM/yyyy} - Địa chỉ: {dia_Chi} - Số điện thoại: {so_Dien_Thoai}");
        }
        /// <summary>
        /// Ghi theo kiểu text (ini, txt)
        /// </summary>
        /// <param name="sw"></param>
        public virtual void GhiNhanVien(StreamWriter sw) {
            sw.Write($"{maNV};{ho_Ten};{ngay_Sinh::dd/MM/yyyy};{dia_Chi};{so_Dien_Thoai}");
            // NV000001;Nguyen Minh Phuc;21 / 4 / 2000;dong nai;0911132826
        }
        /// <summary>
        /// Ghi theo file nhị phân (bat)
        /// </summary>
        /// <param name="bw"></param>
        public virtual void GhiNhanVien(BinaryWriter bw)
        {
            bw.Write(maNV);
            bw.Write(ho_Ten);
            bw.Write(ngay_Sinh.ToString());
            bw.Write(dia_Chi);
            bw.Write(so_Dien_Thoai);
        }
        /// <summary>
        /// Đọc file text (int, txt)
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        abstract public NhanVien DocNhanVien(string line);
       
        /// <summary>
        /// đọc file nhi phân (bat)
        /// </summary>
        /// <param name="br"></param>
        /// <returns></returns>
        abstract public  NhanVien DocNhanVien(BinaryReader br);

        abstract public double TinhLuong();

        #endregion
    }
}
