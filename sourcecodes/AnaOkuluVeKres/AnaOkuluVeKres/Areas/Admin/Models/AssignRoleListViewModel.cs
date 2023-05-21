using EntityLayer.Concrete;
using System.Collections.Generic;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class AssignRoleListViewModel
    {
        public List<Teacher> Teachers { get; set; }
        public Dictionary<int, List<string>> AssignedRolesByTeacher { get; set; }
    }
}
