namespace Module2Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<Student> students = new List<Student>();
            Student student1 = new Student();
            student1.Name = "Jonathan Archer";
            student1.Id = 1;
            students.Add(student1);
            Student student2 = new Student { Name = "James Kirk", Id = 2 };
            students.Add (student2);
            Student student3 = new Student("Jean-Luc Picard",3);
            students.Add(student3);
            Student student4 = new Student("Kathryn Janeway", 4);
            students.Add((Student)student4);
        }
    }
}
