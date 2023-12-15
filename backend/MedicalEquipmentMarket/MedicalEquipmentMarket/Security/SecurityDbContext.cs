using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Security
{
    public class SecurityDbContext:IdentityDbContext
    {
        public SecurityDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<BaseUser> BaseUser { get; set; }
    }
}
