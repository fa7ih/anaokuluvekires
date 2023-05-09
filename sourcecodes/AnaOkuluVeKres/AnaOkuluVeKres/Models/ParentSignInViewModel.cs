using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Models
{
    public class ParentSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
        public string password { get; set; }
    }
}
