using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class FormViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}