using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Teacher:ViewComponent
    {
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        public IViewComponentResult Invoke()
        {
            var values = teacherManager.GetList();
            return View(values);
        }
    }
}
