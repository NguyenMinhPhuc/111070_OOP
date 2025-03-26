using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4033_NguyenTac03
{
    public class Square :IShape
    {
        int height;

        public int Height { get => height; set => height = value; }

        public int GetArea()
        {
           return height*height;
        }
    }
}


    
