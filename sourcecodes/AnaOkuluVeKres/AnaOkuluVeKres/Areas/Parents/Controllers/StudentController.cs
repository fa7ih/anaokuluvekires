using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    public class StudentController : Controller
    {
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        public IActionResult MyCurrentStudent()
        {
            return View();
        }
        public IActionResult MyStudentWaitingRegistration()
        {
            return View();
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
            student.AppUserId = 1;
            studentManager.TAdd(student);
            return RedirectToAction("MyCurrentStudent");
        }
    }
}
