using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact2
    {
        [Key]
        public int Contact2Id { get; set; }
        public string Contact2Reciver { get; set; }
        public string Contact2Sender { get; set; }
        public string Contact2Title { get; set; }
        public string Contact2Body { get; set; }
        public string Contact2Mail { get; set; }
        public string Contact2Phone { get; set; }
    }
}
