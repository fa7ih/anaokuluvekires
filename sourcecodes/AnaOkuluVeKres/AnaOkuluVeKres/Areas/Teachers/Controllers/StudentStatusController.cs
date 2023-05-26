using AnaOkuluVeKres.Areas.Parents.Models;
using AnaOkuluVeKres.Areas.Teachers.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using X.PagedList;

namespace AnaOkuluVeKres.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    [Authorize(Roles = "Öğretmen,Admin")]
    [Route("Teachers/[controller]/[action]")]
    public class StudentStatusController : Controller
    {
        private readonly Context _context;

        public StudentStatusController(Context context)
        {
            _context = context;
        }

        private List<StudentStatusViewModel> GetApprovedStudents()
        {
            var students = _context.Students2
                .Include(s => s.StudentStatus)
                .Where(s => s.Status == "Onaylandı")
                .ToList();

            var studentViewModels = students.Select(s => new StudentStatusViewModel
            {
                Name = $"{s.StudentName} {s.StudentSurName}",
                StudentNo = s.StudentNo,
                StudentStatusHealth = s.StudentStatus != null ? s.StudentStatus.StudentStatusHealth?.ToString() : "Not Girilmemiş",
                StudentStatusInClassSituation = s.StudentStatus != null ? s.StudentStatus.StudentStatusInClassSituation?.ToString() : "Not Girilmemiş",
                StudentStatusTeachNotes = s.StudentStatus != null ? s.StudentStatus.StudentStatusTeachNotes?.ToString() : "Not Girilmemiş",
            }).ToList();


            return studentViewModels;
        }

        public IActionResult Index(int page = 1)
        {
            var studentViewModels = GetApprovedStudents();
            return View(studentViewModels.ToPagedList(page, 8));
        }

        public IActionResult Details(int id)
        {
            var studentViewModel = GetApprovedStudents().FirstOrDefault(s => s.StudentId == id);
            if (studentViewModel == null)
            {
                return NotFound();
            }

            return View(studentViewModel);
        }
    }
}
