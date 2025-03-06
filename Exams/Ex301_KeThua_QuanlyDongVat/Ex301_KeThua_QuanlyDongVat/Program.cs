using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_QuanlyDongVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DongVat[] dongVats = new DongVat[6];
            List<DongVat> listDongVats = new List<DongVat>();

            dongVats[0] = new Cho();
            dongVats[1] = new Cho(true,true,false);
            dongVats[2]=new Cho(dongVats[1] as Cho);
            dongVats[3] = new Ga();
            dongVats[4]= new Ga(true,true,true);
            dongVats[5] = new Ga(dongVats[4] as Ga);

            listDongVats.Add(new Cho());
            listDongVats.Add(new Cho(true,true,true));
            listDongVats.Add(new Cho(listDongVats[1] as Cho));
            listDongVats.Add(new Ga());
            listDongVats.Add(new Ga(true,true,true));
            listDongVats.Add(new Ga(listDongVats[4] as Ga));

            #region goi phuong thuc
            (dongVats[0] as Cho).BietSua();
            foreach (var item in dongVats)
            {
                item.BietChay();
                item.BietNgu();
                if (item is Cho)
                {
                    (item as Cho).BietSua();
                }
                if (item is Ga)
                {
                    (item as Ga).BietBay();
                }
            }
            #endregion

        }
    }
}
