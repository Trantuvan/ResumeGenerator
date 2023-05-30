namespace ResumeGenerator.API;

public class PersonDTO : BaseDTO
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? DOB { get; set; } = DateTime.MinValue;
    public string Gender { get; set; } = string.Empty;
    public string? Photo { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? HeadLine { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}
