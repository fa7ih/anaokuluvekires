using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _AdminListTeacher:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = context.Teachers.Where(t => t.TeacherStatus == true).ToList();
            return View(values);
        }
    }
}
