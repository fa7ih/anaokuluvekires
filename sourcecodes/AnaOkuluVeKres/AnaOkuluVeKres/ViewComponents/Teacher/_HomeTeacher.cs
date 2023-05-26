using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Teacher
{
    public class _HomeTeacher:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _HomeTeacher(UserManager<AppUser> userManager)
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
