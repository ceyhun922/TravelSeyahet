using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class MessagesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }   
    }
}