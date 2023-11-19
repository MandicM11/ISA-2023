namespace MedicalEquipmentMarket.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int BuyerAccountId { get; set; }
        public int CompId { get; set; }
        public int EquipmId { get; set; }
        public DateTime ReservationTime { get; set; }

        public Reservation()
        {

        }
        public Reservation(int id, int buyerAccountId, int companyId, int equipmentId, DateTime reservationTime)
        {
            ReservationId = id;
            BuyerAccountId = buyerAccountId;
            CompId = companyId;
            EquipmId = equipmentId;
            ReservationTime = reservationTime;
        }
    }
}
