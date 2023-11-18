using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class EquipmentSeed
    {
        public static void SeedEquipment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>(f =>
            {
            f.HasData(new Equipment(1, "Stetoskop", "Aparat za osluskivanja rada pluca i srca", 20000),
                      new Equipment(2, "Krevet", "Namestaj za pacijente", 14000),
                      new Equipment(3, "Pakovanje zavoja", "Oprema za previjanje", 1200)
                );
            });
        }
    }
}
