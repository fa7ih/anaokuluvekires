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
    public class ContactAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        Contact2Manager contact2Manager = new Contact2Manager(new EfContact2Dal());
        Contact4Manager contact4Manager = new Contact4Manager(new EfContact4Dal());

        public ContactAdminController(UserManager<AppUser> userManager, Context context)
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

        public async Task<IActionResult> SendMessage()
        {
            var teachers = await _userManager.GetUsersInRoleAsync("Admin");
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
            var cont = contact4Manager.TGetById(id);
            contact4Manager.TDelete(cont);
            return RedirectToAction("Index");
        }
    }
}
