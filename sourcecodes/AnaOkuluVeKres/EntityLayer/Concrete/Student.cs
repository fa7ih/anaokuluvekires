using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer.Concrete
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        public int StudentNo { get; set; }
        public long StudentTc { get; set; }
        public DateTime StudentBirth { get; set; }
        public string StudentImageUrl { get; set; }
        public string StudentClass { get; set; }
        public string StudentBranch { get; set; }
        public string StudentGender { get; set; }
        public bool StudentStatus { get; set; }
        public string Status { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey(nameof(Classes))]
        public int ClassId { get; set; }
        public Classes Class { get; set; }
    }
}
