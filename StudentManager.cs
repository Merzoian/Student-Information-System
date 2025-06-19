using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace StudentInformationSystem
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();
        private const string FilePath = "students.json";

        public void AddStudent()
        {
            Console.Write("Student ID: ");
            string id = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Major: ");
            string major = Console.ReadLine();

            students.Add(new Student(id, name, email, major));
            Console.WriteLine("Student added!");
        }

        public void AddCourseToStudent()
        {
            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Grade (0-4 scale): ");
            double grade = double.Parse(Console.ReadLine());

            student.Courses.Add(new Course(courseName, grade));
            Console.WriteLine("Course added.");
        }

        public void ViewAllStudents()
        {
            if (!students.Any())
            {
                Console.WriteLine("No students to display.");
                return;
            }

            foreach (var student in students)
                Console.WriteLine(student.GetSummary());
        }

        public void ViewStudentDetails()
        {
            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
                Console.WriteLine(student.GetDetails());
            else
                Console.WriteLine("Student not found.");
        }

        public void DeleteStudent()
        {
            Console.Write("Enter student ID to delete: ");
            string id = Console.ReadLine();
            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void FilterByMajor()
        {
            Console.Write("Enter major to filter: ");
            string major = Console.ReadLine();
            var filtered = students.Where(s => s.Major.Equals(major, StringComparison.OrdinalIgnoreCase));
            foreach (var s in filtered)
                Console.WriteLine(s.GetSummary());
        }

        public void SortByGPA()
        {
            var sorted = students.OrderByDescending(s => s.CalculateGPA());
            foreach (var s in sorted)
                Console.WriteLine(s.GetSummary());
        }

        public void SaveData()
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public void LoadData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                students = JsonSerializer.Deserialize<List<Student>>(json);
            }
        }
    }
}
