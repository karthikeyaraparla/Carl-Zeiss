using ModelLayer.DTOs;

namespace StudentCourseAPIProject.Controller;

using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/enrollments")]
public class EnrollmentController : ControllerBase
{
    private readonly IEnrollmentBL _enrollmentBL;

    public EnrollmentController(IEnrollmentBL enrollmentBL)
    {
        _enrollmentBL = enrollmentBL;
    }

    // POST: api/enrollments
    [HttpPost]
    public async Task<IActionResult> Enroll(EnrollmentDto dto)
    {
        await _enrollmentBL.EnrollStudent(dto);
        return Ok("Enrollment successful");
    }
}