using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Teachers.Count(x => x.TeacherStatus == true);
            ViewBag.v2 = context.Teachers.Count(x => x.TeacherStatus == false);
            return View();
        }
    }
}
