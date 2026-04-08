using ModelLayer.DTOs;

namespace BusinessLayer.Interfaces;

public interface ICourseBL
{
    Task<int> AddCourse(CourseDto dto);
}