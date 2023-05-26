using AnaOkuluVeKres.Areas.Admin.Models;
using AnaOkuluVeKres.Areas.Parents.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            MyProfileViewModel editViewModel = new MyProfileViewModel();
            editViewModel.UserName = values.UserName;
            editViewModel.Name = values.Name;
            editViewModel.Surname = values.Surname;
            editViewModel.Mail = values.Email;
            editViewModel.PhoneNumber = values.PhoneNumber;
            return View(editViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(MyProfileViewModel editViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (editViewModel != null && editViewModel.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extansion = Path.GetExtension(editViewModel.Image.FileName);
                var imageName = Guid.NewGuid() + extansion;
                var saveLocation = resource + "/wwwroot/UserImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await editViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.UserName = editViewModel.UserName;
            user.Name = editViewModel.Name;
            user.Surname = editViewModel.Surname ;
            if (editViewModel != null && !string.IsNullOrEmpty(editViewModel.Password))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, editViewModel.Password);
            }
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "AdminLogin");
            }
            return View();
        }

    }
}


