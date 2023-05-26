namespace ResumeGenerator.Core;

public class PersonWorkplace : BaseEntity<Guid>
{
    public Guid PersonId { get; set; }
    public Guid WorkplaceId { get; set; }
}
