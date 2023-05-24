namespace ResumeGenerator.Core;

public class Address : BaseEntity<Guid>
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;

    public Education Education { get; set; } = default!;
    public Workplace Workplace { get; set; } = default!;
    public ICollection<Person> People { get; set; } = new List<Person>();
}
