using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MedicalEquipmentMarket.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        public async Task<bool> RegisterUser(LoginRequest request)
        {
            var identityUser = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Username,
                
            };
            var result=await _userManager.CreateAsync(identityUser, request.Password);
            return result.Succeeded;
        }
        public async Task<bool> Login(LoginRequest request)
        {
            var identityUser = await _userManager.FindByEmailAsync(request.Username);
            if(identityUser is null)
            {
                return false;
            }
            return await _userManager.CheckPasswordAsync(identityUser, request.Password);
        }

    }
}

    

