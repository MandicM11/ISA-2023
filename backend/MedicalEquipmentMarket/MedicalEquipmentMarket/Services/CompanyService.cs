using System.Collections.Generic;
using System.Linq;
using MedicalEquipmentMarket.Model; 
using MedicalEquipmentMarket.Data; 

namespace MedicalEquipmentMarket.Services
{
    public class CompanyService
    {
        private readonly AppDbContext _context;

        public CompanyService(AppDbContext context)
        {
            _context = context;
        }

        public List<Company> GetAllCompanies()
        {
            return _context.Company.ToList(); 
        }
    }
}
