using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_KhaiBaoInterface
{
    public class Document : IStorable,ILoggedCompressible
    {
        int status;
        public int Status { get => status; set => status= value; }

        public void Compress()
        {
            throw new NotImplementedException();
        }

        public void DeCompress()
        {
            throw new NotImplementedException();
        }

        public void LogSavedBytes()
        {
            throw new NotImplementedException();
        }
        void ILoggedCompressible.Read() { Console.WriteLine(""); }
        public virtual void Read()
        {
            Console.WriteLine("Implement the Read Method for IStorable") ;
        }

        public void Write(object obj)
        {
            Console.WriteLine("Implement the Write Method for IStorable") ;
        }
    }
}
