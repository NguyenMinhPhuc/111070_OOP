using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex303_TheHienDaHinh_QuanLyNhanVien
{
    public class NhanVienHanhChanh:NhanVien
    {
        #region Field & properties
        int so_Ngay_Cong, luong_Ngay;

        public int So_Ngay_Cong { get => so_Ngay_Cong; set => so_Ngay_Cong = value; }
        public int Luong_Ngay { get => luong_Ngay; set => luong_Ngay = value; }
        #endregion

        #region Contructor
        public NhanVienHanhChanh():base() { 
            this.so_Ngay_Cong=0;
            this.luong_Ngay=0;
        }
        public NhanVienHanhChanh(int so_Ngay_Cong, int luong_Ngay):base() 
        {
            this.so_Ngay_Cong = so_Ngay_Cong;
          this.luong_Ngay= luong_Ngay;
        }
        public NhanVienHanhChanh(int so_Ngay_Cong, int luong_Ngay, string maNV, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh) : base(maNV, ho_Ten, dia_Chi, so_Dien_Thoai, ngay_Sinh)
        {
            this.so_Ngay_Cong = so_Ngay_Cong;
            this.luong_Ngay = luong_Ngay;
        }

        public NhanVienHanhChanh(NhanVienHanhChanh nhanVien) : base(nhanVien)
        {
            this.so_Ngay_Cong = nhanVien.so_Ngay_Cong;
            this.luong_Ngay = nhanVien.luong_Ngay;
        }

        #endregion
        #region Method
        public new void NhapNhanVien()
        {
            base.NhapNhanVien();
            Console.Write("Nhập Số ngày công: ");
            so_Ngay_Cong=Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Lương ngày: ");
            luong_Ngay = Convert.ToInt32(Console.ReadLine());

        }
        public override void XuatNhanVien()
        {
            base.XuatNhanVien();
            Console.WriteLine($"Số ngày công : {so_Ngay_Cong} -- Lương ngày : {luong_Ngay}");
        }
        public override void GhiNhanVien(StreamWriter sw)
        {
            base.GhiNhanVien(sw);
            sw.WriteLine($"; {so_Ngay_Cong}; {luong_Ngay}");
        }
        public override void GhiNhanVien(BinaryWriter bw)
        {
            base.GhiNhanVien(bw);
            bw.Write(so_Ngay_Cong);
            bw.Write(luong_Ngay);
        }
        public override NhanVien DocNhanVien(string line)
        {
            string[] item = line.Split(';');
            NhanVien nhanVien = new NhanVienHanhChanh()
            {
                MaNV = item[0],
               Ho_Ten = item[1],
                Ngay_Sinh = Convert.ToDateTime(item[2]),
                Dia_Chi = item[3],
                So_Dien_Thoai = item[4],
                so_Ngay_Cong=Convert.ToInt32(item[5]),
                luong_Ngay=Convert.ToInt32(item[6])
            };
            return nhanVien; 
        }
        public override NhanVien DocNhanVien(BinaryReader br)
        {
            NhanVien nhanVien = new NhanVienHanhChanh()
            {
                MaNV = br.ReadString(),
                Ho_Ten = br.ReadString(),
                Ngay_Sinh = Convert.ToDateTime(br.ReadString()),
                Dia_Chi = br.ReadString(),
                So_Dien_Thoai = br.ReadString(),
                so_Ngay_Cong = br.ReadInt32(),
                luong_Ngay = br.ReadInt32()
            } ;
            return nhanVien;
        }

        public override double TinhLuong()
        {
            return so_Ngay_Cong * luong_Ngay;
        }
        #endregion
    }
}
