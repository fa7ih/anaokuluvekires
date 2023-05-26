using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Linq;
using X.PagedList;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    [Route("Admin/[controller]/[action]")]
    public class StudentAdminController : Controller
    {
        Context context = new Context();
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        public IActionResult Index(int page = 1)
        {
            var values = context.Students2.Where(t => t.Status == "Onay Bekliyor").ToList();
            return View(values.ToPagedList(page, 8));
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
        public IActionResult ApprovalStudentList(int page = 1)
        {
            var values = context.Students2.Where(t => t.Status == "Onaylandı").ToList();
            return View(values.ToPagedList(page, 8));
        }
        public IActionResult DisapprovedStudentList(int page = 1)
        {
            var values = context.Students2.Where(t => t.Status == "Onaylanmadı").ToList();
            return View(values.ToPagedList(page, 8));
        }

    }
}
