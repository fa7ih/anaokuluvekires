using AnaOkuluVeKres.Areas.Teachers.Models;
using DataAccessLayer.Concrete;
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
    public class StudentNoteListController : Controller
    {
        private readonly Context _context;

        public StudentNoteListController(Context context)
        {
            _context = context;
        }

        private List<StudentViewModel> GetApprovedStudents()
        {
            var students = _context.Students2
                .Include(s => s.StudentStatus)
                .Where(s => s.Status == "Onaylandı")
                .ToList();

            var studentViewModels = students.Select(s => new StudentViewModel
            {
                Name = $"{s.StudentName} {s.StudentSurName}",
                StudentNo = s.StudentNo,
                StudentTc = s.StudentTc,
                StudentStatusMusic = s.StudentStatus != null ? s.StudentStatus.StudentStatusMusic.ToString() : "Not Girilmemiş",
                StudentStatusDevelopment = s.StudentStatus != null ? s.StudentStatus.StudentStatusDevelopment.ToString() : "Not Girilmemiş",
                StudentStatusDance = s.StudentStatus != null ? s.StudentStatus.StudentStatusDance.ToString() : "Not Girilmemiş",
                StudentStatusSport = s.StudentStatus != null ? s.StudentStatus.StudentStatusSport.ToString() : "Not Girilmemiş",
                StudentStatusAlphabet = s.StudentStatus != null ? s.StudentStatus.StudentStatusAlphabet.ToString() : "Not Girilmemiş",
                StudentStatusMaths = s.StudentStatus != null ? s.StudentStatus.StudentStatusMaths.ToString() : "Not Girilmemiş"
            }).ToList();

            return studentViewModels;
        }

        public IActionResult Index(int page = 1)
        {
            var studentViewModels = GetApprovedStudents();
            return View(studentViewModels.ToPagedList(page, 8));
        }

        public IActionResult Index2(int page = 1)
        {
            var studentViewModels = GetApprovedStudents();
            return View(studentViewModels.ToPagedList(page, 8));
        }

    }
}
