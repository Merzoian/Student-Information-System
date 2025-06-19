using System;
using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem;

namespace StudentInformationSystem
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Major { get; set; }
        public List<Course> Courses { get; set; }

        public Student(string id, string name, string email, string major)
        {
            ID = id;
            Name = name;
            Email = email;
            Major = major;
            Courses = new List<Course>();
        }

        public double CalculateGPA()
        {
            if (Courses.Count == 0) return 0.0;
            return Courses.Average(c => c.Grade);
        }

        public string GetSummary()
        {
            return $"{ID}: {Name} | Major: {Major} | GPA: {CalculateGPA():F2}";
        }

        public string GetDetails()
        {
            string output = $"ID: {ID}\nName: {Name}\nEmail: {Email}\nMajor: {Major}\nGPA: {CalculateGPA():F2}\nCourses:\n";
            if (Courses.Count == 0)
                output += "  (No courses assigned)\n";
            else
                foreach (var course in Courses)
                    output += $"  - {course.Name}: {course.Grade}\n";
            return output;
        }
    }
}
