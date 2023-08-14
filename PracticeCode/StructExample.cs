using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class StructExample
    {
        public int width, height;

        public StructExample(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
        public static void Main()
        {
            StructExample r = new StructExample(5, 6);
            r.areaOfRectangle();
        }
    }
}
