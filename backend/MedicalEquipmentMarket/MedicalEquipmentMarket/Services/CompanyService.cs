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
            var companiesWithEquipmentAndReservations = _context.Company
        .Include(c => c.CompanyEquipments)
            .ThenInclude(ce => ce.Equipment) // Include associated equipment
        .Include(c => c.Reservations) // Include associated reservations
        .ToList();

            return companiesWithEquipmentAndReservations;
        }

        public List<Company> GetcompaniesWithReservations()
        {
            // Retrieve companies with associated equipment using Include and ThenInclude
            var companiesWithRes = _context.Company
                .Include(c => c.Reservations)
                .ToList();

            return companiesWithRes;
        }
    }
}
