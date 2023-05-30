namespace ResumeGenerator.API;

public class CertificateDTO : BaseDTO
{
    public string Name { get; set; } = string.Empty;
    public DateTime Period { get; set; } = DateTime.MinValue;
    public bool IsPresent { get; set; } = false;
}
