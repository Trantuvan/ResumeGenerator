namespace ResumeGenerator.API;

public class AddressDTO : BaseDTO
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;
}
