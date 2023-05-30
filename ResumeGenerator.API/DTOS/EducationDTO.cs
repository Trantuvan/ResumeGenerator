namespace ResumeGenerator.API;

public class EducationDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; } = DateTime.MinValue;
    public DateTime? EndDate { get; set; } = DateTime.MinValue;
    public bool IsPresent { get; set; } = false;
    public string? Description { get; set; }
}
