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
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager,  UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
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

        [Route("UserList")]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
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
            return RedirectToAction("UserList");
        }
        [HttpGet]
        [Route("AssignRoles/{userId}")]
        public async Task<IActionResult> AssignRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var roles = await _roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Name
            }).ToListAsync();

            var viewModel = new AssignRoleViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Roles = roles
            };

            return View(viewModel);
        }

        [HttpPost]
        [Route("AssignRoles/{userId}")]
        public async Task<IActionResult> AssignRoles(AssignRoleViewModel viewModel)
        {
            var user = await _userManager.FindByIdAsync(viewModel.UserId.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var selectedRoleId = viewModel.SelectedRoleId;
            var selectedRole = await _roleManager.FindByIdAsync(selectedRoleId.ToString());
            if (selectedRole == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles.Contains(selectedRole.Name))
            {
                TempData["Message"] = "Bu rol zaten kullanıcının rolüdür.";
                return RedirectToAction("AssignRoles");
            }

            var result = await _userManager.AddToRoleAsync(user, selectedRole.Name);

            if (result.Succeeded)
            {
                TempData["Message"] = "Rol atama işlemi başarıyla gerçekleştirilmiştir.";
                return RedirectToAction("AssignRoles");
            }
            else
            {
                TempData["ErrorMessage"] = "Rol atama işlemi başarısız oldu.";
                return RedirectToAction("AssignRoles");
            }
        }
        [HttpGet]
        [Route("UserAssignRolesList")]
        public async Task<IActionResult> UserAssignRolesList()
        {
            var users = await _userManager.Users.ToListAsync();

            var viewModel = new AssignRoleListViewModel
            {
                Users = users,
                AssignedRolesByUser = new Dictionary<string, List<string>>()
            };

            foreach (var user in users)
            {
                var assignedRoles = await _userManager.GetRolesAsync(user);
                viewModel.AssignedRolesByUser.Add(user.Id.ToString(), assignedRoles.ToList());
            }

            return View(viewModel);
        }
    }
}

