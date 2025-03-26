using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex403_5NguyenTacSOLID.FuncStored
{
    public interface IStoreable
    {
        List<Employee> Read(string path);
        void Write(string path, List<Employee> employees);
    }
}
