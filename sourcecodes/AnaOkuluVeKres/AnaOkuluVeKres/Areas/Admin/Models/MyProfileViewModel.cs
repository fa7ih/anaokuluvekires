using Microsoft.AspNetCore.Http;
using System;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class MyProfileViewModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string ImageURL { get; set; }
        public DateTime RegistrationDate { get; set; }
        public IFormFile Image { get; set; }
    }
}
