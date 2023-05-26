using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Areas.Teachers.Models
{
    public class TeacherEditViewModel
    {
        [RegularExpression(@"^[^\u0080-\uFFFF]+$", ErrorMessage = "Türkçe olmayan karakterler kullanınız.")]
        [Display(Name = "Kullanıcı Adı")]
        public string userName { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public string teacherbranch { get; set; }
        public string teacherbiography { get; set; }
        public IFormFile image { get; set; }
    }
}
