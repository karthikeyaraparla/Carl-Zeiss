using BusinessLayer.Interfaces;
using ModelLayer.DTOs;
using ModelLayer.Entities;

public class StudentBL : IStudentBL
{
    private readonly IStudentDL _studentRepo;

    public StudentBL(IStudentDL studentRepo)
    {
        _studentRepo = studentRepo;
    }

    public async Task<int> AddStudent(StudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Email = dto.Email
        };

        return await _studentRepo.AddStudent(student);
    }

    public async Task<IEnumerable<Course>> GetCourses(int studentId)
    {
        return await _studentRepo.GetCoursesByStudent(studentId);
    }
}