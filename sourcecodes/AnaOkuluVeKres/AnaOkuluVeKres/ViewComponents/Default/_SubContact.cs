using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _SubContact:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v = context.Informations.Select(x => x.InformationPhone).FirstOrDefault();
            return View();
        }
    }
}
