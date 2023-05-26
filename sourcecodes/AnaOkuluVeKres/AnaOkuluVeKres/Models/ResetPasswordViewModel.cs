using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi onaylayın")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
    }
}
