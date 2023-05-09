using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Models
{
    public class ParentRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresini giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi onaylayın")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }

        //public Student Student { get; set; }
    }
}
