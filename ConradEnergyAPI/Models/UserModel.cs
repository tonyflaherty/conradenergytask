using System.ComponentModel.DataAnnotations;

namespace ConradEnergyAPI.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
