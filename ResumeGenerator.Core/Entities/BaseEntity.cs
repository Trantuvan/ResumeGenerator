﻿namespace ResumeGenerator.Core;

public class BaseEntity<T>
{
    public T Id { get; set; } = default!;
}
