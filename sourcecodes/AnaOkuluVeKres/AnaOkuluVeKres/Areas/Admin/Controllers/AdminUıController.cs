using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using X.PagedList;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AdminUıController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index(int page = 1)
        {
            var values = contactManager.GetList();
            return View(values.ToPagedList(page, 8));
        }
        public IActionResult Details(int id)
        {
            var contact = contactManager.TGetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
        public IActionResult DeleteMessage(int id)
        {
            var cont = contactManager.TGetById(id);
            contactManager.TDelete(cont);   
            return RedirectToAction("Index", "AdminUı");
        }
    }
}
