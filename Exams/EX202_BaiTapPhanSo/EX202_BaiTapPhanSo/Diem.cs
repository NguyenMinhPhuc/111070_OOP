using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX202_BaiTapPhanSo
{
    //Xây dựng lớp diem với các thuộc tính tung độ, hoành độ của điểm đó, phương thức đổi tọa độ giữa dương và âm, phương thức di chuyển theo một giá trị nhập vào từ bàn phím, phương thức hiện điểm lên màn hình.

    internal class Diem
    {
        //field
        double tungDo, hoanhDo;
        //properties
        public double TungDo { get => tungDo; set => tungDo = value; }
        public double HoanhDo { get => hoanhDo; set => hoanhDo = value; }
        //Constructor
        public Diem() { 
            this.tungDo= 0;
            this.hoanhDo= 0;
        }
        public Diem(double tungDo, double hoanhDo)
        {
            this.tungDo = tungDo;
            this.hoanhDo = hoanhDo;
        }
        public Diem(Diem diem)
        {
            this.tungDo = diem.TungDo;
            this.hoanhDo = diem.hoanhDo;
        }
        //method
        public void DoiToaDo()
        {
            if (this.hoanhDo > 0)
                this.hoanhDo = -this.hoanhDo;
            if (this.tungDo > 0)
                this.tungDo = -this.tungDo;
        }
        public void DiChuyen(double tungDo,double hoanhDo)
        {

           this.tungDo=tungDo; ;
            this.hoanhDo=hoanhDo ;
        }
        public void DiChuyen()
        {
            double tungDo,  hoanhDo;
            tungDo=Convert.ToDouble(Console.ReadLine());
            hoanhDo =Convert.ToDouble(Console.ReadLine());
            this.tungDo = tungDo; ;
            this.hoanhDo = hoanhDo;
        }
        public void HienThi()
        {
            Console.WriteLine("Diem ({0},{1})",tungDo,hoanhDo);
        }
    }
}
