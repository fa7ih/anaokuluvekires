using AnaOkuluVeKres.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.ViewComponents.Teacher
{
    public class _TeacherUser:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _TeacherUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var model = new TeacherUserModel
            {
                name = user.Name,
                surName = user.Surname,
                ımageUrl = user.ImageUrl
            };

            return View(model);
        }
    }
}
