using PRG281_Project.Models;

namespace PRG281_Project.Data
{
    public interface IDataAccess
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);
        void SaveSummary(int totalStudents, double averageAge);
    }
} 