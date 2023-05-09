using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string ParentNameSurname{ get; set; }
        public string ParentUserName { get; set; }
        public string ParentPassword { get; set; }
        public bool ParentStatus { get; set; }
    }
}
