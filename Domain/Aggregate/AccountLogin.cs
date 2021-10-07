using System.ComponentModel.DataAnnotations;

namespace Domain.Aggregate
{
    public class AccountLogin
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}