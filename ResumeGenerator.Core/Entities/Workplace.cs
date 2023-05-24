namespace ResumeGenerator.Core;

public class Workplace : BaseEntity<Guid>
{
    public string Position { get; set; } = string.Empty;
    public string Employer { get; set; } = string.Empty;
    public bool IsInternship { get; set; } = false;
    public DateTime StartDate { get; set; } = DateTime.MinValue;
    public DateTime EndDate { get; set; } = DateTime.MinValue;
    public bool IsPresent { get; set; } = false;
    public string? Description { get; set; } = string.Empty;

    public ICollection<Person> People { get; set; } = new List<Person>();
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
}
