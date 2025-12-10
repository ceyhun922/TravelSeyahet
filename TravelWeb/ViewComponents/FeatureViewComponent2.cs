using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class Feature2ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}