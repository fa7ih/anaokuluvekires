using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        [Key]
        public int AppUserId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool TeacherStatus { get; set; }
        public string TeacherBiography { get; set; }
        public string TeacherBranch { get; set; }
    }
}
