using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class ContactInfo:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Informations.Select(x => x.InformationAdress).FirstOrDefault();
            ViewBag.v2 = context.Informations.Select(x => x.InformationPhone).FirstOrDefault();
            ViewBag.v3 = context.Informations.Select(x => x.InformationMail).FirstOrDefault();
            return View();
        }
    }
}
