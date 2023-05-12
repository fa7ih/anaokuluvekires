using AnaOkuluVeKres.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class TeacherAdminController : Controller
    {
        TeacherManager teacherManager = new TeacherManager(new EfTeacherDal());
        public IActionResult Index()
        {
            var values = teacherManager.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult DeleteTeacher(int id)
        {
            var value = teacherManager.TGetById(id);
            value.TeacherStatus = false;
            teacherManager.TUpdate(value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ActiveTeacher(int id)
        {
            var value = teacherManager.TGetById(id);
            value.TeacherStatus = true;
            teacherManager.TUpdate(value);
            return RedirectToAction("Index", "TeacherAdmin");
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
                var extensions = Path.GetExtension(teacherAdd.teacherImgUrl.FileName);
                var newImageName = Guid.NewGuid() + extensions;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/TeacherImages/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                teacherAdd.teacherImgUrl.CopyTo(stream);
                teacher.TeacherImgUrl = newImageName;
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
            return RedirectToAction("Index");
        }
    }
}
