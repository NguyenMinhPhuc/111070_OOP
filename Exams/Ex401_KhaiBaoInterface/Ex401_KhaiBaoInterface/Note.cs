using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_KhaiBaoInterface
{
    public class Note : Document
    {
        public override void Read()
        {
            Console.WriteLine("Read cua note");
        }

        public new void Write(object obj) { Console.WriteLine("Write của note"); }
    }
}
