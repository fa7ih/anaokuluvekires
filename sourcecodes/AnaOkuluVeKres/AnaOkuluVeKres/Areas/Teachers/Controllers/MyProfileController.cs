using AnaOkuluVeKres.Areas.Parents.Models;
using AnaOkuluVeKres.Areas.Teachers.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    [Authorize(Roles = "Öğretmen,Admin")]
    [Route("Teachers/[controller]/[action]")]
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
            TeacherEditViewModel viewModel = new TeacherEditViewModel();
            viewModel.userName = values?.UserName;
            viewModel.name = values?.Name;
            viewModel.surname = values?.Surname;
            viewModel.mail = values?.Email;
            viewModel.phonenumber = values?.PhoneNumber;
            viewModel.teacherbiography = values?.TeacherBiography;
            viewModel.teacherbranch = values?.TeacherBranch;
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(TeacherEditViewModel viewModel)
        {
            var teacher = await _userManager.FindByNameAsync(User.Identity.Name);
            if (viewModel != null && viewModel.image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extansion = Path.GetExtension(viewModel.image.FileName);
                var imageName = Guid.NewGuid() + extansion;
                var saveLocation = resource + "/wwwroot/UserImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await viewModel.image.CopyToAsync(stream);
                teacher.ImageUrl = imageName;
            }
            teacher.UserName = viewModel.userName;
            teacher.Name = viewModel.name;
            teacher.Surname = viewModel.surname;
            teacher.TeacherBiography = viewModel.teacherbiography;
            teacher.TeacherBranch = viewModel.teacherbranch;
            teacher.TeacherStatus = true;
            if (viewModel != null && !string.IsNullOrEmpty(viewModel.password))
            {
                teacher.PasswordHash = _userManager.PasswordHasher.HashPassword(teacher, viewModel.password);
            }
            var result = await _userManager.UpdateAsync(teacher);
            if (result.Succeeded)
            {
                TempData["Message"] = "Güncelleme İşlemi Başarıyla Gerçekleştirilmiştir.";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
