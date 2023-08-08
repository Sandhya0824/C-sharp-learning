namespace C_Learning
{
    public enum Colors
    {
        blue, green=5, red
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Colors.blue); Console.WriteLine((int)Colors.green); Console.WriteLine((int)Colors.red);

            Console.WriteLine("Enter your name: ");
            String s=Console.ReadLine();

            Console.WriteLine("Enter your marks:");
            int m =Convert.ToInt32(Console.ReadLine());

            String startsWith=s.Substring(0, 1);

            if(m >= 90)
            {
                Console.WriteLine("Eligible in Old Group {0}",startsWith.ToUpper());
            }
            else if(m>=80 && m < 90)
            {
                Console.WriteLine("Eligible in Middle Group {0}", startsWith.ToUpper());
            }
            else if (m >= 70 && m < 80)
            {
                Console.WriteLine("Eligible in Young Group {0}", startsWith.ToUpper());
            }
            else
            {
                Console.WriteLine("Not eligble in any Group for now!!!");
            }

            int k = 0;
            change(out k);
            Console.WriteLine( k);

        }

        public static void change(out int a)
        {
            a = 5;

        }

        public static void arr(int[] a)
        {
            int[] a1 = new int[3];
            int[,] a2=new int[3,4];
            int[][] a3=new int[3][];

            int[][] a4=new int[3][]
            {
                new int[] {2,3,4},
                new int[] {2,3,4,5},    
                new int[] {2,3,4,6},    
            };

            
        }
    }
}