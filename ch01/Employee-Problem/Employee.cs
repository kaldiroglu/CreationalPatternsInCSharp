namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Problem;

public class Employee
{
    // Default constructor for post-construction initialization
    public Employee()
    {
        HireDate = DateOnly.FromDateTime(DateTime.Now);
        EmploymentType = "Full-time";
        IsRemoteWorker = false;
        TimeZone = "EST";
    }

    // Imagine trying to create constructors for all meaningful combinations:

    // Basic employee constructor
    public Employee(string firstName, string lastName, string email, string department)
        : this()
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Department = department;
    }

    // New hire constructor
    public Employee(string firstName, string lastName, string email, string department,
        string position, DateOnly hireDate)
        : this(firstName, lastName, email, department)
    {
        Position = position;
        HireDate = hireDate;
    }

    // Full employee constructor - but this is getting unwieldy!
    public Employee(string firstName, string lastName, string email, string phoneNumber,
        string department, string position, string employeeId, DateOnly hireDate,
        decimal salary, string manager)
        : this(firstName, lastName, email, department, position, hireDate)
    {
        PhoneNumber = phoneNumber;
        EmployeeId = employeeId;
        Salary = salary;
        Manager = manager;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Department { get; set; }
    public string Position { get; set; }
    public string EmployeeId { get; set; }
    public DateOnly HireDate { get; set; }
    public DateOnly? BirthDate { get; set; }
    public decimal? Salary { get; set; }
    public string Manager { get; set; }
    public string WorkLocation { get; set; }
    public string EmploymentType { get; set; } // Full-time, Part-time, Contract, Intern
    public string SecurityClearance { get; set; }
    public string EmergencyContact { get; set; }
    public string EmergencyPhone { get; set; }
    public bool IsRemoteWorker { get; set; }
    public string TimeZone { get; set; }
    public string Skills { get; set; }
    public string Education { get; set; }
    public string PreviousCompany { get; set; }

    // We'd need hundreds more constructors for different combinations!
    // What about contractors? Remote workers? Interns with different fields?

    // Setter methods for post-construction initialization
    public void SetFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        LastName = lastName;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void SetDepartment(string department)
    {
        Department = department;
    }

    public void SetPosition(string position)
    {
        Position = position;
    }

    public void SetEmployeeId(string employeeId)
    {
        EmployeeId = employeeId;
    }

    public void SetHireDate(DateOnly hireDate)
    {
        HireDate = hireDate;
    }

    public void SetBirthDate(DateOnly birthDate)
    {
        BirthDate = birthDate;
    }

    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }

    public void SetManager(string manager)
    {
        Manager = manager;
    }

    public void SetWorkLocation(string workLocation)
    {
        WorkLocation = workLocation;
    }

    public void SetEmploymentType(string employmentType)
    {
        EmploymentType = employmentType;
    }

    public void SetSecurityClearance(string securityClearance)
    {
        SecurityClearance = securityClearance;
    }

    public void SetEmergencyContact(string emergencyContact)
    {
        EmergencyContact = emergencyContact;
    }

    public void SetEmergencyPhone(string emergencyPhone)
    {
        EmergencyPhone = emergencyPhone;
    }

    public void SetRemoteWorker(bool remoteWorker)
    {
        IsRemoteWorker = remoteWorker;
    }

    public void SetTimeZone(string timeZone)
    {
        TimeZone = timeZone;
    }

    public void SetSkills(string skills)
    {
        Skills = skills;
    }

    public void SetEducation(string education)
    {
        Education = education;
    }

    public void SetPreviousCompany(string previousCompany)
    {
        PreviousCompany = previousCompany;
    }
}

// ... existing code ...