using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ClassesController : Controller
    {
        ClassesManager classesManager = new ClassesManager(new EfClassesDal());
        Context context = new Context();
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
        public IActionResult NewClasses(Classes classes)
        {
            classesManager.TAdd(classes);
            return RedirectToAction("NewClasses");
        }
        [HttpGet]
        public IActionResult ClassesList(int id)
        {
            var values = classesManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ClassesList(Classes classes)
        {
            return View();
        }
    }
}
