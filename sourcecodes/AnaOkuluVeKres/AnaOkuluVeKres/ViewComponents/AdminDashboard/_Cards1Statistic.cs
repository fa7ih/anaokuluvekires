using AnaOkuluVeKres.ViewComponents.Default;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _Cards1Statistic(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result;
            ViewBag.v1 = teachers.Where(u => u.TeacherStatus == true).Count();
            ViewBag.v2 = teachers.Where(u => u.TeacherStatus == false).Count();
            return View();
        }
    }
}
