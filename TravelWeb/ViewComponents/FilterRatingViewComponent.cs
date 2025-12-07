using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class FilterRatingViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}