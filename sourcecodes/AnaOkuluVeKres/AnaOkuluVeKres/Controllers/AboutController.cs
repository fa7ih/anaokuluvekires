using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
