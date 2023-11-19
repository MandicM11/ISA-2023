namespace MedicalEquipmentMarket.Model
{
    public class SalesReport
    {
        public int IdSales { get; set; }
        public int CompanId { get; set; }
        public int EquipId { get; set; }
        public DateTime ReportDate { get; set; }
        public string Status { get; set; }


        public SalesReport()
        {

        }
        public SalesReport(int id, int companyId, DateTime reservationTime)
        {
            IdSales = id;
            CompanId = companyId;
            ReportDate = reservationTime;
            

        }
    }
}
