using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    struct Name                     //value-type
    {
        public String fName, lName;

        public  Name(String val1, String val2)
        {
            fName= val1;
            lName= val2;
        }

        public void display()
        {
            Console.WriteLine("First Name: " + fName + " " + " Last Name: " + lName);
        }
    }

    public class StructPractice
    {
        public static void Main(string[] args)
        {
            Name sp1;                   //new not required
            sp1.fName = "Rahul";
            sp1.lName = "Roy";
            sp1.display();

            Name sp2 = new Name("Raj", "Anand");
            sp2.display();

            Name sp3 = new Name();
            sp3 = sp2;
            sp2.fName = "Raunak";           //value-type
            sp3.display();
        }
    }
    
}
