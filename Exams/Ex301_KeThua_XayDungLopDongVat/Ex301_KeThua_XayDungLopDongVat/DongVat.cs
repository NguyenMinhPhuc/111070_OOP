using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_XayDungLopDongVat
{
    public class DongVat
    {
        //field
        bool coChan;
        bool coMat;
        //properties
        public bool  CoChan { get { return coChan; } set { coChan = value; } }

        public bool CoMat { get => coMat; set => coMat = value; }
        //Constrctor
        public DongVat() { 
            coChan = true;
            coMat = true;
        }
        public DongVat(bool coChan, bool coMat)
        {
            this.coChan = coChan;
            this.coMat = coMat;
        }
        public DongVat(DongVat dongVat)
        {
            this.coMat = dongVat.coMat;
            this.coChan = dongVat.CoChan;
        }

        //Method
        public bool BietChay( bool coChan)
        {
            if( coChan ) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BietNgu()
        {
            return true;
        }
    }
}
