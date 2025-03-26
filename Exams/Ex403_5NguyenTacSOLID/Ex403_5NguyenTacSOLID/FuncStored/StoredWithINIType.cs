using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex403_5NguyenTacSOLID.FuncStored
{
    public class StoredWithINIType : IStoreable
    {
        public List<Employee> Read(string path)
        {
            List<Employee> employees = new List<Employee>();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        string[] strings = line.Split(new char[] { ';' });
                        Employee employee = new Employee()
                        {
                            Name = strings[0],
                            Salary = Convert.ToDouble(strings[1])
                        };
                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }

        public void Write(string path, List<Employee> list)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Employee e in list)
                    {
                        sw.Write(e.Name);
                        sw.Write(e.Salary);
                        sw.Write('\n');
                    }
                }

            }

        }
    }
}
