using AnaOkuluVeKres.Areas.Teachers.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    public class StudentNotesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;

        public StudentNotesController(UserManager<AppUser> userManager, Context context)
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

            var studentViewModels = students.Select(s => new StudentViewModel
            {
                Name = $"{s.StudentName} {s.StudentSurName}",
                StudentStatusMusic = s.StudentStatus != null ? s.StudentStatus.StudentStatusMusic.ToString() : "Not Girilmemiş",
                StudentStatusDevelopment = s.StudentStatus != null ? s.StudentStatus.StudentStatusDevelopment.ToString() : "Not Girilmemiş",
                StudentStatusDance = s.StudentStatus != null ? s.StudentStatus.StudentStatusDance.ToString() : "Not Girilmemiş",
                StudentStatusSport = s.StudentStatus != null ? s.StudentStatus.StudentStatusSport.ToString() : "Not Girilmemiş",
                StudentStatusAlphabet = s.StudentStatus != null ? s.StudentStatus.StudentStatusAlphabet.ToString() : "Not Girilmemiş",
                StudentStatusMaths = s.StudentStatus != null ? s.StudentStatus.StudentStatusMaths.ToString() : "Not Girilmemiş"
            }).ToList();
            return View(studentViewModels);
        }
    }
}
