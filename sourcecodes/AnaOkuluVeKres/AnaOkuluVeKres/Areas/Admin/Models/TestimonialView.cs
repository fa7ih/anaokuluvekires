using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Areas.Admin.Models
{
    public class TestimonialView
    {
        public int TestimonialId { get; set; }
        public string TestimonialNameSurname { get; set; }
        public string TestimonialDescription { get; set; }
        public IFormFile TestimonialImageFile { get; set; }
    }
}
