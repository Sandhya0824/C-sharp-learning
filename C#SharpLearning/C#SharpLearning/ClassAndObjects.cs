namespace C_SharpLearning
{
    public class Student
    {
        public int Id;
        public string Name;

        public static string School = "Kendriya Vidyalaya";

        public Student() { Console.WriteLine("Default Constructor"); }
        
        
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
            Student student = new Student();
            student.setDetails(1, "Ram");
            student.display();  

        }

       
    }
}