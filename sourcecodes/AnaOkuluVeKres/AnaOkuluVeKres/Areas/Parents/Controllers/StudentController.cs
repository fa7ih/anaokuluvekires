using AnaOkuluVeKres.Areas.Parents.Models;
using AnaOkuluVeKres.Areas.Teachers.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [Authorize(Roles = "Veli,Admin")]
    [Route("Parents/[controller]/[action]")]
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;

        public StudentController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
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
        public async Task<IActionResult> NewStudent(Students2 student)
        {
            var user = await _userManager.GetUserAsync(User);
            student.AppUserId = int.Parse(await _userManager.GetUserIdAsync(user));
            Random random = new Random();
            int studentNo = random.Next(1000, 10000);
            bool isDuplicate = studentManager.GetList().Any(s => s.StudentNo == studentNo);
            while (isDuplicate)
            {
                studentNo = random.Next(1000, 10000);
                isDuplicate = studentManager.GetList().Any(s => s.StudentNo == studentNo);
            }
            student.StudentNo = studentNo;
            student.Status = "Onay Bekliyor";
            student.EnrollmentDate = DateTime.Now;
            studentManager.TAdd(student);
            return RedirectToAction("MyApprovalStudent", "Student");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var existingStudent = studentManager.TGetById(id);
            if (existingStudent == null)
            {
                return NotFound();
            }
            var viewModel = new StudentEditViewModel
            {
                StudentId = existingStudent.StudentId,
                StudentName = existingStudent.StudentName,
                StudentSurName = existingStudent.StudentSurName,
                StudentTc = existingStudent.StudentTc,
                StudentBirth = existingStudent.StudentBirth,
                StudentGender = existingStudent.StudentGender
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult EditStudent(StudentEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var existingStudent = studentManager.TGetById(viewModel.StudentId);
                if (existingStudent == null)
                {
                    return NotFound();
                }
                existingStudent.StudentName = viewModel.StudentName;
                existingStudent.StudentSurName = viewModel.StudentSurName;
                existingStudent.StudentTc = viewModel.StudentTc;
                existingStudent.StudentBirth = viewModel.StudentBirth;
                existingStudent.StudentGender = viewModel.StudentGender;
                studentManager.TUpdate(existingStudent);
                return RedirectToAction("MyCurrentStudent", "Student");
            }
            return View(viewModel);
        }
    }
}
