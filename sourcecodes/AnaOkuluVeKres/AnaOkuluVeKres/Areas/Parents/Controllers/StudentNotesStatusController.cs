using AnaOkuluVeKres.Areas.Teachers.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [Authorize(Roles = "Veli,Admin")]
    [Route("Parents/[controller]/[action]")]
    public class StudentNotesStatusController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;

        public StudentNotesStatusController(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var students = _context.Students2
                .Include(s => s.StudentStatus)
                .Where(s => s.AppUserId == values.Id && s.Status == "onaylandı")
                .ToList();

            var studentViewModels = students.Select(s => new StudentStatusViewModel
            {
                Name = $"{s.StudentName} {s.StudentSurName}",
                StudentNo = s.StudentNo,
                StudentStatusHealth = s.StudentStatus != null ? s.StudentStatus.StudentStatusHealth?.ToString() : "",
                StudentStatusInClassSituation = s.StudentStatus != null ? s.StudentStatus.StudentStatusInClassSituation?.ToString() : "",
                StudentStatusTeachNotes = s.StudentStatus != null ? s.StudentStatus.StudentStatusTeachNotes?.ToString() : "",
            }).ToList();
            return View(studentViewModels);
        }
        public async Task<IActionResult> Details(int id)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var student = _context.Students2
                .Include(s => s.StudentStatus)
                .FirstOrDefault(s => s.AppUserId == values.Id && s.Status == "onaylandı");

            if (student == null)
            {
                return NotFound();
            }

            var studentViewModel = new StudentStatusViewModel
            {
                Name = $"{student.StudentName} {student.StudentSurName}",
                StudentNo = student.StudentNo,
                StudentStatusHealth = student.StudentStatus?.StudentStatusHealth?.ToString(),
                StudentStatusInClassSituation = student.StudentStatus?.StudentStatusInClassSituation?.ToString(),
                StudentStatusTeachNotes = student.StudentStatus?.StudentStatusTeachNotes?.ToString(),
            };

            return View(studentViewModel);
        }

    }
}
