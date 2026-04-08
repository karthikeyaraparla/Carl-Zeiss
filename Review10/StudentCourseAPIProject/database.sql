CREATE DATABASE StudentCourseApiProject;
GO

USE StudentCourseApiProject;
GO

CREATE TABLE Students
(
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Email VARCHAR(100)
);
GO

CREATE TABLE Courses
(
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName VARCHAR(100),
    Duration INT
);
GO

CREATE TABLE Enrollments
(
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT,
    CourseId INT,
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);
GO

SELECT * FROM Students;
SELECT * FROM Courses;
SELECT * FROM Enrollments;
GO
