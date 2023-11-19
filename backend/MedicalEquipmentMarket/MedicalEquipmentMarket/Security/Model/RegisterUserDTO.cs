using MedicalEquipmentMarket.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Xml.Linq;

namespace MedicalEquipmentMarket.Security.Model
{
    public class RegisterUserDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [RegularExpression(@"^(\d{13})$", ErrorMessage = "The pin must be 13 digits long.")]
        [Required]
        public Gender Gender { get; set; }
    }
}
