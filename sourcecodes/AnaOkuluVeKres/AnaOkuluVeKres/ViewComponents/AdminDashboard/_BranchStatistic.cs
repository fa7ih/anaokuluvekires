using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _BranchStatistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Teachers.Select(x => x.TeacherBranch).Distinct().Count();
            ViewBag.v2 = context.Teachers.Count(x => x.TeacherBranch == "Okuma Yazma" && x.TeacherStatus == true);
            ViewBag.v3 = context.Teachers.Count(x => x.TeacherBranch == "Matematik" && x.TeacherStatus == true);
            ViewBag.v4 = context.Teachers.Count(x => x.TeacherBranch == "Müzik" && x.TeacherStatus == true);
            ViewBag.v5 = context.Teachers.Count(x => x.TeacherBranch == "Spor" && x.TeacherStatus == true);
            ViewBag.v6 = context.Teachers.Count(x => x.TeacherBranch == "Yazılım" && x.TeacherStatus == true);
            ViewBag.v7 = context.Teachers.Count(x => x.TeacherBranch == "Dans" && x.TeacherStatus == true);
            return View();
        }
    }
}
