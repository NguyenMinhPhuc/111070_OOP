using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4033_NguyenTac03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Square());

            shapes.Add(new Rectangle());

            foreach (IShape shape in shapes) {
                shape.GetArea();
            }
        }
        
    }
}
