using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using ModelLayer.DTOs;
using ModelLayer.Entities;

public class CourseBL : ICourseBL
{
    private readonly ICourseDL _courseRepo;

    public CourseBL(ICourseDL courseRepo)
    {
        _courseRepo = courseRepo;
    }

    public async Task<int> AddCourse(CourseDto dto)
    {
        var course = new Course
        {
            CourseName = dto.CourseName,
            Duration = dto.Duration
        };

        return await _courseRepo.AddCourse(course);
    }
}