using AnaOkuluVeKres.Areas.Admin.Models;
using AnaOkuluVeKres.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;


namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class AdminTeacher : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AdminTeacher(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index(int page = 1)
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result;
            var teacherList = teachers.ToList();

            return View(teacherList.ToPagedList(page,8));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTeacher(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.TeacherStatus = false;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ActiveTeacher(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.TeacherStatus = true;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTeacher(TeacherRegisterViewModel registerViewModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Surname = registerViewModel.Surname,
                UserName = registerViewModel.UserName,
            };
			if (registerViewModel.Password == registerViewModel.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, registerViewModel.Password);
				if (result.Succeeded)
				{
					appUser.TeacherStatus = true;
					await _userManager.UpdateAsync(appUser);
					await _userManager.AddToRoleAsync(appUser, "Öğretmen");

					return RedirectToAction("Index");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(registerViewModel);
		}

        public IActionResult ActiveTeacher(int page = 1)
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result
                .Where(u => u.TeacherStatus == true)
                .ToList();
            return View(teachers.ToPagedList(page, 8));
        }

        public IActionResult PassiveTeacher(int page = 1)
        {
            var teachers = _userManager.GetUsersInRoleAsync("Öğretmen").Result
                .Where(u => u.TeacherStatus == false)
                .ToList();
            return View(teachers.ToPagedList(page, 8));
        }

        public IActionResult Detay(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            return View("Detay", user);
        }
    }
}
