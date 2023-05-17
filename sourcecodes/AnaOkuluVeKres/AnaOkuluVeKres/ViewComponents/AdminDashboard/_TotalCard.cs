using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _TotalCard:ViewComponent
    {
        private readonly Context _context;

        public _TotalCard(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var currentYear = DateTime.Now.Year; 
            var enrollments = _context.Students
                .Where(s => s.EnrollmentDate.Year == currentYear) 
                .GroupBy(s => new { s.EnrollmentDate.Year, s.EnrollmentDate.Month })
                .Select(g => new { Month = g.Key, Count = g.Count() })
                .OrderBy(g => g.Month.Year)
                .ThenBy(g => g.Month.Month)
                .ToList();

            var months = enrollments.Select(e => $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(e.Month.Month)}, {e.Month.Year}").ToList();
            var counts = enrollments.Select(e => e.Count).ToList();

            ViewBag.Months = months;
            ViewBag.Enrollments = counts;

            return View();
        }
    }
}
    