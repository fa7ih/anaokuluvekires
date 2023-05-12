using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.ViewComponents.ParentDashboard
{
    public class _TeacherList:ViewComponent
    {
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        public IViewComponentResult Invoke()
        {
            var values = teacherManager.GetList();
            return View(values);
        }

    }
}
