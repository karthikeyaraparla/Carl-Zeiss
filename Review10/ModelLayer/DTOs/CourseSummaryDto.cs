namespace ModelLayer.DTOs;

public class CourseSummaryDto
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = string.Empty;

    public int Duration { get; set; }
}
