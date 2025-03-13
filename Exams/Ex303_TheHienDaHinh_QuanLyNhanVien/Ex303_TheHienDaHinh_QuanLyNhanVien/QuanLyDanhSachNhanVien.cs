using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex303_TheHienDaHinh_QuanLyNhanVien
{
    public class QuanLyDanhSachNhanVien
    {
        //field
        List<NhanVien> nhanViens;
        //properties
        public List<NhanVien> NhanViens { get => nhanViens; set => nhanViens = value; }

        public QuanLyDanhSachNhanVien()
        {
            nhanViens=new List<NhanVien>();
        }

        public void NhapDanhSachNhanVien()
        {
            while (true)
            {
                string option = string.Empty;
                NhanVien nhanVien;
                Console.WriteLine("Chọn lại nhân viên: 1. Nhân viên HC; 2: Nhân viên Công nhật; 3: Nhân viên quản lý: ");
                string loai = Console.ReadLine();
                switch (loai)
                {
                    case "1":
                        nhanVien = new NhanVienHanhChanh();
                        nhanVien.NhapNhanVien();
                        nhanViens.Add(nhanVien);
                        break;
                    case "2":
                        nhanVien = new NhanVienCongNhat();
                        nhanVien.NhapNhanVien();
                        nhanViens.Add(nhanVien);
                        break;
                    case "3":
                        nhanVien = new NhanVienQuanLy();
                        nhanVien.NhapNhanVien();
                        nhanViens.Add(nhanVien);
                        break;
                }

                Console.WriteLine("Bạn có muốn nhập tiếp không?(Y/N): ");
                option = Console.ReadLine();
                if (option.ToUpper().Equals("N"))
                    return;
            }
        }
        public void XuatDanhSachNhanVien()
        {
            foreach (var item in nhanViens)
            {
                item.XuatNhanVien();
            }
        }
    }
}
