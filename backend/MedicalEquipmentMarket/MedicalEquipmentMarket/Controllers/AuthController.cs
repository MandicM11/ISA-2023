using MedicalEquipmentMarket.Security.Model;
using MedicalEquipmentMarket.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using NuGet.Protocol.Plugins;

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
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if(await _authService.Login(request))
            {
                 return Ok(_authService.GetUserId(request.Username));
            }
            return BadRequest();
        }
        [HttpPost("register")]
        public async Task<Boolean> RegisterUser(RegisterRequest request)
        {
            return await _authService.RegisterUser(request);
        }

    }
}
