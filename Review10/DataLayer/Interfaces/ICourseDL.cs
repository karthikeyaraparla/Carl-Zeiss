using ModelLayer.Entities;

namespace DataLayer.Interfaces;

public interface ICourseDL
{
    Task<int> AddCourse(Course course);
}