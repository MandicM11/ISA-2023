using MedicalEquipmentMarket.Data;
using MedicalEquipmentMarket.Model;
using MedicalEquipmentMarket.Services;
using Microsoft.EntityFrameworkCore; 


public class ReseravionService : IReservationService
{
    private readonly AppDbContext _context;

    public ReseravionService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Reservation>> GetReservationsAsync()
    {
        return await _context.Reservations.ToListAsync();
    }
}
