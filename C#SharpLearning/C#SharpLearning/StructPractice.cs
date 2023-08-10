using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    struct StructPractice
    {
        public String fName, lName;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            StructPractice sp1= new StructPractice();
            sp1.fName = "Rahul";
            sp1.lName = "Roy";
            Console.WriteLine(sp1.fName+" "+sp1.lName);
        }
    }
    
}
