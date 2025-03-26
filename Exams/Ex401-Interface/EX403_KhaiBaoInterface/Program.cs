using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX403_KhaiBaoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            IStorable storable=(IStorable)document;
            storable.Read();
            storable.Write("");
            Console.WriteLine(  "");
            document = new Note();
            storable = (IStorable)document;
            storable.Read();
            storable.Write("");
            storable.Write("");
            Note note = new Note();
            note.Read();
            note.WriteNote("", true);
            Console.ReadLine();
        }
    }
}
