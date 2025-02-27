using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex202_CacKhaiNiemBoSung
{
    public class NhanVien
    {
        //Tính đóng gói của OOP
        //  + private - riêng, chỉ sử dụng trong nội bộ 1 class
        //  + public - Chung, dung ở mọi nơi
        //  + protected - chỉ sử dụng trong quan hệ kế thừa
        //  + internal - Chỉ sử dụng trong cùng một khối Assemply (hợp ngữ)
        //  + protected internal
        public static int ngayCong;
        string id;
        //properties
        public string GetID() { return Id; }
        public void SetID(string id) { this.Id = id; }
        public string ID { get { return Id; } set { Id = value; } }

        public string Id { get => id; set => id = value; }

        //Trong 1 phương thức không phải static có thể dùng biến thành static hoặc không static
        public void Nhap()
        {
            id = Console.ReadLine();
            ngayCong = Convert.ToInt32(Console.ReadLine());
        }
        //Nhưng 1 phương thức static chỉ sử dụng các thành viên static
        public static void tinhLuong()
        {

            double luong = ngayCong * 250000000;
        }

        //chia thành 2 loại phương thức
        //1. Phương thức kiểu void
        //1.1. Phương thức void không tham số
        public void xuatDuLieu() { }
        //1.2. Phương thức void có tham số
        public void xuatDuLieu(int id) { }
        //1.3. Phương thức void có tham số vào có tham số ra
        public void XuatDuLieu(int id, ref int ngayCong) { }

        //2. Phương thức có giá trị trả về
        public double TinhLuong()
        {
            return ngayCong * 350000000;
        }
        //nạp chồng phương thức - Phương thức trùng tên
        //1. Kiểu tham số
        public void TenPhuongThuc(int id) { }
        public void TenPhuongThuc(double id) { }
        public void TenPhuongThuc(long id) { }
        //2. Sô lượng tham số
        public void TenPhuongThuc(long id,int ngayCong) { }
        public void TenPhuongThuc(long id, int ngayCong,string ghiChu) { Console.WriteLine(""); }
        //3. Thứ tự khác nhau
        public void TenPhuongThuc(int ngayCong,long id,  string ghiChu) { Console.WriteLine(""); }
        public void TenPhuongThuc(double id, long ngayCong, string ghiChu) { Console.WriteLine(""); }
    }
}
