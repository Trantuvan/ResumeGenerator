namespace ResumeGenerator.Core;

public class Template : BaseEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public ResumeTheme? Theme { get; set; } = ResumeTheme.Professional;
    public FontFamilies? Font { get; set; } = FontFamilies.Poppins;
    public FontSizes? FontSize { get; set; } = FontSizes.M;

    public int PersonId { get; set; }
    public Person Person { get; set; } = default!;
}
