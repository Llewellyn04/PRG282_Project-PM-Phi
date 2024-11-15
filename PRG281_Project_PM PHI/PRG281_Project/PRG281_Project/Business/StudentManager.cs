using PRG281_Project.Data;
using PRG281_Project.Models;

namespace PRG281_Project.Business
{
    public class StudentManager
    {
        private readonly IDataAccess _dataAccess;

        public StudentManager(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Student> GetAllStudents()
        {
            return _dataAccess.GetAllStudents();
        }

        private void ValidateNameAndAge(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name) || string.IsNullOrWhiteSpace(student.Surname))
                throw new ArgumentException("Name and surname are required");

            if (student.Age < 16 || student.Age > 100)
                throw new ArgumentException("Age must be between 16 and 100");
        }

        public void AddStudent(Student student)
        {
            ValidateNameAndAge(student);
            _dataAccess.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            ValidateNameAndAge(student);
            _dataAccess.UpdateStudent(student);
        }

        public void DeleteStudent(int studentId)
        {
            _dataAccess.DeleteStudent(studentId);
        }

        public void GenerateSummary()
        {
            var students = GetAllStudents();
            int totalStudents = students.Count;
            double averageAge = students.Any() ? students.Average(s => s.Age) : 0;
            _dataAccess.SaveSummary(totalStudents, averageAge);
        }
    }
} 