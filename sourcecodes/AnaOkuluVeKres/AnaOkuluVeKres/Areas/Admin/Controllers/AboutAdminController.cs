using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AboutAdminController : Controller
    {
        private readonly Context _context;
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        About2Manager about2Manager = new About2Manager(new EfAbout2Dal());

        public AboutAdminController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int id = 1;
            var value = _context.Abouts.FirstOrDefault(a => a.AboutId == id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            var value = _context.Abouts.FirstOrDefault(a => a.AboutId == 1);
            value.AboutTitle = about.AboutTitle;
            value.AboutDescription = about.AboutDescription;
            value.AboutSubDescription1 = about.AboutSubDescription1;
            value.AboutSubDescription2 = about.AboutSubDescription2;
            value.AboutSubDescription3 = about.AboutSubDescription3;
            aboutManager.TUpdate(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index2()
        {
            int id = 1;
            var value = _context.Abouts2.FirstOrDefault(a => a.About2Id == id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index2(About2 about)
        {
            var value = _context.Abouts2.FirstOrDefault(a => a.About2Id == 1);
            value.AboutTitle = about.AboutTitle;
            value.About2Description = about.About2Description;
            about2Manager.TUpdate(value);
            return RedirectToAction("Index2");
        }
    }
}
