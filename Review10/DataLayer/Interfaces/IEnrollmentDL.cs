using ModelLayer.Entities;

namespace DataLayer.Interfaces;

public interface IEnrollmentDL
{
    Task EnrollStudent(int studentId, int courseId);
    Task<IEnumerable<Student>> GetStudentsByCourse(int courseId);
}