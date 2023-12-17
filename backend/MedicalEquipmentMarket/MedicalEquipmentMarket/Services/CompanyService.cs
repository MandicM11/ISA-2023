using System.Collections.Generic;
using System.Linq;
using MedicalEquipmentMarket.Model; 
using MedicalEquipmentMarket.Data;
using Microsoft.EntityFrameworkCore;

namespace MedicalEquipmentMarket.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly AppDbContext _context;

        public CompanyService(AppDbContext context)
        {
            _context = context;
        }


        public List<Company> GetCompaniesWithEquipment()
        {
            // Retrieve companies with associated equipment using Include and ThenInclude
            var companiesWithEquipment = _context.Company
                .Include(c => c.CompanyEquipments)
                .ThenInclude(ce => ce.Equipment)
                .ToList();

            return companiesWithEquipment;
        }
    }
}
