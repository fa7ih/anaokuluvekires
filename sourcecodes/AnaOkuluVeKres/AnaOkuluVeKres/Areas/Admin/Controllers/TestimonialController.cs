using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Linq;
using AnaOkuluVeKres.ViewComponents.Default;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        private readonly Context _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TestimonialController(Context context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DetailsTestimonial(int id)
        {
            Testimonial value = _context.Testimonials.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return View(value);
        }
        [HttpPost]
        public IActionResult DetailsTestimonial(Testimonial testimonial)
        {
            var existingTestimonial = _context.Testimonials.Find(testimonial.TestimonialId);
            if (existingTestimonial == null)
            {
                return NotFound();
            }
            existingTestimonial.TestimonialNameSurname = testimonial.TestimonialNameSurname;
            existingTestimonial.TestimonialDescription = testimonial.TestimonialDescription;
            existingTestimonial.TestimonialImageStatus = true;
            testimonialManager.TUpdate(existingTestimonial);
            return RedirectToAction("Index","Testimonial");
        }
        [HttpPost]
        public IActionResult PassiveTestimonials(int id)
        {
            var value = testimonialManager.TGetById(id);
            value.TestimonialImageStatus = false;
            testimonialManager.TUpdate(value);
            return RedirectToAction("Index", new { id = value.TestimonialId });
        }
        [HttpPost]
        public IActionResult ActiveTestimonials(int id)
        {
            var value = testimonialManager.TGetById(id);
            value.TestimonialImageStatus = true;
            testimonialManager.TUpdate(value);
            return RedirectToAction("Index", new { id = value.TestimonialId });
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Testimonial testimonial, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "TestimonialImages");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    imageFile.CopyTo(new FileStream(filePath, FileMode.Create));

                    testimonial.TestimonialImageUrl = uniqueFileName;
                }
                testimonial.TestimonialImageStatus = true;
                testimonialManager.TAdd(testimonial);
                return RedirectToAction("Index", "Testimonial");
            }

            return View(testimonial);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var value = testimonialManager.TGetById(id);
            testimonialManager.TDelete(value);
            return RedirectToAction("Index", "Testimonial");
        }
    }
}
