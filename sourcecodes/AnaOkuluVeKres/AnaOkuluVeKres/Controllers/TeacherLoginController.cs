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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public TeacherLoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(TeacherLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _userManager.FindByNameAsync(model.username).Result;

            if (user != null && _userManager.CheckPasswordAsync(user, model.password).Result)
            {
                var result = _signInManager.PasswordSignInAsync(user, model.password, false, lockoutOnFailure: false).Result;

                if (result.Succeeded)
                {
                    var isAdmin = _userManager.IsInRoleAsync(user, "Admin").Result;
                    var isVeli = _userManager.IsInRoleAsync(user, "Öğretmen").Result;

                    if (isAdmin || isVeli)
                    {
                        return RedirectToAction("Index", "MyProfile", new { area = "Teachers" });
                    }

                    ModelState.AddModelError(string.Empty, "Admin veya Öğretmen yetkilerine sahip değilsiniz.");
                    ViewData["ErrorMessage"] = "Admin veya Öğretmen yetkilerine sahip değilsiniz. Lütfen Yönetici İle İletişime Geçin";
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
                ViewData["ErrorMessage"] = "Geçersiz kullanıcı adı veya şifre.";
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Default");
        }
    }
}
