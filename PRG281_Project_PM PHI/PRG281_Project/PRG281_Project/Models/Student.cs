namespace PRG281_Project.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int studentId, string name, string surname, int age, string course)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return $"{StudentId},{Name},{Surname},{Age},{Course}";
        }
    }
} 