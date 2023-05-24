namespace ResumeGenerator.Core;

public class Address : BaseEntity<Guid>
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;

    public int EducationId { get; set; }
    public int WorkplaceId { get; set; }
    public int PersonId { get; set; }
    public Education Education { get; set; } = default!;
    public Workplace Workplace { get; set; } = default!;
    public Person Person { get; set; } = default!;
}
