using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class UserInfoViewComponent : ViewComponent
    {
        private readonly UserManager<Writer> _userManager;

        public UserInfoViewComponent(UserManager<Writer> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value =await _userManager.GetUserAsync(HttpContext.User);
            return View(value);
        }
    }
}