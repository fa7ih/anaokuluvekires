using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherNameSurname { get; set; }
        public string TeacherUserName { get; set; }
        public string TeacherPassword { get; set; }
        public string TeacherBranch { get; set; }
        public string TeacherImgUrl { get; set; }
        public bool TeacherStatus { get; set; }
        public string TeacherBiography { get; set; }
    }
}
 