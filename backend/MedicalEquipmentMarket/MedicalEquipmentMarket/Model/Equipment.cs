namespace MedicalEquipmentMarket.Model
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public double Price { get; set; }

        public Equipment() { 
        
        }
        public  Equipment(int Id,string Name, string Description, double Price)
        {
            this.Id= Id;
            this.Name= Name;
            this.Description= Description;
            this.Price= Price;
        }
    }
}
