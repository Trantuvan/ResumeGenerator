namespace ResumeGenerator.Core;
public class WorkplaceAddress : BaseEntity<Guid>
{
    public Guid WorkplaceId { get; set; }
    public Guid AddressId { get; set; }
}

