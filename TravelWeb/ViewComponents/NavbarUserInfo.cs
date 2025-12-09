using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class NavbarUserInfo : ViewComponent
    {
        private readonly UserManager<Writer> _userManager;

        public NavbarUserInfo(UserManager<Writer> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user =await _userManager.GetUserAsync(HttpContext.User);
            return View(user);
        }
    }
}