using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_DaHinh_QuanLyNhanVien
{
    internal class Program
    {

       static NhanVien[] nhanViens = new NhanVien[1000];
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Cấu hình bảng mã UTF-8
            int choice;
            do
            {
                choice = Menu();
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                    Console.ReadKey();
                    continue;
                }
                // Xử lý tùy chọn
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhập danh sách nhân viên!");
                        // Gọi hàm xử lý tại đây
                        NhapDanhSach();
                        break;
                    case 2:
                        Console.WriteLine("Xuất danh sách nhân viên!");
                        // Gọi hàm xử lý tại đây
                        XuatDanhSach();
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn xuất báo cáo!");
                        GhiNoiDung(1);
                        // Gọi hàm xử lý tại đây
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                }

                if (choice != 4)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        private static void GhiNoiDung(int option)
        {
            MyFile myFile;
            if(option == 1)
            {
                myFile = new MyFileINI();
            }
            else
            {
                myFile = new MyFileText();
            }   
            myFile.Path = "";
            myFile.Write();
        }

        private static int Menu()
        {
            int choice = 0;
            Console.Clear(); // Xóa màn hình để hiển thị menu mới
            Console.WriteLine("======== MENU CHƯƠNG TRÌNH ========");
            Console.WriteLine("1. Nhập danh sách nhân viên");
            Console.WriteLine("2. Xuất danh sách nhân viên");
            Console.WriteLine("3. Thêm chức năng");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn (1-4): ");

            // Kiểm tra nhập liệu hợp lệ
            bool isValid = int.TryParse(Console.ReadLine(), out choice);

           return isValid ? choice : 0;
        }

        static void XuatDanhSach()
        {
            foreach (var item in nhanViens)
            {
                if (item != null)
                {
                    item.Xuat();
                }
            }
        }

        static void NhapDanhSach()
        {
            int index = 0;
            while (true)
            {
                Console.Write( "Chọn loại:\n 0.Kêt thúc nhập \n 1. NVQL \n 2. NVCN : ");
                int option=Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Nhập nhân viên quản lý");
                    nhanViens[index] = new NhanVienQuanLy();
                    nhanViens[index].Nhap();
                    index++;
                }
                else if (option == 2) {
                    Console.WriteLine("Nhập nhân viên công nhật");
                    nhanViens[index] = new NhanVienCongNhat();
                    nhanViens[index].Nhap();
                    index++;
                }
                else
                {
                    break;
                }
                    
            }
        }
    }
}
