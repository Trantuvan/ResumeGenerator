namespace ResumeGenerator.Core;

public class PersonAddress : BaseEntity<Guid>
{
    public Guid PersonId { get; set; }
    public Guid AddressId { get; set; }
}
