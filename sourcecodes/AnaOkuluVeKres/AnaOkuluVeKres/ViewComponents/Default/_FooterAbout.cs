using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _FooterAbout:ViewComponent
    {
        private readonly Context _context;

        public _FooterAbout(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Abouts.Select(x => x.AboutDescription).FirstOrDefault();
            return View();
        }
    }
}
