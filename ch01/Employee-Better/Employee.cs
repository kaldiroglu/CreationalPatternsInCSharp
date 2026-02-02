using System;

namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Better
{
    public class Employee
    {
        public PersonalInfo Personal { get; private set; }
        public ContactInfo Contact { get; private set; }
        public JobInfo Job { get; private set; }
        public WorkInfo Work { get; private set; }
        public Compensation Compensation { get; private set; }

        public Employee(
            PersonalInfo? personal,
            ContactInfo? contact,
            JobInfo? job,
            WorkInfo? work,
            Compensation? compensation)
        {
            Personal = personal ?? new PersonalInfo("", "", null, "", "", "");
            Contact  = contact  ?? new ContactInfo("", "", "", "");
            Job      = job      ?? new JobInfo("", "", "", "", new DateOnly(), "", "");

            if (string.IsNullOrWhiteSpace(Job.EmploymentType))
            {
                Job.EmploymentType = "Full-time";
            }

            Work = work ?? new WorkInfo("", false, "EST");

            if (string.IsNullOrWhiteSpace(Work.TimeZone))
            {
                Work.TimeZone = "EST";
            }

            // Keep behavior consistent: if you want a default Compensation when null, uncomment:
            // Compensation = compensation ?? new Compensation();
            Compensation = compensation!;
        }
    }
}