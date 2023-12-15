using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity;

namespace MedicalEquipmentMarket.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<bool> RegisterUser(LoginRequest request)
        {
            var identityUser = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Username
            };
            var result=await _userManager.CreateAsync(identityUser, request.Password);
            return result.Succeeded;
        }
    }
}

    

