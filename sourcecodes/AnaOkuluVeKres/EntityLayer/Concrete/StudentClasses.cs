using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StudentClasses
    {
        public int ClassesId { get; set; }
        public string ClassesName { get; set; }
        public List<Student> Students { get; set; }
    }
}
