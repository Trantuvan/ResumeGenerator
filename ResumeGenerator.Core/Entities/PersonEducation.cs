namespace ResumeGenerator.Core;

public class PersonEducation : BaseEntity<Guid>
{
    public Guid PersonId { get; set; }
    public Guid EducationId { get; set; }
}
