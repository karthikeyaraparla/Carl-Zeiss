using Dapper;
using DataLayer.Interfaces;
using DataLayer.Repository;
using ModelLayer.Entities;

public class CourseDL : ICourseDL
{
    private readonly DapperContext _context;

    public CourseDL(DapperContext context)
    {
        _context = context;
    }

    public async Task<int> AddCourse(Course course)
    {
        var query = @"INSERT INTO Courses (CourseName, Duration)
                      VALUES (@CourseName, @Duration);
                      SELECT CAST(SCOPE_IDENTITY() as int);";

        using var connection = _context.CreateConnection();
        return await connection.ExecuteScalarAsync<int>(query, course);
    }
}