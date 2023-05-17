
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace AnaOkuluVeKres.ViewComponents.AdminDashboard
{
    public class _Cards2Statistic:ViewComponent
    {
        Context context = new Context();
        private readonly UserManager<AppUser> _userManager;
        public _Cards2Statistic(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var currentYear = DateTime.Now.Year;
            var startDate = new DateTime(currentYear, 1, 1);
            var endDate = new DateTime(currentYear, 12, 31);
            var userCount = context.Users
                .Count(u => u.RegistrationDate >= startDate && u.RegistrationDate <= endDate);
            ViewBag.v1 = context.Users.Count();
            ViewBag.v2 = userCount;
            ViewBag.v3 = context.Students.Count(x=>x.Status=="Onay Bekliyor");
            return View();
        }
    }
}
