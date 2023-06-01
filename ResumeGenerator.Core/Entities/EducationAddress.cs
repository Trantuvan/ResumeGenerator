namespace ResumeGenerator.Core;

public class EducationAddress : BaseEntity<Guid>
{
    public Guid EducationId { get; set; }
    public Guid AddressId { get; set; }
}

