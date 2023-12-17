using MedicalEquipmentMarket.Model;
using System.ComponentModel.Design;
using System.Net;
using System.Xml.Linq;

public class CompanyEquipment
{
    public int CompanyId { get; set; }
    public Company Company { get; set; }

    public int EquipmentId { get; set; }
    public Equipment Equipment { get; set; }



    public CompanyEquipment()
    {

    }
    public CompanyEquipment(int idC, int idE)
    {
        CompanyId = idC;
        EquipmentId = idE;
    }

}