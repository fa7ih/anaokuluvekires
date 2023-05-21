using AnaOkuluVeKres.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Role")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        private readonly Context _context;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, Context context, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _context = context;
            _userManager = userManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        [Route("CreateRole")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel roleViewModel)
        {
            AppRole role = new AppRole()
            {
                Name = roleViewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("UpdateRole/{id}")]
        public IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleId = value.Id,
                RoleName = value.Name
            };
            return View(updateRoleViewModel);
        }

        [HttpPost]
        [Route("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleId);
            value.Name = updateRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }

        [Route("ParentList")]
        public IActionResult ParentList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [Route("TeacherList")]
        public IActionResult TeacherList()
        {
            var teachers = _context.Teachers.Where(t => t.TeacherStatus == true).ToList();
            return View(teachers);
        }

        [Route("AssignRole/{id}")]
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["Userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModels.Add(model);
            }
            return View(roleAssignViewModels);
        }
        [HttpPost]
        [Route("AssignRole/{id}")]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userid = (int)TempData["userid"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("ParentList");
        }

        [HttpGet]
        [Route("AssignRoles/{teacherId}")]
        public IActionResult AssignRoles(int teacherId)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == teacherId);
            if (teacher == null)
            {
                return NotFound();
            }

            var roles = _context.Roles.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Name
            }).ToList();

            var viewModel = new AssignRoleViewModel
            {
                TeacherId = teacher.TeacherId,
                TeacherNameSurname = teacher.TeacherNameSurname,
                Roles = roles
            };

            return View(viewModel);
        }
        [HttpPost]
        [Route("AssignRoles/{teacherId}")]
        public IActionResult AssignRoles(AssignRoleViewModel viewModel)
        {
            var teacher = _context.Teachers.FirstOrDefault(t => t.TeacherId == viewModel.TeacherId);
            if (teacher == null)
            {
                return NotFound();
            }

            var selectedRoleId = viewModel.SelectedRoleId;
            var selectedRole = _context.Roles.FirstOrDefault(r => r.Id == selectedRoleId);
            if (selectedRole == null)
            {
                return NotFound();
            }

            var currentRoles = _context.AppRoleTeachers.Where(at => at.TeacherId == teacher.TeacherId).Select(at => at.AppRole).ToList();

            if (currentRoles.Any())
            {
                if (currentRoles.Contains(selectedRole))
                {
                    TempData["Message"] = "Bu rol zaten öğretmenin rolüdür.";
                    return RedirectToAction("AssignRoles");
                }
            }

            var newAppRoleTeacher = new AppRoleTeacher
            {
                AppRole = selectedRole,
                TeacherId = teacher.TeacherId
            };
            _context.AppRoleTeachers.Add(newAppRoleTeacher);
            _context.SaveChanges();

            TempData["Message"] = "Rol atama işlemi başarıyla gerçekleştirilmiştir.";
            return RedirectToAction("AssignRoles");
        }

        [HttpGet]
        [Route("TeacherAssignRolesList")]
        public IActionResult TeacherAssignRolesList()
        {
            var teachers = _context.Teachers
                .Where(t => t.TeacherStatus)
                .Include(t => t.AppRoleTeachers)
                .ThenInclude(at => at.AppRole)
                .ToList();

            var viewModel = new AssignRoleListViewModel
            {
                Teachers = teachers,
                AssignedRolesByTeacher = new Dictionary<int, List<string>>()
            };

            foreach (var teacher in teachers)
            {
                var assignedRoles = teacher.AppRoleTeachers
                    .Select(at => at.AppRole.Name) 
                    .ToList();

                viewModel.AssignedRolesByTeacher.Add(teacher.TeacherId, assignedRoles);
            }

            return View(viewModel);
        }
    }
}

