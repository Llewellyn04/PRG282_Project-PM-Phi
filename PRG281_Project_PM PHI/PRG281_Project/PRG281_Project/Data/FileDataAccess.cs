using PRG281_Project.Models;

namespace PRG281_Project.Data
{
    public class FileDataAccess : IDataAccess
    {
        private readonly string studentsFile = "students.txt";
        private readonly string summaryFile = "summary.txt";

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            if (File.Exists(studentsFile))
            {
                var lines = File.ReadAllLines(studentsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        students.Add(new Student(
                            int.Parse(parts[0]),
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                            parts[4]
                        ));
                    }
                }
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            File.AppendAllText(studentsFile, student.ToString() + Environment.NewLine);
        }

        public void UpdateStudent(Student student)
        {
            var students = GetAllStudents();
            var index = students.FindIndex(s => s.StudentId == student.StudentId);
            if (index != -1)
            {
                students[index] = student;
                SaveAllStudents(students);
            }
        }

        public void DeleteStudent(int studentId)
        {
            var students = GetAllStudents();
            var studentToDelete = students.FirstOrDefault(s => s.StudentId == studentId);
          
            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                SaveAllStudents(students);
            }
        }



        public void SaveSummary(int totalStudents, double averageAge)
        {
            string summary = $"Total Students: {totalStudents}\nAverage Age: {averageAge:F2}";
            File.WriteAllText(summaryFile, summary);
        }

        private void SaveAllStudents(List<Student> students)
        {
            File.WriteAllLines(studentsFile, students.Select(s => s.ToString()));
        }
    }
} 