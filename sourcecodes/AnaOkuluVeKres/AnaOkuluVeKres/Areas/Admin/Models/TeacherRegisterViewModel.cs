using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class TeacherRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi onaylayın")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
    }
}
