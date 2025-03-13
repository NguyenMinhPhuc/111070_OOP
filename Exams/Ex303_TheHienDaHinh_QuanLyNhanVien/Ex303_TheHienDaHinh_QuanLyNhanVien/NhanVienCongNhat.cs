using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex303_TheHienDaHinh_QuanLyNhanVien
{
   
    public class NhanVienCongNhat : NhanVien
    {
        #region Field & properties
        int so_San_Pham, luong_San_Pham;

        public int So_San_Pham { get => so_San_Pham; set => so_San_Pham = value; }
        public int Luong_San_Pham { get => luong_San_Pham; set => luong_San_Pham = value; }



        #endregion

        #region Contructor
        public NhanVienCongNhat() : base()
        {
            this.so_San_Pham = 0;
            this.luong_San_Pham = 0;
        }
        public NhanVienCongNhat(int so_San_Pham ,int luong_San_Pham) : base()
        {
            this.so_San_Pham = so_San_Pham;
            this.luong_San_Pham = luong_San_Pham;
        }
        public NhanVienCongNhat(int so_San_Pham, string maNV, string ho_Ten, string dia_Chi, string so_Dien_Thoai, DateTime ngay_Sinh) : base(maNV, ho_Ten, dia_Chi, so_Dien_Thoai, ngay_Sinh)
        {
            this.so_San_Pham = so_San_Pham;
            this.luong_San_Pham = luong_San_Pham;
        }

        public NhanVienCongNhat(NhanVienCongNhat nhanVien) : base(nhanVien)
        {
            this.so_San_Pham = nhanVien.so_San_Pham;
            this.luong_San_Pham = nhanVien.luong_San_Pham;
        }

        #endregion
        #region Method
        public new void NhapNhanVien()
        {
            base.NhapNhanVien();
            Console.Write("Nhập lương khoán: ");
            so_San_Pham = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Lương sản phẩm: ");
            luong_San_Pham = Convert.ToInt32(Console.ReadLine());
        }
        public override void XuatNhanVien()
        {
            base.XuatNhanVien();
            Console.WriteLine($"Lương khoán: {so_San_Pham} - Lương sản phầm: {luong_San_Pham} ");
        }
        public override void GhiNhanVien(StreamWriter sw)
        {
            base.GhiNhanVien(sw);
            sw.WriteLine($"; {so_San_Pham}; {luong_San_Pham}");
        }
        public override void GhiNhanVien(BinaryWriter bw)
        {
            base.GhiNhanVien(bw);
            bw.Write(so_San_Pham);
            bw.Write(luong_San_Pham);

        }
        public override NhanVien DocNhanVien(string line)
        {
            string[] item = line.Split(';');
            NhanVien nhanVien = new NhanVienCongNhat()
            {
                MaNV = item[0],
                Ho_Ten = item[1],
                Ngay_Sinh = Convert.ToDateTime(item[2]),
                Dia_Chi = item[3],
                So_Dien_Thoai = item[4],
                so_San_Pham = Convert.ToInt32(item[5]),
                luong_San_Pham = Convert.ToInt32(item[6])
            };
            return nhanVien;
        }
        public override NhanVien DocNhanVien(BinaryReader br)
        {
            NhanVien nhanVien = new NhanVienCongNhat()
            {
                MaNV = br.ReadString(),
                Ho_Ten = br.ReadString(),
                Ngay_Sinh = Convert.ToDateTime(br.ReadString()),
                Dia_Chi = br.ReadString(),
                So_Dien_Thoai = br.ReadString(),
                so_San_Pham = br.ReadInt32(),
                luong_San_Pham = br.ReadInt32()
            };
            return nhanVien;
        }
        public override double TinhLuong()
        {
           return so_San_Pham*luong_San_Pham;
        }
        #endregion
    }
}
