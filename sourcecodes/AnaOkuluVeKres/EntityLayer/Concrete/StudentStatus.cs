using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int StudentStatusInClassSituation { get; set; }
        public int StudentStatusAlphabet { get; set; }
        public int StudentStatusMaths { get; set; }
        public int StudentStatusTeachNotes { get; set; }
    }
}
