using Microsoft.AspNetCore.Mvc;
using MedicalEquipmentMarket.Services;

namespace MedicalEquipmentMarket.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _companyService;

        public CompanyController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetAllCompanies()
        {
            var companies = _companyService.GetAllCompanies();
            return Ok(companies); 
        }
    }
}
