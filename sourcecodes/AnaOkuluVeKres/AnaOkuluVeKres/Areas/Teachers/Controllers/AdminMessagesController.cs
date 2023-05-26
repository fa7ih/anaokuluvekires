using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    [Authorize(Roles = "Öğretmen,Admin")]
    [Route("Teachers/[controller]/[action]")]
    public class AdminMessagesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        Contact3Manager contact3Manager = new Contact3Manager(new EfContact3Dal());
        Contact4Manager contact4Manager = new Contact4Manager(new EfContact4Dal());

        public AdminMessagesController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AppUser teacher = await _userManager.GetUserAsync(HttpContext.User);
            string username = teacher.UserName;
            List<Contact4> messages = _context.Contacts4.Where(m => m.AdminReplyReciver == username).ToList();
            return View(messages);
        }

        public IActionResult MessageDetails(int messageId)
        {
            var contact = contact4Manager.TGetById(messageId);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpGet]
        public async Task<IActionResult> ReplyMessage()
        {
            var parents = await _userManager.GetUsersInRoleAsync("Admin");
            var parentList = parents.Select(t => new SelectListItem
            {
                Value = t.UserName,
                Text = $"{t.Name} {t.Surname}"
            }).ToList();
            ViewData["Parents"] = parentList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReplyMessage(Contact3 model)
        {
            AppUser sender = await _userManager.GetUserAsync(HttpContext.User);
            model.Contact2ReplySender = $"{sender.Name} {sender.Surname}";
            AppUser receiver = await _userManager.FindByNameAsync(model.Contact2ReplyReciver);
            model.Contact2ReplyReciver = receiver.UserName;
            model.Contact2ReplyCreateDate = DateTime.Now;
            contact3Manager.TAdd(model);
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";
            return RedirectToAction("ReplyMessage");
        }

        public IActionResult DeleteMessage(int id)
        {
            var cont = contact4Manager.TGetById(id);
            contact4Manager.TDelete(cont);
            return RedirectToAction("Index");
        }
    }
}
