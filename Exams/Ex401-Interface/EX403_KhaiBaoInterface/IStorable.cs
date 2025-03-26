using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX403_KhaiBaoInterface
{
    public interface IStorable
    {
        bool Status { get; set; }

        void Read();//prototype
        void Write(string path);
        void Write(string path,bool status);
    }
}
