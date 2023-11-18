namespace MedicalEquipmentMarket.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BuyerAccountId { get; set; }
        public int CompanyId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime ReservationTime { get; set; }

        public Reservation()
        {

        }
        public Reservation(int id, int buyerAccountId, int companyId, int equipmentId, DateTime reservationTime)
        {
            Id = id;
            BuyerAccountId = buyerAccountId;
            CompanyId = companyId;
            EquipmentId = equipmentId;
            ReservationTime = reservationTime;
        }
    }
}
