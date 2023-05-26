using System;
using System.ComponentModel.DataAnnotations;

namespace AnaOkuluVeKres.Areas.Parents.Models
{
    public class StudentEditViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Öğrenci TC kimlik numarası 11 basamaklı bir sayı olmalıdır.")]
        public long StudentTc { get; set; }
        public DateTime StudentBirth { get; set; }
        public string StudentGender { get; set; }
    }
}
