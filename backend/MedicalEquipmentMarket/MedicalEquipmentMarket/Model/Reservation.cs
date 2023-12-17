namespace MedicalEquipmentMarket.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BuyerAccountId { get; set; }
        
        public DateTime ReservationTime { get; set; }

        public Reservation()
        {

        }
        public Reservation(int id, int buyerAccountId, DateTime reservationTime)
        {
            ReservationId = id;
            BuyerAccountId = buyerAccountId;
            
            ReservationTime = reservationTime;
        }
    }
}
