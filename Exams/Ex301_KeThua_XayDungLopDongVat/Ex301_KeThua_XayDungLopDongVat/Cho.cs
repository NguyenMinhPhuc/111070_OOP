using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_KeThua_XayDungLopDongVat
{
    public class Cho:DongVat
    {
        //field
        bool coDuoi;
        //properties
        public bool CoDuoi { get => coDuoi; set => coDuoi = value; }

        //contructor
        public Cho():base()
        {
            this.coDuoi = true;
        }
        public Cho(bool coChan, bool coMat,bool coDuoi) : base(coChan, coMat)
        {
            this.coDuoi = coDuoi;
        }
        public Cho(Cho cho) : base(cho)
        {
            this.coDuoi = cho.coDuoi;
           
        }
        //method
        public string BietSua(string tienSua)
        {
            return tienSua;
        }
        public double VayDoi(double tocDo)
        { 
            return tocDo; 
        }
    }
}
