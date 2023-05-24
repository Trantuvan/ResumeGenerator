namespace ResumeGenerator.Core;

public class Education : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string School { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Description { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; } = default!;
}
