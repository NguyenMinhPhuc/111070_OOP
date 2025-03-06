using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex301_DaHinh_QuanLyNhanVien
{
   abstract public class MyFile
    {
        public abstract string Path { get; set; }
        public abstract string Read();
        public abstract void Write();
    }
    public class MyFileText : MyFile
    {
        string path;
        public override string Path { get => path; set => path = value; }

       

        public override string Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class MyFileINI : MyFile
    {
        string path;
        public override string Path { get => path; set => path = value; }

        public override string Read()
        {
            string result = string.Empty;
            using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs)) {
                    string line = string.Empty;
                    while ((line=sr.ReadLine())!=null) { 
                        result += line;
                    }
                }

            }
            return result;
        }

        public override void Write()
        {
            string input = string.Empty;
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine(input);
                }
            }
        }
    }
}
