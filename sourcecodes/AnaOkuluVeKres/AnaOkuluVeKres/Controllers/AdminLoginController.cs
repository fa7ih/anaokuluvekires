using AnaOkuluVeKres.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminLoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
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
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _userManager.FindByNameAsync(model.Username).Result;

            if (user != null && _userManager.CheckPasswordAsync(user, model.Password).Result)
            {
                var result = _signInManager.PasswordSignInAsync(user, model.Password, false, lockoutOnFailure: false).Result;

                if (result.Succeeded)
                {
                    var isAdmin = _userManager.IsInRoleAsync(user, "Admin").Result;
                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    ModelState.AddModelError(string.Empty, "Admin yetkilerine sahip değilsiniz.");
                    ViewData["ErrorMessage"] = "Admin yetkilerine sahip değilsiniz.";
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
