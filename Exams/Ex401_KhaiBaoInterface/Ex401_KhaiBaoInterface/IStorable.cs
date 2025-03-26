using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_KhaiBaoInterface
{
    public interface IStorable
    {
        int Status { get; set; }
        void Read();
        void Write(Object obj);
    }
}
