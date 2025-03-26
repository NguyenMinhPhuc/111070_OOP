using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex403_5NguyenTacSOLID
{
    public class Employee
    {
        string name;
        double salary;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double CalculateSalary()
        {
            return Salary * 1.1;
        }

    }
}
