using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact4
    {
        [Key]
        public int AdminContactId { get; set; }
        public string AdminReplyReciver { get; set; }
        public string AdminReplySender { get; set; }
        public string AdminReplyTitle { get; set; }
        public string AdminReplyBody { get; set; }
        public string AdminReplyMail { get; set; }
        public string AdminReplyPhone { get; set; }
        public DateTime AdminReplyCreateDate { get; set; }
    }
}
