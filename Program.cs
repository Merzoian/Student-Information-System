using System;
using StudentInformationSystem;

namespace StudentInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            manager.LoadData(); // Load data from file if exists

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Student Information System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course to Student");
                Console.WriteLine("3. View All Students");
                Console.WriteLine("4. View Student Details");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Filter by Major");
                Console.WriteLine("7. Sort Students by GPA");
                Console.WriteLine("8. Save & Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": manager.AddStudent(); break;
                    case "2": manager.AddCourseToStudent(); break;
                    case "3": manager.ViewAllStudents(); break;
                    case "4": manager.ViewStudentDetails(); break;
                    case "5": manager.DeleteStudent(); break;
                    case "6": manager.FilterByMajor(); break;
                    case "7": manager.SortByGPA(); break;
                    case "8":
                        manager.SaveData();
                        Console.WriteLine("Data saved. Exiting...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
