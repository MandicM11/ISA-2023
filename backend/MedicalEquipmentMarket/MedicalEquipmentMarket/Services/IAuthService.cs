using MedicalEquipmentMarket.Security.Model;
using Microsoft.AspNetCore.Identity;

namespace MedicalEquipmentMarket.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(RegisterRequest request);
        Task<bool> Login(LoginRequest request);
        public int GetUserId(string username);
    }
}