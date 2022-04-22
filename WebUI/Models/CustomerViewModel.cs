using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class CustomerViewModel
    {
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; } 

        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
