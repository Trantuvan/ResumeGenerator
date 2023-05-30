namespace ResumeGenerator.API;

public class TemplateDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public string Theme { get; set; } = string.Empty;
    public string Font { get; set; } = string.Empty;
    public string FontSize { get; set; } = string.Empty;
}
