using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_QuanlyDongVat
{
    public class DongVat
    {
        #region field, properties
        bool coChan, coMat;

        public bool CoChan { get => coChan; set => coChan = value; }
        public bool CoMat { get => coMat; set => coMat = value; }
        #endregion
        #region contructor
        public DongVat() { coChan = true;CoMat = true; }
        public DongVat(bool coChan, bool coMat) { this.coChan = coChan;this.coMat = coMat; }
        public DongVat(DongVat dongVat) { this.coChan = dongVat.coChan;
            this.coMat = dongVat.coMat;
        }
        #endregion
        #region Method
        public bool BietChay()
        {
            return coChan;
        }
        public bool BietNgu()
        {
            return coMat;
        }
        #endregion
    }
}
