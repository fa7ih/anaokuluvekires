using AnaOkuluVeKres.Areas.Parents.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [Route("Parents/[controller]/[action]")]
    public class MyProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ParentEditViewModel parentEditViewModel = new ParentEditViewModel();
            parentEditViewModel.name= values.Name;
            parentEditViewModel.surname= values.Surname;
            parentEditViewModel.mail = values.Email;
            parentEditViewModel.phonenumber = values.PhoneNumber;
            return View(parentEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(ParentEditViewModel parentEditViewModel)
        {
            var parent = await _userManager.FindByNameAsync(User.Identity.Name);
            if (parentEditViewModel !=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extansion = Path.GetExtension(parentEditViewModel.image.FileName);
                var imageName = Guid.NewGuid() + extansion;
                var saveLocation = resource + "/wwwroot/ParentImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create); 
                await parentEditViewModel.image.CopyToAsync(stream);
                parent.ImageUrl = imageName;
            }
            parent.Name= parentEditViewModel.name;
            parent.Surname= parentEditViewModel.surname;
            parent.PasswordHash= _userManager.PasswordHasher.HashPassword(parent,parentEditViewModel.password);
            var result = await _userManager.UpdateAsync(parent);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }
            return View();
        }
    }
}
