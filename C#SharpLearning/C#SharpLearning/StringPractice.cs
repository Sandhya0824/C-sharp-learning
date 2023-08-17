using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class StringPractice
    {
        public static void Main(string[] args)
        {
            string str1 = "Hello";

            Console.WriteLine(str1.IndexOf("e"));
            Console.WriteLine("{0}",1);

            //converting string to int
            string n1 = "100";
            int n2=Int32.Parse(n1);

            string n3 = "10000000000000000";
            int n4 = 0;
            Int32.TryParse(n3, out n4);         //will give output as 0 instead of throwing exception

            //concat method
            string str2 = "World";
            Console.WriteLine(String.Concat(str1,str2));

        }
    }
}

//array of characters
//string is an object of System.String class