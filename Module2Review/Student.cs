using Module2Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review
{
    public class Student
    {
        public Student()
        {
            
        }
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        List<double> Grades { get; set; } = new List<double>();

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            double gpa = 0;
            if (Grades.Count > 0)
            {
                gpa = Grades.Average();
            };
            return gpa;
        }
    }
}
