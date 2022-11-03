using System.ComponentModel.DataAnnotations;

namespace SAT.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "*First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is required")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

    }
}
