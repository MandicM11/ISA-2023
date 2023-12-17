namespace MedicalEquipmentMarket.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address{ get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<CompanyEquipment> CompanyEquipments { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public Company()
        {

        }
        public Company(int id, string name, string address, string city, string phoneNumber)
        {
            CompanyId = id;
            Name = name;
            Address = address;
            City = city;
            PhoneNumber = phoneNumber;

        }
    }
}
