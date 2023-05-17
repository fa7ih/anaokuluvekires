using AnaOkuluVeKres.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using AnaOkuluVeKres.ViewComponents.Default;
using DataAccessLayer.Concrete;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous]
    public class TeacherAdminController : Controller
    {
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        Context context = new Context();
        public IActionResult Index()
        {
            var values = teacherManager.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = teacherManager.TGetById(id);
            teacher.TeacherStatus = false; 
            teacherManager.TUpdate(teacher);
            return RedirectToAction("Index", new { id = teacher.TeacherId });
        }
        [HttpPost]
        public IActionResult ActiveTeacher(int id)
        {
            var teacher = teacherManager.TGetById(id);
            teacher.TeacherStatus = true;
            teacherManager.TUpdate(teacher);
            return RedirectToAction("Index", new { id = teacher.TeacherId });
        }
        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(TeacherAdd teacherAdd)
        {
            Teacher teacher = new Teacher();
            if (teacher.TeacherImgUrl != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extansion = Path.GetExtension(teacherAdd.teacherImgUrl.FileName);
                var imageName = Guid.NewGuid() + extansion;
                var saveLocation = resource + "/wwwroot/TeacherImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                teacherAdd.teacherImgUrl.CopyTo(stream);
                teacher.TeacherImgUrl = imageName;
            }
            teacher.TeacherUserName = teacherAdd.teacherUserName;
            teacher.TeacherNameSurname = teacherAdd.teacherNameSurname;
            teacher.TeacherTC = teacherAdd.teacherTC;
            teacher.TeacherBranch = teacherAdd.teacherBranch;
            teacher.TeacherBirth = teacherAdd.teacherBirth;
            teacher.TeacherGender = teacherAdd.teacherGender;
            teacher.TeacherBiography = teacherAdd.teacherBiography;
            teacher.TeacherStatus = true;
            teacherManager.TAdd(teacher);
            return RedirectToAction("Index", "TeacherAdmin");
        }
        public IActionResult ActiveTeacher() 
        {
            var teachers = context.Teachers.Where(t => t.TeacherStatus == true).ToList();
            return View(teachers);
        }
        public IActionResult PassiveTeacher() 
        {
            var teachers = context.Teachers.Where(t => t.TeacherStatus == false).ToList();
            return View(teachers);
        }
        public IActionResult TeacherDetails()
        {
            return View();
        }
    }
}
