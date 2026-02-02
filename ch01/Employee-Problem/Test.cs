using System.Globalization;

namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Problem;

public sealed class Test
{
    public static void Main(string[] args)
    {
        run1();
        run2();
    }

    private static void run1()
    {
        Console.WriteLine("Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Problem.Test.run1");
        // Example usage scenarios showing different meaningful states:

        // Scenario 1: New college graduate hire
        var newGrad = new Employee();
        newGrad.FirstName = "Sarah";
        newGrad.LastName = "Johnson";
        newGrad.Email = "sarah.johnson@company.com";
        newGrad.Department = "Engineering";
        newGrad.Position = "Junior Software Developer";
        newGrad.EmployeeId = "ENG2024001";
        newGrad.Education = "BS Computer Science, MIT";
        newGrad.EmploymentType = "Full-time";
        newGrad.Salary = decimal.Parse("75000", CultureInfo.InvariantCulture);

        // Scenario 2: Senior executive with security clearance
        var executive = new Employee();
        executive.FirstName = "Michael";
        executive.LastName = "Chen";
        executive.Email = "m.chen@company.com";
        executive.Department = "Defense Contracts";
        executive.Position = "Senior Director";
        executive.EmployeeId = "EXE2020045";
        executive.HireDate = new DateOnly(2020, 3, 15);
        executive.Salary = decimal.Parse("180000", CultureInfo.InvariantCulture);
        executive.SecurityClearance = "Top Secret";
        executive.WorkLocation = "Washington DC";
        executive.PreviousCompany = "Lockheed Martin";
        executive.Skills = "Project Management, Government Relations, Systems Architecture";

        // Scenario 3: Remote contractor
        var contractor = new Employee();
        contractor.FirstName = "Elena";
        contractor.LastName = "Rodriguez";
        contractor.Email = "elena.contractor@company.com";
        contractor.Department = "Marketing";
        contractor.Position = "UI/UX Designer";
        contractor.EmploymentType = "Contract";
        contractor.IsRemoteWorker = true;
        contractor.TimeZone = "PST";
        contractor.WorkLocation = "Remote - California";
        contractor.Skills = "Figma, Adobe Creative Suite, User Research";
        contractor.HireDate = new DateOnly(2024, 1, 10);

        // Scenario 4: Part-time intern
        var intern = new Employee();
        intern.FirstName = "Alex";
        intern.LastName = "Kim";
        intern.Email = "alex.kim.intern@company.com";
        intern.Department = "Data Science";
        intern.Position = "Data Analyst Intern";
        intern.EmploymentType = "Intern";
        intern.Manager = "Dr. Lisa Wang";
        intern.Education = "MS Data Science, Stanford (Expected 2025)";
        intern.HireDate = new DateOnly(2024, 6, 1);
        intern.WorkLocation = "Palo Alto Office";

        // Scenario 5: International employee transferring
        var international = new Employee();
        international.FirstName = "Raj";
        international.LastName = "Patel";
        international.Email = "raj.patel@company.com";
        international.Department = "Global Operations";
        international.Position = "Operations Manager";
        international.EmployeeId = "OPS2023012";
        international.HireDate = new DateOnly(2023, 9, 1);
        international.Salary = decimal.Parse("95000", CultureInfo.InvariantCulture);
        international.WorkLocation = "London Office";
        international.TimeZone = "GMT";
        international.PreviousCompany = "Company India Subsidiary";
        international.EmergencyContact = "Priya Patel (Spouse)";
        international.EmergencyPhone = "+44-20-1234-5678";

        // Scenario 6: Returning employee (rehire)
        var rehire = new Employee();
        rehire.FirstName = "Jennifer";
        rehire.LastName = "Thompson";
        rehire.Email = "jennifer.thompson@company.com";
        rehire.Department = "Product Management";
        rehire.Position = "Senior Product Manager";
        rehire.EmployeeId = "PM2018003"; // Keeping old ID
        rehire.HireDate = new DateOnly(2024, 7, 15); // New hire date
        rehire.Salary = decimal.Parse("125000", CultureInfo.InvariantCulture);
        rehire.PreviousCompany = "Meta"; // Where they worked between
        rehire.Skills = "Product Strategy, A/B Testing, SQL, Python";
        rehire.Manager = "VP Product";
    }

    private static void run2()
    {
        Console.WriteLine("Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Problem.Main.run2");

        // 1) Default constructor (uses defaults: hireDate=now, employmentType="Full-time", etc.)
        var e0 = new Employee();

        // 2) Basic employee constructor
        var e1 = new Employee(
            "Sarah",
            "Johnson",
            "sarah.johnson@company.com",
            "Engineering"
        );

        // 3) New hire constructor (adds position + explicit hireDate)
        var e2 = new Employee(
            "Alex",
            "Kim",
            "alex.kim@company.com",
            "Data Science",
            "Data Analyst Intern",
            new DateOnly(2024, 6, 1)
        );

        // 4) Full employee constructor (the long one)
        var e3 = new Employee(
            "Michael",
            "Chen",
            "m.chen@company.com",
            "+1-202-555-0100",
            "Defense Contracts",
            "Senior Director",
            "EXE2020045",
            new DateOnly(2020, 3, 15),
            decimal.Parse("180000", CultureInfo.InvariantCulture),
            "CEO"
        );

        // 5) Another “full” example (different data, same constructor)
        var e4 = new Employee(
            "Elena",
            "Rodriguez",
            "elena.rodriguez@company.com",
            "+1-415-555-0142",
            "Marketing",
            "UI/UX Designer",
            "MKT2024019",
            new DateOnly(2024, 1, 10),
            decimal.Parse("95000", CultureInfo.InvariantCulture),
            "Creative Director"
        );
    }
}