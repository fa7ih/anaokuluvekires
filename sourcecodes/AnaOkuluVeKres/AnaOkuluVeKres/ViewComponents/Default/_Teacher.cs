using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Teacher:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var values = context.Teachers.Where(t => t.TeacherStatus == true).ToList();
            return View(values);
        }
    }
}
