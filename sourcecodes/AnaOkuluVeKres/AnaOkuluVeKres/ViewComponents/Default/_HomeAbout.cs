using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _HomeAbout : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Abouts.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.v2 = context.Abouts.Select(x => x.AboutDescription).FirstOrDefault();
            ViewBag.v3 = context.Abouts.Select(x => x.AboutSubDescription1).FirstOrDefault();
            ViewBag.v4 = context.Abouts.Select(x => x.AboutSubDescription2).FirstOrDefault();
            ViewBag.v5 = context.Abouts.Select(x => x.AboutSubDescription3).FirstOrDefault();
            ViewBag.v6 = context.Abouts.Select(x => x.AboutImage1).FirstOrDefault();
            return View();
        }
    }
}
