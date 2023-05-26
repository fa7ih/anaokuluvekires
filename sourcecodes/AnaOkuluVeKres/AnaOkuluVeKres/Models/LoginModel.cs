using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
    }
}
