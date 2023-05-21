using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Teacher : IdentityUser
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherNameSurname { get; set; }
        public string TeacherUserName { get; set; }
        public long TeacherTC { get; set; }
        public DateTime TeacherBirth { get; set; }
        public string TeacherBranch { get; set; }
        public string TeacherImgUrl { get; set; }
        public bool TeacherStatus { get; set; }
        public string TeacherBiography { get; set; }
        public string TeacherGender { get; set; }


        public virtual ICollection<StudentStatus> StudentStatuses { get; set; }
        [InverseProperty(nameof(AppRoleTeacher.Teacher))]
        public ICollection<AppRoleTeacher> AppRoleTeachers { get; set; }
    }
   
    
}


