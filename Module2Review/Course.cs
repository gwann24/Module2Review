using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    public class Course
    {
        public Course()
        {
            _enrolledStudents = new List<Student>();
        }

        private List<Student> _enrolledStudents;
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public void AddStudent2Course (Student nPupil)
        {
            if (!(_enrolledStudents.Contains(nPupil)))
            {
                _enrolledStudents.Add(nPupil);
            } else
            {
                Console.WriteLine($"\n\nStudent {nPupil.Name} already in the course");
            };
        }

        public List<Student> EStudents { get { return _enrolledStudents; } }

    }
}
