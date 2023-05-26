using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AnaOkuluVeKres.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contactManager.TAdd(contact);
                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return View("Index", contact);
        }
    }
}
