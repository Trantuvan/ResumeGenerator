namespace ResumeGenerator.Core;

public class Certificate : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public DateTime Period { get; set; } = DateTime.MinValue;
    public bool IsPresent { get; set; } = false;

    public int PersonId { get; set; }
    public Person Person { get; set; } = default!;
}
