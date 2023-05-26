using AnaOkuluVeKres.Areas.Admin.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ParentAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IStudentService _studentService;

        public ParentAdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IStudentService studentService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _studentService = studentService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var veliRole = await _roleManager.FindByNameAsync("Veli");
            if (veliRole == null)
            {
                return NotFound();
            }

            var usersWithVeliRole = await _userManager.GetUsersInRoleAsync(veliRole.Name);
            var viewModel = new List<AppUser>(); 

            foreach (var user in usersWithVeliRole)
            {
                viewModel.Add(user);
            }

            return View(viewModel.ToPagedList(page, 8));
        }


        public IActionResult ParentStudent(int id)
        {
            var values = _studentService.GetlistWithStudentByAccepted(id);
            return View(values);
        }
    }
}
