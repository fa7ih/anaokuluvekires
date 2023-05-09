using Microsoft.AspNetCore.Mvc;

namespace AnaOkuluVeKres.Areas.Parents.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
