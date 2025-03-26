using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex403_5NguyenTacSOLID.FuncStored
{
    public class StoredManager
    {
        string typeStores;
        string path;
        List<Employee> employees;
        public string TypeStores { get => typeStores; set => typeStores = value; }
        public string Path { get => path; set => path = value; }

        IStoreable storeable;
        public StoredManager(string typeStored)
        {
            this.typeStores = typeStored;
            switch (typeStores)
            {
                case "ini":
                    storeable = new StoredWithINIType();
                    break;

                case "bin":
                    storeable = new StoredWithBinaryType();
                    break;
                case "sqllive":
                    storeable = new StoredWithSqlLive();
                    break;
            }
        }

        public List<Employee> Read()
        {
            return storeable.Read(path);
        }

        public void Write(string path)
        {
           storeable.Write(path, employees);
        }
    }
}
