namespace StudentInformationSystem
{
    public class Course
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Course(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
