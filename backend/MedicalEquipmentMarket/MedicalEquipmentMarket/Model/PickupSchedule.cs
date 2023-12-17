namespace MedicalEquipmentMarket.Model
{
    public class PickupSchedule
    {
        public int IdS { get; set; }
       
        public DateTime ScheduleTime { get; set; }
        public string Status { get; set; }
        

        public PickupSchedule()
        {

        }
        public PickupSchedule(int id, DateTime reservationTime, string status)
        {
            IdS = id;
            ScheduleTime = reservationTime;
            Status = status;
            
        }
    }
}
