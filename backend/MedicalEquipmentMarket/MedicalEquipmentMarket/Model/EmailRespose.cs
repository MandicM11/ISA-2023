using Microsoft.AspNetCore.SignalR;

namespace MedicalEquipmentMarket.Model
{
    public class EmailResponse
    {
        public int ReservId { get; set; }
        public int UserId { get; set; }
        public int EmailId { get; set; }
        public DateTime ReservedDate { get; set; }
        public string PhoneNumber { get; set; }

        public EmailResponse()
        {

        }
        public EmailResponse(int id, int email, int userid, DateTime reservedDate)
        {
            ReservId = id;
            EmailId = email;
            UserId = userid;
            ReservedDate = reservedDate;    

        }
    }
}
