namespace MedicalEquipmentMarket.Security.Model
{
    public class BaseUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastNmae { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string CompanyInfo { get; set; }

        public int AddressId { get; set; }

        public BaseUser(int id, string userName, string name, string lastNmae, string phoneNumber, string occupation, string companyInfo, int addressId)
        {
            Id = id;
            UserName = userName;
            Name = name;
            LastNmae = lastNmae;
            PhoneNumber = phoneNumber;
            Occupation = occupation;
            CompanyInfo = companyInfo;
            AddressId = addressId;
        }
        public BaseUser()
        {

        }
    }
}
