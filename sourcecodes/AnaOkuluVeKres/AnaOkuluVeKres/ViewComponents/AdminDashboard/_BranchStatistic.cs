using AnaOkuluVeKres.ViewComponents.AdminDashboard;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _BranchStatistic : ViewComponent
    {
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;

        public _BranchStatistic(Context context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result;
            ViewBag.v1 =teachers.Select(x => x.TeacherBranch).Distinct().Count();
            ViewBag.v2 =teachers.Count(x => x.TeacherBranch == "Okuma Yazma" && x.TeacherStatus == true);
            ViewBag.v3 =teachers.Count(x => x.TeacherBranch == "Matematik" && x.TeacherStatus == true);
            ViewBag.v4 =teachers.Count(x => x.TeacherBranch == "Müzik" && x.TeacherStatus == true);
            ViewBag.v5 =teachers.Count(x => x.TeacherBranch == "Spor" && x.TeacherStatus == true);
            ViewBag.v6 =teachers.Count(x => x.TeacherBranch == "Yazılım" && x.TeacherStatus == true);
            ViewBag.v7 =teachers.Count(x => x.TeacherBranch == "Dans" && x.TeacherStatus == true);
            ViewBag.v8 =teachers.Count(x => x.TeacherBranch == "Rehberlik" && x.TeacherStatus == true);
            return View();
        }
    }
}


