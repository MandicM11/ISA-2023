using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class PickupScheduleSeed
    {
        public static void SeedPickupSchedule(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PickupSchedule>(f =>
            {
                f.HasData(new PickupSchedule(1, DateTime.UtcNow, "zakazan")
                    );
            });
        }
    }
}
