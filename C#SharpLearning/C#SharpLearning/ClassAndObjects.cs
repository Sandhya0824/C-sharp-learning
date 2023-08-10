namespace C_SharpLearning
{
    public class Student
    {
        public int Id;
        public string Name;

        public static string School = "Kendriya Vidyalaya";

        public static int count=0;

        public Student() { Console.WriteLine("Default Constructor"); count++; }  //default constructor
        
        public void setDetails(int id, string name)
        {
            Id = id;
            Name = name;
          
        }

        ~Student() { Console.WriteLine("Default Destructor"); }

        public void display() 
        {
            Console.WriteLine("Id : "+ Id+ " Name : "+ Name+ " School : "+ School);
        }

    }
    
    class ClassAndObjects
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setDetails(1, "Ram");
            s1.display();

            Student s2 = new Student();
            s2.setDetails(2, "Sita");
            s2.display();

            Student s3 = new Student();
            s3 = s1;
            s1.Name = "Shyam";              //reference type
            s3.display();

            Console.WriteLine("No. of students: " + Student.count);
        }

       
    }
}