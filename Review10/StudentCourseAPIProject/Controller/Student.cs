using ModelLayer.DTOs;

namespace StudentCourseAPIProject.Controller;

using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/students")]
public class StudentController : ControllerBase
{
    private readonly IStudentBL _studentBL;

    public StudentController(IStudentBL studentBL)
    {
        _studentBL = studentBL;
    }

    // POST: api/students
    [HttpPost]
    public async Task<IActionResult> AddStudent(StudentDto dto)
    {
        var id = await _studentBL.AddStudent(dto);
        return Ok(new { StudentId = id });
    }

    // GET: api/students/{id}/courses
    [HttpGet("{id}/courses")]
    public async Task<IActionResult> GetCourses(int id)
    {
        var result = await _studentBL.GetCourses(id);
        return Ok(result);
    }
}