using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX403_KhaiBaoInterface
{
    internal class Document : IStorable
    {
        bool status;
        public bool Status { get => status; set => status=value; }

       
        public virtual void Read()
        {
            Console.WriteLine("Read cuar Doc");
        }

        public virtual void Write(string path)
        {
            Console.WriteLine("Write cua Doc");
        }

        public void Write(string path,bool status)
        {
            Console.WriteLine("Thuc thi phuong thuc Write cua interface IStorable");
        }
    }
}
