using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity;

namespace MedicalEquipmentMarket.Security
{
    public class AppIdentityDbContextSeed
    {
        public static void SeedIdentity(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole<int>>>();

            var user1 = new User()
            {
                UserName = "darkofilipovic",
                Email = "darko10@email.com"
            };
             userManager.CreateAsync(user1, "12345");
             userManager.SetLockoutEnabledAsync(user1, false);

            var user2 = new User()
            {
                UserName = "mirkomandic",
                Email = "mirko22@email.com"
            };
             userManager.CreateAsync(user2, "12345");
             userManager.SetLockoutEnabledAsync(user2, false);
        }

    }
}
