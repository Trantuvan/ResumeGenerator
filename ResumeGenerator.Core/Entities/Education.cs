namespace ResumeGenerator.Core;

public class Education : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; } = DateTime.MinValue;
    public DateTime? EndDate { get; set; } = DateTime.MinValue;
    public bool IsPresent { get; set; } = false;
    public string? Description { get; set; }

    public ICollection<Person> People { get; set; } = new List<Person>();
    public ICollection<PersonEducation> PersonEducations { get; set; } = new List<PersonEducation>();
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
    public ICollection<EducationAddress> EducationAddresses { get; set; } = new List<EducationAddress>();
}
