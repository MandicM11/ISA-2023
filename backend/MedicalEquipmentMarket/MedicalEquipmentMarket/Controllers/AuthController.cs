using MedicalEquipmentMarket.Security.Model;
using MedicalEquipmentMarket.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalEquipmentMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService) {
            _authService = authService;
        }
        [HttpGet]
        public async Task Login(LoginRequest request)
        {

        }
        [HttpPost]
        public async Task<Boolean> RegisterUser(LoginRequest request)
        {
            return await _authService.RegisterUser(request);
        }
    }
}
