
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous]
    public class AdminClassesListController : Controller
    {
        ClassesManager classesManager = new ClassesManager(new EfClassesDal());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewClasses()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewClasses(StudentClasses classes)
        {
            classesManager.TAdd(classes);
            return RedirectToAction("Index", "AdminClassesList");
        }
    }
}
