using MedicalEquipmentMarket.Model;

namespace MedicalEquipmentMarket.Services
{
    public interface ICompanyService
    {
        public List<Company> GetCompaniesWithEquipment();
    }
}