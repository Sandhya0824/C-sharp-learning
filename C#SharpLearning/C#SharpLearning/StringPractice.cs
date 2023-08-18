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
            String str = "Geeks for Geeks";
            Console.WriteLine(str.Contains('f'));
            Console.WriteLine(str.Contains("for"));
            Console.WriteLine(str.Contains('F',StringComparison.OrdinalIgnoreCase));
        }

        public static void ReplaceMethod()
        {
            String str = "Hello Ballloon";
            Console.WriteLine(str.Replace('l', 'k'));

            String str1 = "Dance for Dance for";
            Console.WriteLine(str1.Replace("for", "enjoy"));

            Console.WriteLine(str);         //original string not changed it only return a new string
        }

        public static void ComparingStrings()
        {
            String str1 = "Dance India Dance";
            String str2 = "Dance";
            String str3 = "Dance India Dance";
            String str4 = "z";
            String str5 = "dance";

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));
            Console.WriteLine(str2.Equals(str5,StringComparison.OrdinalIgnoreCase));   

            Console.WriteLine(String.Compare(str1, str2));       //str1 is greater than str2
            Console.WriteLine(String.Compare(str1, str3));      //str1 is equal to str3
            Console.WriteLine(String.Compare(str1, str4));      //str1 is less than str4

            Console.WriteLine(str1.CompareTo(str2));       //str1 is greater than str2
            Console.WriteLine(str1.CompareTo(str3));      //str1 is equal to str3
            Console.WriteLine(str1.CompareTo(str4));      //str1 is less than str4
        }

        public static void SubString() 
        {
            String str1 = "HelloHowAreYou";
            Console.WriteLine(str1.Substring(5));
            Console.WriteLine(str1.Substring(5, 3));
        }

        public static void SplitMethod()
        {

            String str = "Da*nce, India, Dance";
            char[] separator = { ',', '*' };
            int count = 2;

            String[] stringSplit = str.Split(separator, count);

            foreach (String s in stringSplit)
            {
                Console.WriteLine(s);
            }
        }

        public static void StringInterpolation()
        {
            string name = "Ram";
            int i = 9;
            string msg = $"Welcome {name} {i}";
            Console.WriteLine(msg);
        }

        public static void StringBuilder()
        {
            string str1 = "hello", str2 = "hiiii";
            String.Concat(str1, str2);

            StringBuilder sb1 = new StringBuilder("Wel");
            StringBuilder sb2 = new StringBuilder("come");
            sb1.Append(sb2);

            Console.WriteLine(str1);        //immutable
            Console.WriteLine(sb1);         //mutable

            StringBuilder sb3 = new StringBuilder(str1);        //converting string ---> stringbuilder
            sb3.Append(str2);
            Console.WriteLine(sb3);

            Console.WriteLine(sb1.ToString());                  //converting stringbuilder ---> string
        }

        public static void StringFormat()
        {

        }

        public static void StringOperators()
        {
            string str1 = "school";
            string str2 = "School";
            string str3 = "SCHOOL";

            bool result1 = str1 == str2;
            bool result2 = str1 == str3;

            bool result3 = str1 != str2;
            bool result4 = str1 != str3;

            Console.WriteLine(result1 + " " + result2);
            Console.WriteLine(result3 + " " + result4);
        }

        public static void ConcatMethod()
        {
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(String.Concat(str1, str2));

            string[] strArray = new string[3];
            strArray[0] = "How ";
            strArray[1] = "are ";
            strArray[2] = "you ";

            Console.WriteLine(String.Concat(strArray));
        }

        public static void Basics()
        {
            string str1 = "Hello";

            Console.WriteLine(str1.IndexOf("e"));
            Console.WriteLine("{0}", 1);

        }

        public static void ConvertStringToInt()
        {
            string n1 = "100";
            int n2 = Int32.Parse(n1);

            string n3 = "10000000000000000";
            int n4 = 0;
            Int32.TryParse(n3, out n4);         //will give output as 0 instead of throwing exception if the range is out of bound
            Console.WriteLine(n4);
        }
    }
}

//array of characters
//string is an object of System.String class