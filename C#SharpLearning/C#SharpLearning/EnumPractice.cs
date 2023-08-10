using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    public enum Colors
    {
        blue, green = 5, red
    }
    internal class EnumPractice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((int)Colors.red);
        }
    }
}
