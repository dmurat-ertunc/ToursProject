using System.ComponentModel.DataAnnotations;

namespace ToursProject.Models.Contact
{
    public class AddContactViewModel
    {

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string surname { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string subject { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string message { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string email { get; set; }

        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string phoneNumber { get; set; }
    }
}
