using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class ReservationSeed
    {
        public static void SeedReservation(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(f =>
            {
                f.HasData(new Reservation(1,1,2,2,DateTime.UtcNow)
                    );
            });
        }
    }
}
