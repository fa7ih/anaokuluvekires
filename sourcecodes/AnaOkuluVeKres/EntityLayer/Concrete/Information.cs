using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Information
    {
        public int InformationId { get; set; }
        public string InformationAdress { get; set; }
        public string InformationPhone { get; set; }
        public string InformationMail { get; set; }
        public bool InformationStatus { get; set; }
    }
}
