using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _AdminMessageCount:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;

        public _AdminMessageCount(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser parent = await _userManager.GetUserAsync(HttpContext.User);
            string username = parent.UserName;
            List<Contact3> messages = _context.Contacts3.Where(m => m.Contact2ReplyReciver == username).ToList();
            List<Contact2> messages1 = _context.Contacts2.Where(m => m.Contact2Reciver == username).ToList();
            int messageCount = messages.Count;
            int messageCount1 = messages1.Count;
            var value = _context.Contacts.Count();
            ViewBag.MessageCount = messageCount;
            ViewBag.MessageCount1 = messageCount1;
            ViewBag.MessageCount2 = value;
            ViewBag.MessageCount3 = messageCount1 + messageCount + value;
            return View();
        }
    }
}
