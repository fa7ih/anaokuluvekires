using AnaOkuluVeKres.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.ViewComponents.ParentDashboard
{
    public class _ParentsUser:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ParentsUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var model = new ParentUserModel
            {
                name = user.Name,
                surName = user.Surname,
                ımageUrl = user.ImageUrl
            };

            return View(model);
        }
    }
}
