using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class About2ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}