using Dapper;
using DataLayer.Repository;
using ModelLayer.Entities;

public class StudentDL : IStudentDL
{
    private readonly DapperContext _context;

    public StudentDL(DapperContext context)
    {
        _context = context;
    }

    public async Task<int> AddStudent(Student student)
    {
        var query = @"INSERT INTO Students (Name, Email)
                      VALUES (@Name, @Email);
                      SELECT CAST(SCOPE_IDENTITY() as int);";

        using var connection = _context.CreateConnection();
        return await connection.ExecuteScalarAsync<int>(query, student);
    }

    public async Task<IEnumerable<Course>> GetCoursesByStudent(int studentId)
    {
        var query = @"SELECT c.*
                      FROM Courses c
                      INNER JOIN Enrollments e ON c.CourseId = e.CourseId
                      WHERE e.StudentId = @StudentId";

        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<Course>(query, new { StudentId = studentId });
    }
}