using ModelLayer.DTOs;
using ModelLayer.Entities;

namespace BusinessLayer.Interfaces;

public interface IStudentBL
{
    Task<int> AddStudent(StudentDto dto);
    Task<IEnumerable<Course>> GetCourses(int studentId);
}