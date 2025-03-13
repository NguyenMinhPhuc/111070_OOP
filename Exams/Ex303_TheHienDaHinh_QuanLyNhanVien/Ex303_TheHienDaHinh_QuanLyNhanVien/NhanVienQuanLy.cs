using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex303_TheHienDaHinh_QuanLyNhanVien
{
    
    public class NhanVienQuanLy : NhanVien
    {
        #region Field & properties
        int luong_Khoan;

        public int Luong_Khoan { get => luong_Khoan; set => luong_Khoan = value; }
     
        #endregion

        #region Contructor
        public NhanVienQuanLy() : base()
        {
            this.luong_Khoan = 0;
          
        }
        public NhanVienQuanLy(int luong_Khoan) : base()
        {
            this.luong_Khoan = luong_Khoan;
           
        }
        public NhanVienQuanLy(int luong_Khoan,  string maNV, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh) : base(maNV, ho_Ten, dia_Chi, so_Dien_Thoai, ngay_Sinh)
        {
            this.luong_Khoan = luong_Khoan;
         
        }

        public NhanVienQuanLy(NhanVienQuanLy nhanVien) : base(nhanVien)
        {
            this.luong_Khoan = nhanVien.luong_Khoan;
         
        }

        #endregion
        #region Method
        public new void NhapNhanVien()
        {
            base.NhapNhanVien();
            Console.Write("Nhập lương khoán: ");
            luong_Khoan = Convert.ToInt32(Console.ReadLine());
            

        }
        public override void XuatNhanVien()
        {
            base.XuatNhanVien();
            Console.WriteLine($"Lương khoán: {luong_Khoan} ");
        }
        public override void GhiNhanVien(StreamWriter sw)
        {
            base.GhiNhanVien(sw);
            sw.WriteLine($"; {luong_Khoan}");
        }
        public override void GhiNhanVien(BinaryWriter bw)
        {
            base.GhiNhanVien(bw);
            bw.Write(luong_Khoan);
          
        }
        public override NhanVien DocNhanVien(string line)
        {
            string[] item = line.Split(';');
            NhanVien nhanVien = new NhanVienQuanLy()
            {
                MaNV = item[0],
                Ho_Ten = item[1],
                Ngay_Sinh = Convert.ToDateTime(item[2]),
                Dia_Chi = item[3],
                So_Dien_Thoai = item[4],
                luong_Khoan = Convert.ToInt32(item[5]),
                
            };
            return nhanVien;
        }
        public override NhanVien DocNhanVien(BinaryReader br)
        {
            NhanVien nhanVien = new NhanVienQuanLy()
            {
                MaNV = br.ReadString(),
                Ho_Ten = br.ReadString(),
                Ngay_Sinh = Convert.ToDateTime(br.ReadString()),
                Dia_Chi = br.ReadString(),
                So_Dien_Thoai = br.ReadString(),
                luong_Khoan = br.ReadInt32()
            };
            return nhanVien;
        }
        public override double TinhLuong()
        {
           return luong_Khoan;
        }
        #endregion
    }
}
