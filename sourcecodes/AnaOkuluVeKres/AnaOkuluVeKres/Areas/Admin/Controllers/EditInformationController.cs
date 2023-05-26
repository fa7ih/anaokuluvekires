using AnaOkuluVeKres.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class EditInformationController : Controller
    {
        private readonly Context _context;
        InformationManager ınformationManager = new InformationManager(new EfInformationDal());

        public EditInformationController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int id = 1;
            var information = _context.Informations.FirstOrDefault(i => i.InformationId == id);
            return View(information);
        }
        [HttpPost]
        public ActionResult Index(Information model)
        {
            var value = _context.Informations.FirstOrDefault(i => i.InformationId == 1);
            value.InformationPhone = model.InformationPhone;
            value.InformationMail = model.InformationMail;
            value.InformationAdress = model.InformationAdress;
            ınformationManager.TUpdate(value);
            return RedirectToAction("Index");   
        }
    }
}
