using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string TestimonialNameSurname { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialImageUrl { get; set; }
        public bool TestimonialImageStatus { get; set; }
        [NotMapped]
        public IFormFile TestimonialImageFile { get; set; }
    }
}
