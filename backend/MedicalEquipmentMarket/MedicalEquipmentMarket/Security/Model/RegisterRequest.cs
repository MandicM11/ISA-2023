using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MedicalEquipmentMarket.Security.Model
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string CompanyInfo { get; set; }
        public string Address { get; set; }
        public RegisterRequest(string username, string password, string email, string name, string lastName, string phoneNumber, string occupation, string companyInfo, string address)
        {
            Username = username;
            Password = password;
            Email = email;
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
            CompanyInfo = companyInfo;
            Address = address;
        }
        public RegisterRequest()
        {

        }
    }
}
