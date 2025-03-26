using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ex401_KhaiBaoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document theNote = new Note();
            IStorable isNote = theNote as IStorable;
            if (isNote != null)
            {
                isNote.Read();
                isNote.Write("");
            }
            theNote.Write("");

            Note note2 = new Note();
            IStorable isNote2 = note2 as IStorable;
            if (isNote != null)
            {
                isNote2.Read();
                isNote2.Write("");
            }
           


            Console.ReadLine();
            
        }
    }
}
