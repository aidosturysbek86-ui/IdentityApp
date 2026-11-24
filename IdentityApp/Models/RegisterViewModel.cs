using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Атыңызды енгізіңіз")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Тегіңізді енгізіңіз")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email енгізіңіз")]
        [EmailAddress(ErrorMessage = "Дұрыс email енгізіңіз")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Құпия сөзді енгізіңіз")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Құпия сөз кемінде 8 таңбадан тұруы керек")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Құпия сөздер сәйкес келмейді")]
        public string ConfirmPassword { get; set; }
    }
}