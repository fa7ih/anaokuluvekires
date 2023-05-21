using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var value = context.Testimonials.Where(t => t.TestimonialImageStatus == true).ToList();
            return View(value);
        }
    }
}
