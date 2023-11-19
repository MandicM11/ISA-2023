using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MedicalEquipmentMarket.Security
{
    public class AppIdentityDbContext : IdentityDbContext<User, IdentityRole<int>, int>
        {
             protected readonly IConfiguration Configuration;

            public AppIdentityDbContext(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
            }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                
                base.OnModelCreating(builder);
            }

        }
}
