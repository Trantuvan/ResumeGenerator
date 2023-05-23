namespace ResumeGenerator.Core.Entities;

public class Certificate : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; } = default!;
}
