using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_QuanlyDongVat
{
    public class Cho:DongVat
    {
        bool coDuoi;

        public bool CoDuoi { get => coDuoi; set => coDuoi = value; }

        public Cho() : base()
        {
            coDuoi=true;
        }

        public Cho(bool coChan, bool coMat,bool coDuoi):base(coChan,coMat)
        {
            this.coDuoi=coDuoi;
        }
        public Cho(Cho cho) : base(cho) {
            this.coDuoi = cho.CoDuoi;
        }

        public void BietSua()
        {
            Console.WriteLine("go go");
        }
        public bool VatDuoi()
        {
            return coDuoi;
        }
    }
}
