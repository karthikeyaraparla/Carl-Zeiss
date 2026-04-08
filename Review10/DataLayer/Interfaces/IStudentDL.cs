using ModelLayer.Entities;

public interface IStudentDL
{
    Task<int> AddStudent(Student student);
    Task<IEnumerable<Course>> GetCoursesByStudent(int studentId);
}