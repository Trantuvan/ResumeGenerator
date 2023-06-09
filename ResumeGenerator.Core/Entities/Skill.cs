﻿namespace ResumeGenerator.Core;

public class Skill : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public Levels Level { get; set; } = Levels.Beginer;

    public Person Person { get; set; } = default!;
}
