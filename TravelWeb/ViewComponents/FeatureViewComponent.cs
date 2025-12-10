using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class FeatureViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}