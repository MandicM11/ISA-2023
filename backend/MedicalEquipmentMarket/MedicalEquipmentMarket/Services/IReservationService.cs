using MedicalEquipmentMarket.Model;
namespace MedicalEquipmentMarket.Services
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsAsync();
    }
}