using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class StudentAdminController : Controller
    {
        Context context = new Context();
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        public IActionResult Index()
        {
            var values = context.Students.Where(t => t.Status == "Onay Bekliyor").ToList();
            return View(values);
        }
        [HttpPost]
        public IActionResult ApprovalStudent(int id)
        {
            var values = studentManager.TGetById(id);
            values.Status = "Onaylandı";
            studentManager.TUpdate(values);
            return RedirectToAction("Index", new { id = values.StudentId });
        }
        [HttpPost]
        public IActionResult DisapprovedStudent(int id)
        {
            var values = studentManager.TGetById(id);
            values.Status = "Onaylanmadı";
            studentManager.TUpdate(values);
            return RedirectToAction("Index", new { id = values.StudentId });
        }
        public IActionResult ApprovalStudentList()
        {
            var values = context.Students.Where(t => t.Status == "Onaylandı").ToList();
            return View(values);
        }
        public IActionResult DisapprovedStudentList()
        {
            var values = context.Students.Where(t => t.Status == "Onaylanmadı").ToList();
            return View(values);
        }

    }
}
