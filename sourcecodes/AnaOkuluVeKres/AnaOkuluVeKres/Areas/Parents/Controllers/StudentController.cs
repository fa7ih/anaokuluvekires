using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [Authorize]
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private readonly UserManager<AppUser> _userManager;

        public StudentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentStudent()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = studentManager.GetlistWithStudentByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> GetlistWithStudentByWaitDisapproved()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = studentManager.GetlistWithStudentByWaitDisapproved(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalStudent()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = studentManager.GetListApprovalStudent(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewStudent(Student student)
        {
            student.Status = "Onay Bekliyor";
            studentManager.TAdd(student);
            return RedirectToAction("MyCurrentStudent");
        }
    }
}
