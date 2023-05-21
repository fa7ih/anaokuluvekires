using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AnaOkuluVeKres.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [Display(Name = "Kullanıcı Adı")]
        public string TeacherUserName { get; set; }

        [Required(ErrorMessage = "TC kimlik numarası zorunludur.")]
        [Display(Name = "TC Kimlik Numarası")]
        public long TeacherTC { get; set; }
    }

}
