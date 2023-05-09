using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Features.Select(x=>x.FeatureHeadTitle).FirstOrDefault();
            ViewBag.v2 = context.Features.Select(x=>x.FeatureTitle1).FirstOrDefault();
            ViewBag.v3 = context.Features.Select(x=>x.FeatureTitle2).FirstOrDefault();
            ViewBag.v4 = context.Features.Select(x=>x.FeatureTitle3).FirstOrDefault();
            ViewBag.v5 = context.Features.Select(x=>x.FeatureTitle4).FirstOrDefault();
            ViewBag.v6 = context.Features.Select(x=>x.FeatureDescription1).FirstOrDefault();
            ViewBag.v7 = context.Features.Select(x=>x.FeatureDescription2).FirstOrDefault();
            ViewBag.v8 = context.Features.Select(x=>x.FeatureDescription3).FirstOrDefault();
            ViewBag.v9 = context.Features.Select(x=>x.FeatureDescription4).FirstOrDefault();
            return View();
        }
    }
}
