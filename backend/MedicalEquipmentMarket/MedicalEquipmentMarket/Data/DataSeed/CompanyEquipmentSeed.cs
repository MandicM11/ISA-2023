using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class CompanyEquipmentSeed
    {
        public static void SeedCompanyEquipment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEquipment>(f =>
            {
                f.HasData(new CompanyEquipment(1,2),
                          new CompanyEquipment(1,3),
                          new CompanyEquipment(1,1),
                          new CompanyEquipment(2,1),
                          new CompanyEquipment(3,3)
                    );
            });
        }
    }
}
