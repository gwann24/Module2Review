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
            student1.AddGrade(99.2);
            student1.AddGrade(91.7, 78.1, 89.6);
            student2.AddGrade(98.3);
            student2.AddGrade(77.1, 100, 93.4);
            student3.AddGrade(97.3);
            student3.AddGrade(100, 88.1, 96.9);
            student4.AddGrade(91.1);
            student4.AddGrade(69.6, 85.2, 99);
            foreach (Student student in students)
            {
                Console.WriteLine($"\nGrades for {student.Id} - {student.Name}");
                Console.WriteLine("Grades\t1\t2\t3\t4");
                foreach (double grade in student.Grades)
                {
                    Console.Write($"\t{Math.Round(grade,2)}");
                }
                Console.WriteLine($"\nGPA is {Math.Round(student.CalculateAverageGrade(),2)}");
            }
            Course course1 = new Course();
            course1.CourseName = "American History";
            course1.CourseCode = "AM001";
            Student newStudent1 = new Student("Papa Smurf", 5);
            course1.AddStudent2Course(newStudent1);
            course1.AddStudent2Course(newStudent1);
            Student newStudent2 = new Student("Brainy Smurf", 6);
            course1.AddStudent2Course(newStudent2);
            Console.WriteLine($"\n\nCourse Code: {course1.CourseCode}");
            Console.WriteLine($"Course Name: {course1.CourseName}");
            Console.WriteLine("Enrolled Students");
            Console.WriteLine("\nID\tName");
            foreach (Student pupil in course1.EStudents)
            {
                //ConsoleWriteLine(students.IndexOf(pupil));
                Console.WriteLine($"{pupil.Id}\t{pupil.Name}");
            };
        }
    }
}
