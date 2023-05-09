using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AnaOkuluVeKres.ViewComponents.About
{
    public class _About : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=context.Abouts2.Select(x=>x.AboutTitle).FirstOrDefault();
            ViewBag.v2=context.Abouts2.Select(x=>x.About2Description).FirstOrDefault();
            ViewBag.v3=context.Abouts2.Select(x=>x.About2ImgURL).FirstOrDefault();
            return View();
        }
    }
}
