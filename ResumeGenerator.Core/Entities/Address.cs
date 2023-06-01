namespace ResumeGenerator.Core;

public class Address : BaseEntity<Guid>
{
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;

    /*NOTICE: 2 FKs EducationID & WorkplaceID are nullable.
     * Cascade on Delete is off. 
     * When Education | Workplace record is deleted. 
       Address record which depends on parent record above still remains value,
       just EduId | WorkplaceId (FK) set to null.
     RESULT: All Address records will be kept -> huge orphan data are being generated (not yet how to dealt with)
    */
    public Education? Education { get; set; } = default!;
    public Workplace? Workplace { get; set; } = default!;
    public ICollection<Person> People { get; set; } = new List<Person>();
    public ICollection<PersonAddress> PersonAddresses { get; set; } = new List<PersonAddress>();
}
