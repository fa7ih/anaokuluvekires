using EntityLayer.Concrete;
using System.Collections.Generic;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class AssignRoleListViewModel
    {
        public List<AppUser> Users { get; set; }
        public Dictionary<string, List<string>> AssignedRolesByUser { get; set; }
    }
}

