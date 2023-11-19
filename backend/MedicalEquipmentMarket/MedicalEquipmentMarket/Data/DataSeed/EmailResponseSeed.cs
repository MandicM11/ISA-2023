using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class EmailResponseSeed
    {
        public static void SeedEmailResponse(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailResponse>(f =>
            {
                f.HasData(new EmailResponse(1,1, 1, DateTime.UtcNow)
                    );
            });
        }
    }
}
