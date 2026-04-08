using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dapper Context
builder.Services.AddSingleton<DapperContext>();

// Repositories
builder.Services.AddScoped<IStudentDL, StudentDL>();
builder.Services.AddScoped<IEnrollmentDL, EnrollmentDL>();
builder.Services.AddScoped<ICourseDL, CourseDL>();


// Services
builder.Services.AddScoped<IStudentBL, StudentBL>();
builder.Services.AddScoped<ICourseBL, CourseBL>();
builder.Services.AddScoped<IEnrollmentBL, EnrollmentBL>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();