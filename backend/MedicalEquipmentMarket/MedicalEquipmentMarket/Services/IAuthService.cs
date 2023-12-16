using MedicalEquipmentMarket.Security.Model;

namespace MedicalEquipmentMarket.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginRequest request);
        Task<bool> Login(LoginRequest request);
    }
}