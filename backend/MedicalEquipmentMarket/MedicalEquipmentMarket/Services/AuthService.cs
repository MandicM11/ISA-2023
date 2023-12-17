using MedicalEquipmentMarket.Data;
using MedicalEquipmentMarket.Security;
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
        private readonly SecurityDbContext _context;

        public AuthService(IConfiguration configuration, UserManager<IdentityUser> userManager,SecurityDbContext context)
        {
            _userManager = userManager;
            _configuration = configuration;
            _context = context;
        }
        public async Task<bool> RegisterUser(RegisterRequest request)
        {
            var identityUser = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Email,
                
            };
            _context.BaseUser.Add(new BaseUser()
            {
                UserName = request.Username,
                Name = request.Name,
                LastNmae = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Occupation = request.Occupation,
                CompanyInfo = request.CompanyInfo,
                AddressId = 1
            });
            var result=await _userManager.CreateAsync(identityUser, request.Password);
            return result.Succeeded;
        }
        public async Task<bool> Login(LoginRequest request)
        {
            var identityUser = await _userManager.FindByNameAsync(request.Username);
            if(identityUser is null)
            {
                return false;
            }
            return await _userManager.CheckPasswordAsync(identityUser, request.Password);
        }
        public int GetUserId(string username)
        {
            var user=_context.BaseUser.Where(p => p.UserName.Equals(username)).FirstOrDefault();
            return user.Id;
        }
    }
}

    

