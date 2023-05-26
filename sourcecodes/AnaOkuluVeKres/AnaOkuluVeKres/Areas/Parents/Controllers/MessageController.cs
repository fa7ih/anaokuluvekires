using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    [Area("Parents")]
    //[Authorize(Roles = "Veli")]
    //[Authorize(Roles = "Admin")]
    [Authorize(Roles = "Veli,Admin")]
    [Route("Parents/[controller]/[action]")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
