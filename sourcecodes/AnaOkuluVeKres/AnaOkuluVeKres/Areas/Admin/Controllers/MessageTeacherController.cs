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

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class MessageTeacherController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        Contact3Manager contact3Manager = new Contact3Manager(new EfContact3Dal());
        Contact4Manager contact4Manager = new Contact4Manager(new EfContact4Dal());

        public MessageTeacherController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AppUser parent = await _userManager.GetUserAsync(HttpContext.User);
            string username = parent.UserName;
            List<Contact3> messages = _context.Contacts3.Where(m => m.Contact2ReplyReciver == username).ToList();
            return View(messages);
        }


        public IActionResult MessageDetails(int messageId)
        {
            var contact = contact3Manager.TGetById(messageId);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpGet]
        public async Task<IActionResult> ReplyMessage()
        {
            var parents = await _userManager.GetUsersInRoleAsync("Öğretmen");
            var parentList = parents.Select(t => new SelectListItem
            {
                Value = t.UserName,
                Text = $"{t.Name} {t.Surname}"
            }).ToList();
            ViewData["Parents"] = parentList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReplyMessage(Contact4 model)
        {
            AppUser sender = await _userManager.GetUserAsync(HttpContext.User);
            model.AdminReplySender = $"{sender.Name} {sender.Surname}";
            AppUser receiver = await _userManager.FindByNameAsync(model.AdminReplyReciver);
            model.AdminReplyReciver = receiver.UserName;
            model.AdminReplyCreateDate = DateTime.Now;
            contact4Manager.TAdd(model);
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";
            return RedirectToAction("ReplyMessage");
        }

        public IActionResult DeleteMessage(int id)
        {
            var cont = contact3Manager.TGetById(id);
            contact3Manager.TDelete(cont);
            return RedirectToAction("Index");
        }
    }
}
