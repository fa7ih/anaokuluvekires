using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2Id { get; set; }
        public string AboutTitle { get; set; }
        public string About2Description { get; set; }
        public string About2ImgURL { get; set; }
    }
}
