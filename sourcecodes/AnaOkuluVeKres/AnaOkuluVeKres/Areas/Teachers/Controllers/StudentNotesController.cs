using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace AnaOkuluVeKres.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    [Authorize(Roles = "Öğretmen,Admin")]
    [Route("Teachers/[controller]/[action]")]
    public class StudentNotesController : Controller
    {
        private readonly Context _context;
        public StudentNotesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            var students = _context.Students2.Where(s => s.Status == "Onaylandı").ToList();
            return View(students.ToPagedList(page, 8));
        }
        [HttpPost]
        public IActionResult Grade(int studentId, int status, string statusType, string stringStatus)
        {
            var student = _context.Students2.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                var studentStatus = _context.StudentStatuses.FirstOrDefault(ss => ss.StudentId == studentId);

                if (studentStatus != null)
                {
                    switch (statusType)
                    {
                        case "Health":
                            studentStatus.StudentStatusHealth = stringStatus;
                            break;
                        case "Development":
                            studentStatus.StudentStatusDevelopment = status;
                            break;
                        case "Music":
                            studentStatus.StudentStatusMusic = status;
                            break;
                        case "Dance":
                            studentStatus.StudentStatusDance = status;
                            break;
                        case "Sport":
                            studentStatus.StudentStatusSport = status;
                            break;
                        case "Alphabet":
                            studentStatus.StudentStatusAlphabet = status;
                            break;
                        case "Maths":
                            studentStatus.StudentStatusMaths = status;
                            break;
                        case "TeacherNotes":
                            studentStatus.StudentStatusTeachNotes = stringStatus;
                            break;
                        default:
                            return BadRequest();
                    }

                    _context.SaveChanges();
                }
                else
                {
                    studentStatus = new StudentStatus
                    {
                        StudentId = studentId
                    };

                    switch (statusType)
                    {
                        case "Health":
                            studentStatus.StudentStatusHealth = stringStatus;
                            break;
                        case "Development":
                            studentStatus.StudentStatusDevelopment = status;
                            break;
                        case "Music":
                            studentStatus.StudentStatusMusic = status;
                            break;
                        case "Dance":
                            studentStatus.StudentStatusDance = status;
                            break;
                        case "Sport":
                            studentStatus.StudentStatusSport = status;
                            break;
                        case "Alphabet":
                            studentStatus.StudentStatusAlphabet = status;
                            break;
                        case "Maths":
                            studentStatus.StudentStatusMaths = status;
                            break;
                        case "TeacherNotes":
                            studentStatus.StudentStatusTeachNotes = stringStatus;
                            break;
                        default:
                            return BadRequest();
                    }

                    _context.StudentStatuses.Add(studentStatus);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult InClassSituationGrade(int studentId, string inClassSituation)
        {
            var student = _context.Students2.FirstOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                var studentStatus = _context.StudentStatuses.FirstOrDefault(ss => ss.StudentId == studentId);

                if (studentStatus != null)
                {
                    studentStatus.StudentStatusInClassSituation = inClassSituation;
                    _context.SaveChanges();
                }
                else
                {
                    studentStatus = new StudentStatus
                    {
                        StudentId = studentId,
                        StudentStatusInClassSituation = inClassSituation
                    };
                    _context.StudentStatuses.Add(studentStatus);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

    }

}


