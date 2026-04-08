using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using ModelLayer.DTOs;
using ModelLayer.Entities;

public class EnrollmentBL : IEnrollmentBL
{
    private readonly IEnrollmentDL _repo;

    public EnrollmentBL(IEnrollmentDL repo)
    {
        _repo = repo;
    }

    public async Task EnrollStudent(EnrollmentDto dto)
    {
        await _repo.EnrollStudent(dto.StudentId, dto.CourseId);
    }

    public async Task<IEnumerable<Student>> GetStudents(int courseId)
    {
        return await _repo.GetStudentsByCourse(courseId);
    }
}