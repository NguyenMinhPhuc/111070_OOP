using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX403_KhaiBaoInterface
{
    internal class Note :Document
    {
        public override void Read()
        {
            Console.WriteLine("Read cua NOTE");
        }

        public override void Write(string path) { Console.WriteLine("Write cua NOTE"); }

        public void WriteNote(string path, bool status)
        {
            Console.WriteLine("Write 2 cuar NOTE");
        }
    }
}
