using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex403_5NguyenTacSOLID
{
    public class PrintReport
    {
        public void Print(Employee emp)
        {
            Console.WriteLine($"Employee: {emp.Name}, Salary: {emp.Salary}");
        }

    }
}
