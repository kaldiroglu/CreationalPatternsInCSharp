namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Employee.Better
{
    public class ContactInfo
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }

        // Parameterized constructor - null-safe assignment
        public ContactInfo(string email, string phoneNumber, string emergencyContact, string emergencyPhone)
        {
            Email = email ?? string.Empty;
            PhoneNumber = phoneNumber ?? string.Empty;
            EmergencyContact = emergencyContact ?? string.Empty;
            EmergencyPhone = emergencyPhone ?? string.Empty;
        }
    }
}