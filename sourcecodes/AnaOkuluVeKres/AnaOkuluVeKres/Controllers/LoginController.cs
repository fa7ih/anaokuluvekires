using AnaOkuluVeKres.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(ParentRegisterViewModel parentRegisterViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = parentRegisterViewModel.Name,
                Surname = parentRegisterViewModel.Surname,
                Email = parentRegisterViewModel.Mail,
                UserName = parentRegisterViewModel.UserName,
                RegistrationDate = DateTime.Now
            };
            if (parentRegisterViewModel.Password == parentRegisterViewModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, parentRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "Veli");
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(parentRegisterViewModel);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(ParentSignInViewModel model)
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
                    var isVeli = _userManager.IsInRoleAsync(user, "Veli").Result;

                    if (isAdmin || isVeli)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Parents" });
                    }

                    ModelState.AddModelError(string.Empty, "Admin veya Veli yetkilerine sahip değilsiniz.");
                    ViewData["ErrorMessage"] = "Admin veya Veli yetkilerine sahip değilsiniz. Lütfen Yönetici İle İletişime Geçin";
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
