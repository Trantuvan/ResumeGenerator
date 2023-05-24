namespace ResumeGenerator.Core;

public class Person : BaseEntity<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? DOB { get; set; } = DateTime.MinValue;
    public Genders Gender { get; set; } = Genders.Male;
    public string? Photo { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? HeadLine { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public ICollection<Address> Addresses { get; set; } = new List<Address>();
    public ICollection<Education> Educations { get; set; } = new List<Education>();
    public ICollection<Workplace> Workplaces { get; set; } = new List<Workplace>();
    public ICollection<Skill> Skills { get; set; } = new List<Skill>();
    public ICollection<Language> Languages { get; set; } = new List<Language>();
    public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
    public ICollection<Template> Templates { get; set; } = new List<Template>();
}

