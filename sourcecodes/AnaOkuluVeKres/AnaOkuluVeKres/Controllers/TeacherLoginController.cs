using AnaOkuluVeKres.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Controllers
{
    [AllowAnonymous]
    public class TeacherLoginController : Controller
    {
        private readonly Context _context;

        public TeacherLoginController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult LoginTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginTeacher(LoginViewModel model)
        {
            var teacher = _context.Teachers.SingleOrDefault(t => t.TeacherUserName == model.TeacherUserName && t.TeacherTC == model.TeacherTC);

            if (teacher != null)
            {
                var user = new { Username = teacher.TeacherUserName, Role = "Öğretmen" };
                await Authenticate(user.Username, user.Role);

                if (user.Role != "Öğretmen")
                {
                    TempData["ErrorMessage"] = "Gerekli işlemler tamamlanmamış. Lütfen yönetici ile iletişime geçin.";
                    return RedirectToAction("Index", "Contact");
                }
                return RedirectToAction("Index", "MyProfile", new { area = "Teachers" });
            }

            return View("Index");
        }
        private async Task Authenticate(string username, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, username),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties());
        }
    }
}
