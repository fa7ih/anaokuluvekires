using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        Context context = new Context();

        public _Statistics(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result;
            ViewBag.v1 = context.Students2.Count(s => s.Status == "Onaylandı");
            ViewBag.v2 = teachers.Count(x=>x.TeacherStatus == true);
            ViewBag.v3 = teachers.Select(x => x.TeacherBranch).Distinct().Count();
            return View();
        }
    }
}
