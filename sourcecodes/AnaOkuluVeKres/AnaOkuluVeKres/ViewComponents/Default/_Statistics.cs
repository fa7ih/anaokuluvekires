using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Students.Count();
            ViewBag.v2 = context.Teachers.Count();
            ViewBag.v3 = context.Teachers.Select(x => x.TeacherBranch).Distinct().Count();
            return View();
        }
    }
}
