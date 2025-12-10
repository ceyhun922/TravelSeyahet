using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class MapViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}