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
            modelBuilder.Entity<CompanyEquipment>()
       .HasKey(ce => new { ce.CompanyId, ce.EquipmentId });

            modelBuilder.Entity<CompanyEquipment>()
                .HasOne(ce => ce.Company)
                .WithMany(c => c.CompanyEquipments)
                .HasForeignKey(ce => ce.CompanyId);

            modelBuilder.Entity<CompanyEquipment>()
                .HasOne(ce => ce.Equipment)
                .WithMany(e => e.CompanyEquipments)
                .HasForeignKey(ce => ce.EquipmentId);
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Company)
                .HasForeignKey(r => r.CompanyId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PickupSchedule>().HasKey(p => p.IdS);
            modelBuilder.Entity<SalesReport>().HasKey(s => s.IdSales);
            modelBuilder.SeedEquipment();
            modelBuilder.SeedSalesReport();
            modelBuilder.SeedReservation();
            modelBuilder.SeedPickupSchedule();
            modelBuilder.SeedCompanyEquipment();
            modelBuilder.SeedCompany();



        }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Company> Company{ get; set; }

        public DbSet<CompanyEquipment> CompanyEquipments { get; set; }

        public DbSet<Reservation> Reservations{ get; set; }
        public DbSet<PickupSchedule> PickupSchedule { get; set; }
    }
}
