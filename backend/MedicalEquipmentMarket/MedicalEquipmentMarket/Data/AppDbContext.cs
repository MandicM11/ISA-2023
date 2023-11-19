using MedicalEquipmentMarket.Data.DataSeed;
using MedicalEquipmentMarket.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace MedicalEquipmentMarket.Data
{
    public class AppDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;
        
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PickupSchedule>().HasKey(p => p.IdS);
            modelBuilder.Entity<SalesReport>().HasKey(s => s.IdSales);
            modelBuilder.SeedEquipment();
            modelBuilder.SeedCompany();
            modelBuilder.SeedSalesReport();
            modelBuilder.SeedReservation();
            modelBuilder.SeedPickupSchedule();
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Company> Company{ get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<PickupSchedule> PickupSchedule { get; set; }
    }
}
