using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [Authorize(Roles = "Veli,Admin")]
    [Route("Parents/[controller]/[action]")]
    public class ContactTeacherController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        Contact2Manager contact2Manager = new Contact2Manager(new EfContact2Dal());
        Contact3Manager contact3Manager = new Contact3Manager(new EfContact3Dal());
        
        public ContactTeacherController(UserManager<AppUser> userManager, Context context)
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

        public async Task<IActionResult> SendMessage()
        {
            var teachers = await _userManager.GetUsersInRoleAsync("Öğretmen");
            var teacherList = teachers.Select(t => new SelectListItem
            {
                Value = t.UserName,
                Text = $"{t.Name} {t.Surname}"
            }).ToList();
            ViewData["Teachers"] = teacherList;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Contact2 model)
        {
            AppUser sender = await _userManager.GetUserAsync(HttpContext.User);
            model.Contact2Sender = $"{sender.Name} {sender.Surname}";
            AppUser receiver = await _userManager.FindByNameAsync(model.Contact2Reciver);
            model.Contact2Reciver = receiver.UserName;
            contact2Manager.TAdd(model);
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";
            return RedirectToAction("SendMessage");
        }
        public IActionResult DeleteMessage(int id)
        {
            var cont = contact3Manager.TGetById(id);
            contact3Manager.TDelete(cont);
            return RedirectToAction("Index");
        }
    }
}
