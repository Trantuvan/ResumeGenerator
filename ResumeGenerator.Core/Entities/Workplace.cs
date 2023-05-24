namespace ResumeGenerator.Core;

public class Workplace : BaseEntity<Guid>
{
    public string Position { get; set; } = string.Empty;
    public string Employer { get; set; } = string.Empty;
    public bool IsInternship { get; set; } = false;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Description { get; set; } = string.Empty;
}
