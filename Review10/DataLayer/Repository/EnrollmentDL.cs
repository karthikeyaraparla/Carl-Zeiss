using Dapper;
using ModelLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Repository;

public class EnrollmentDL : IEnrollmentDL
{
    private readonly DapperContext _context;

    public EnrollmentDL(DapperContext context)
    {
        _context = context;
    }

    public async Task EnrollStudent(int studentId, int courseId)
    {
        var query = @"INSERT INTO Enrollments (StudentId, CourseId)
                      VALUES (@StudentId, @CourseId)";

        using var connection = _context.CreateConnection();
        await connection.ExecuteAsync(query, new { StudentId = studentId, CourseId = courseId });
    }

    public async Task<IEnumerable<Student>> GetStudentsByCourse(int courseId)
    {
        var query = @"SELECT s.*
                      FROM Students s
                      INNER JOIN Enrollments e ON s.StudentId = e.StudentId
                      WHERE e.CourseId = @CourseId";

        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<Student>(query, new { CourseId = courseId });
    }
}