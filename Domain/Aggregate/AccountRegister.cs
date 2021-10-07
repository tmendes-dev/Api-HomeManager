using System.ComponentModel.DataAnnotations;

namespace Domain.Aggregate
{
    public class AccountRegister
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}