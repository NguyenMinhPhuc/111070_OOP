using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4032_NguyenTac02
{
    internal class Program
    {
       
        static void Main(string[] args)
        { 
            SalaryCalculator salaryCalculator;
            List<Employee> employees = new List<Employee>() {
                new ContractEmployee(),
                new PermanentEmployee(),
            };
           
            foreach (Employee employee in employees) {
                salaryCalculator = new SalaryCalculator();
                salaryCalculator.CalculateSalary(employee);
            }
        }
    }
}
