using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4032_NguyenTac02
{
    public class ContractEmployee : Employee
    {
        public override double CalculateSalary() => 5000 * 1.1;
    }

}
