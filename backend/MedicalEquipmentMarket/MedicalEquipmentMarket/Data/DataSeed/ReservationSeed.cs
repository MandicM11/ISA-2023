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
                f.HasData(new Reservation(1,1,2,DateTime.UtcNow),
                          new Reservation(2, 1, 1, DateTime.UtcNow),
                          new Reservation(3, 2, 3, DateTime.UtcNow)
                    );
            });
        }
    }
}
