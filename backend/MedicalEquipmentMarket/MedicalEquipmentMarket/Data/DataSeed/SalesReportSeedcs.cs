using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Data.DataSeed
{
    public static class SalesReportSeed
    {
        public static void SeedSalesReport(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesReport>(f =>
            {
                f.HasData(new SalesReport(1, 1, DateTime.UtcNow)
                    );
            });
        }
    }
}
