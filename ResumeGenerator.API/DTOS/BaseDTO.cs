using Microsoft.AspNetCore.Mvc;

namespace ResumeGenerator.API;

public class BaseDTO<T>
{
    [FromRoute]
    public T Id { get; set; } = default!;
}

public abstract class BaseDTO : BaseDTO<int> { }