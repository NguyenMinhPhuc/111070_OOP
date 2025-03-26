using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX403_KhaiBaoInterface
{
    public interface ICompressible
    {
        void Compress();
        void Decompress();

    }

    public interface ILoggedCompressible: ICompressible
    {
        void LogSavedBytes();
    }

    public interface IDocument : IStorable, ILoggedCompressible
    {
        void ReadDoc();
    }
}
