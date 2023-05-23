using ResumeGenerator.Core.Enums;

namespace ResumeGenerator.Core.Entities;

public class Skill : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public Levels Level { get; set; } = Levels.Beginer;

    public int PersonId { get; set; }
    public Person Person { get; set; } = default!;
}
