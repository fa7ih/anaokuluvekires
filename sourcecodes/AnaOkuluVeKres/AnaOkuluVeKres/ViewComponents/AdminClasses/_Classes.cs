using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.ViewComponents.AdminClasses
{
    public class _Classes:ViewComponent
    {
        ClassesManager classesManager = new ClassesManager(new EfClassesDal());
        public IViewComponentResult Invoke()
        {
            var values = classesManager.GetList();
            return View(values);
        }
    }
}
