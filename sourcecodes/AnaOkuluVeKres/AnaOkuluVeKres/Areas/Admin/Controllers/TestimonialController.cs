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
using Microsoft.AspNetCore.Authorization;
using AnaOkuluVeKres.Areas.Admin.Models;
using Microsoft.Extensions.Hosting;

namespace AnaOkuluVeKres.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
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
            var testimonial = testimonialManager.TGetById(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsTestimonial(int testimonialId, string testimonialNameSurname, string testimonialDescription, IFormFile testimonialImageFile)
        {
            if (ModelState.IsValid)
            {
                Testimonial existingTestimonial = testimonialManager.TGetById(testimonialId);
                if (existingTestimonial == null)
                {
                    return NotFound();
                }

                existingTestimonial.TestimonialNameSurname = testimonialNameSurname;
                existingTestimonial.TestimonialDescription = testimonialDescription;

                if (testimonialImageFile != null && testimonialImageFile.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "TestimonialImages");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + testimonialImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    testimonialImageFile.CopyTo(new FileStream(filePath, FileMode.Create));

                    existingTestimonial.TestimonialImageUrl = uniqueFileName;
                }

                testimonialManager.TUpdate(existingTestimonial);

                return RedirectToAction("Index", "Testimonial");
            }

            return View();
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
