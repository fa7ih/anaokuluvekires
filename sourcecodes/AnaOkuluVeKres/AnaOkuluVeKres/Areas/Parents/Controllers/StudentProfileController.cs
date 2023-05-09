using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    [AllowAnonymous]
    public class StudentProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
