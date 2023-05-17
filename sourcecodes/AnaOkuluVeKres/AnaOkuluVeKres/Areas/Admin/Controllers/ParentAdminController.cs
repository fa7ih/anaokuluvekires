using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ParentAdminController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IStudentService _studentService;

        public ParentAdminController(IAppUserService appUserService, IStudentService studentService)
        {
            _appUserService = appUserService;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetList();
            return View(values);
        }

        public IActionResult ParentStudent(int id)
        {
            var values = _studentService.GetlistWithStudentByAccepted(id);
            return View(values);
        }
    }
}
