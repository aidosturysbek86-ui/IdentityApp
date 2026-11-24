using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email енгізіңіз")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Құпия сөзді енгізіңіз")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Мені есте сақта")]
        public bool RememberMe { get; set; }
    }
}