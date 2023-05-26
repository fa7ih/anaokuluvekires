using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact3
    {
        [Key]
        public int Contact3Id { get; set; }
        public string Contact2ReplyReciver { get; set; }
        public string Contact2ReplySender { get; set; }
        public string Contact2ReplyTitle { get; set; }
        public string Contact2ReplyBody { get; set; }
        public string Contact2ReplyMail { get; set; }
        public string Contact2ReplyPhone { get; set; }
        public DateTime Contact2ReplyCreateDate { get; set; }
    }
}
