namespace MedicalEquipmentMarket.Model
{
    public class PickupSchedule
    {
        public int IdS { get; set; }
        public int CompanId { get; set; }
        public int EquipId { get; set; }
        public DateTime ScheduleTime { get; set; }
        public string Status { get; set; }
        

        public PickupSchedule()
        {

        }
        public PickupSchedule(int id, int companyId, int equipmentId, DateTime reservationTime, string status)
        {
            IdS = id;
            EquipId = equipmentId;
            CompanId = companyId;
            ScheduleTime = reservationTime;
            Status = status;
            
        }
    }
}
