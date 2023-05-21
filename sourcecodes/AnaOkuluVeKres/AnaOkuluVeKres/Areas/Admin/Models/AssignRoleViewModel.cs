using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class AssignRoleViewModel
    {
        public int TeacherId { get; set; }
        public string TeacherNameSurname { get; set; }
        public int SelectedRoleId { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}

