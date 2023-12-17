using MedicalEquipmentMarket.Data;
using MedicalEquipmentMarket.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MedicalEquipmentMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompaniesWithEquipment()
        {
            var companiesWithReservationsAndEquipment = await _context.Company
         .Include(c => c.Reservations) // Include reservations for each Company
         .Select(c => new
         {
             Company = c,
             Reservations = c.Reservations.ToList(), // Fetch Reservations
             Equipments = c.CompanyEquipments.Select(ce => ce.Equipment).ToList() // Fetch Equipments
         })
         .ToListAsync();

            return Ok(companiesWithReservationsAndEquipment);
        }
       
      
    }
}
