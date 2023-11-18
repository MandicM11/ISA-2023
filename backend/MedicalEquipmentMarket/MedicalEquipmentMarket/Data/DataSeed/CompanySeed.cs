using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class CompanySeed
    {
        public static void SeedCompany(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(f =>
            {
                f.HasData(new Company(1,"Beomed","Beogradska 26","Beograd","021731524"),
                          new Company(2, "Health&Care", "Bulevar Mihajla Pupina 25", "Novi Sad", "021731522"),
                          new Company(3, "Galenika", "Futoski put 12", "Novi Sad", "021731511")
                    );
            });
        }
    }
}
