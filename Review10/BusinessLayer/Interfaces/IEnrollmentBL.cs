using ModelLayer.DTOs;
using ModelLayer.Entities;

namespace BusinessLayer.Interfaces;

public interface IEnrollmentBL
{
    Task EnrollStudent(EnrollmentDto dto);
    Task<IEnumerable<Student>> GetStudents(int courseId);
}