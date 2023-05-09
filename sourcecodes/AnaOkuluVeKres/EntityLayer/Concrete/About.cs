using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutSubDescription1 { get; set; }
        public string AboutSubDescription2 { get; set; }
        public string AboutSubDescription3 { get; set; }
        public bool AboutStatus { get; set; }
    }
}
