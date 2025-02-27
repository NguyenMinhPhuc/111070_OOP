using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_XayDungLopDongVat
{
    public class Ga:DongVat
    {
        bool coCanh;

        public bool CoCanh { get => coCanh; set => coCanh = value; }
        public Ga():base(){ this.coCanh = true; }
        public Ga(bool coChan,bool coMat,bool coCanh):base(coChan,coMat) { this.coCanh = coCanh; }
        public Ga(Ga ga) : base(ga){coCanh=ga.coCanh;}

        public bool BietBay(bool coCanh)
        {
            base.bi
            return coCanh;
        }
        public double VayCanh(int phut)
        {
            return phut;
        }
    }
}
