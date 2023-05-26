using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _AdminListTeacher:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminListTeacher(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result
                .Where(u => u.TeacherStatus == true)
                .ToList();
            return View(teachers);
        }
    }
}
