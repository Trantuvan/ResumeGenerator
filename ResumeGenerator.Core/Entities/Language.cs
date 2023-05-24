namespace ResumeGenerator.Core;

public class Language : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public Levels Level { get; set; } = Levels.Beginer;
}
