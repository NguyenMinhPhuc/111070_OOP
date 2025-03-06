using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_QuanlyDongVat
{
    public class Ga:DongVat
    {
        bool coCanh;

        public bool CoCanh { get => coCanh; set => coCanh = value; }

        public Ga() : base() { this.coCanh = true; }

        public Ga(bool coChan,bool coMat, bool coCanh) : base(coChan, coMat)
        {
            this.coCanh = coCanh;
        }
        public Ga(Ga ga) : base(ga)
        {
            this.coCanh=ga.coCanh;
        }

        public void BietBay()
        {
            Console.WriteLine(  "Biet bay");
        }

        public bool BietVayCanh()
        {
            return coCanh;
        }
    }
}
