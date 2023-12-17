using MedicalEquipmentMarket.Data;
using MedicalEquipmentMarket.Model;
using Microsoft.AspNetCore.Mvc;
using MedicalEquipmentMarket.Services;

namespace MedicalEquipmentMarket.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservatons()
        {
            var reservations = await _reservationService.GetReservationsAsync();

            return Ok(reservations);
        }
    }
}