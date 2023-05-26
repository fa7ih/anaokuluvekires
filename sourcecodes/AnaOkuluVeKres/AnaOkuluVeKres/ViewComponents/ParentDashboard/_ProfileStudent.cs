using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnaOkuluVeKres.ViewComponents.ParentDashboard
{
    public class _ProfileStudent:ViewComponent
    {
        StudentManager studentManager = new StudentManager(new EfStudentDal());
        private readonly UserManager<AppUser> _userManager;

        public _ProfileStudent( UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = studentManager.GetlistWithStudentByAccepted(values.Id);
            return View(valuesList);
        }
    }
}
