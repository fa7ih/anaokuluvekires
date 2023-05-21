using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppRoleTeacher
    {
        [Key]
        [ForeignKey(nameof(AppRole))]
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }

        [Key]
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}