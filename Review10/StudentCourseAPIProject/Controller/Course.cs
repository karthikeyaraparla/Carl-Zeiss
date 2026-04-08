using ModelLayer.DTOs;

namespace StudentCourseAPIProject.Controller;

using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/courses")]
public class CourseController : ControllerBase
{
    private readonly ICourseBL _courseBL;
    private readonly IEnrollmentBL _enrollmentBL;

    public CourseController(ICourseBL courseBL, IEnrollmentBL enrollmentBL)
    {
        _courseBL = courseBL;
        _enrollmentBL = enrollmentBL;
    }

    // POST: api/courses
    [HttpPost]
    public async Task<IActionResult> AddCourse(CourseDto dto)
    {
        var id = await _courseBL.AddCourse(dto);
        return Ok(new { CourseId = id });
    }

    // GET: api/courses/{id}/students
    [HttpGet("{id}/students")]
    public async Task<IActionResult> GetStudents(int id)
    {
        var result = await _enrollmentBL.GetStudents(id);
        return Ok(result);
    }
}