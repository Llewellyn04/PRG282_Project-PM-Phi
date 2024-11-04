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

        public void AddStudent(Student student)
        {

        }

        public void UpdateStudent(Student student)
        {

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