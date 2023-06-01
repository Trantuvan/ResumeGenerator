namespace ResumeGenerator.Core;

public class Address : BaseEntity<Guid>
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;

    public ICollection<Education> Educations { get; set; } = new List<Education>();
    public ICollection<EducationAddress> EducationAddresses { get; set; } = new List<EducationAddress>();
    public ICollection<Workplace> Workplaces { get; set; } = new List<Workplace>();
    public ICollection<WorkplaceAddress> WorkplaceAddresses { get; set; } = new List<WorkplaceAddress>();
    public ICollection<Person> People { get; set; } = new List<Person>();
    public ICollection<PersonAddress> PersonAddresses { get; set; } = new List<PersonAddress>();
}
