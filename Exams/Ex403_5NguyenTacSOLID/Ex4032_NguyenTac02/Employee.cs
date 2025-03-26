using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4032_NguyenTac02
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }

}
