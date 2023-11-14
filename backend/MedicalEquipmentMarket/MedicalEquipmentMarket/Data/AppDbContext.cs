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
    }
}
