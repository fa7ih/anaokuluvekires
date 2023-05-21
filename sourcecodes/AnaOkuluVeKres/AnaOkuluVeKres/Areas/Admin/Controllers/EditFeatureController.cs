using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class EditFeatureController : Controller
    {
        private readonly Context _context;
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public EditFeatureController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            int id = 1;
            var value = _context.Features.FirstOrDefault(i => i.FeatureId == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Index(Feature model)
        {
            var value = _context.Features.FirstOrDefault(i => i.FeatureId == 1);
            value.FeatureHeadTitle = model.FeatureHeadTitle;
            value.FeatureTitle1 = model.FeatureTitle1;
            value.FeatureTitle2 = model.FeatureTitle2;
            value.FeatureTitle3 = model.FeatureTitle3;
            value.FeatureTitle4 = model.FeatureTitle4;
            value.FeatureDescription1 = model.FeatureDescription1;
            value.FeatureDescription2 = model.FeatureDescription2;
            value.FeatureDescription3 = model.FeatureDescription3;
            value.FeatureDescription4 = model.FeatureDescription4;
            featureManager.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
