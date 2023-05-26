using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.ViewComponents.ParentDashboard
{
    public class _MessageCount:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;

        public _MessageCount(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser parent = await _userManager.GetUserAsync(HttpContext.User);
            string username = parent.UserName;
            List<Contact3> messages = _context.Contacts3.Where(m => m.Contact2ReplyReciver == username).ToList();
            List<Contact4> messages1 = _context.Contacts4.Where(m => m.AdminReplyReciver == username).ToList();
            int messageCount = messages.Count;
            int messageCount1 = messages1.Count;
            ViewBag.MessageCount = messageCount;
            ViewBag.MessageCount1 = messageCount1;
            ViewBag.MessageCount2 = messageCount1 + messageCount;
            return View();
        }
    }
}
