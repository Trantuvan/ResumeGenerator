using ResumeGenerator.Core.Enums;

namespace ResumeGenerator.Core.Entities;

public class Language : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Levels Level { get; set; } = Levels.Beginer;
}
