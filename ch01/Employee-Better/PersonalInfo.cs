using System;

public class PersonalInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly? BirthDate { get; set; }
    public string Education { get; set; }
    public string Skills { get; set; }
    public string PreviousCompany { get; set; }

    public PersonalInfo(
        string? firstName,
        string? lastName,
        DateOnly? birthDate,
        string? education,
        string? skills,
        string? previousCompany)
    {
        FirstName = firstName ?? string.Empty;
        LastName = lastName ?? string.Empty;
        BirthDate = birthDate;
        Education = education ?? string.Empty;
        Skills = skills ?? string.Empty;
        PreviousCompany = previousCompany ?? string.Empty;
    }
}