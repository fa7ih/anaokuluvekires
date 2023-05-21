using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StudentStatus
    {
        [Key]
        public int StudentStatusId { get; set; }
        public int StudentStatusHealth { get; set; }
        public int StudentStatusDevelopment { get; set; }
        public int StudentStatusAdaptation { get; set; }
        public int StudentStatusMusic { get; set; }
        public int StudentStatusDance { get; set; }
        public int StudentStatusSport { get; set; }
        public string StudentStatusInClassSituation { get; set; }
        public int StudentStatusAlphabet { get; set; }
        public int StudentStatusMaths { get; set; }
        public string StudentStatusTeachNotes { get; set; }

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}


