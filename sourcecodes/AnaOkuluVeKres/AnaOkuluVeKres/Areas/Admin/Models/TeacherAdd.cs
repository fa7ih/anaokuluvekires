using Microsoft.AspNetCore.Http;
using System;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class TeacherAdd
    {
        public string teacherNameSurname { get; set; }
        public string teacherUserName { get; set; }
        public long teacherTC { get; set; }
        public DateTime teacherBirth { get; set; }
        public string teacherBranch { get; set; }
        public IFormFile teacherImgUrl { get; set; }
        public bool teacherStatus { get; set; }
        public string teacherBiography { get; set; }
        public string teacherGender { get; set; }
    }
}
