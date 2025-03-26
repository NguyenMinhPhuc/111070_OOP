using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex401_KhaiBaoInterface
{
    internal interface IStorableCompressible:IStorable,ILoggedCompressible
    {
        void LogOriginalSize();
    }
}
