using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    [Authorize(Roles = "Öğretmen")]
    [Route("Teachers/[controller]/[action]")]
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
