namespace MedicalEquipmentMarket.Model
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public double Price { get; set; }

        public Equipment() { 
        
        }
        public  Equipment(int id,string name, string description, double price)
        {
            this.EquipmentId= id;
            this.Name= name;
            this.Description= description;
            this.Price= price;
        }
    }
}
