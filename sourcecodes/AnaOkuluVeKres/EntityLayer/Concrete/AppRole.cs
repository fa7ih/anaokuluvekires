﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppRole:IdentityRole<int>
    {
        public int AppRoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<AppRoleTeacher> AppRoleTeachers { get; set; }
    }
}

