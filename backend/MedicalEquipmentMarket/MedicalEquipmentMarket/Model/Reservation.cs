using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace MedicalEquipmentMarket.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BuyerAccountId { get; set; }
        
        public DateTime ReservationTime { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Reservation()
        {

        }
        public Reservation(int id, int idC, int buyerAccountId, DateTime reservationTime)
        {
            ReservationId = id;
            BuyerAccountId = buyerAccountId;
            CompanyId = idC;
            ReservationTime = reservationTime;
        }
    }
}
