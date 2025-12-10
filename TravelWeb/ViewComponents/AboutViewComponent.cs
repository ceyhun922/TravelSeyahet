using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public AboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var value = _aboutService.GetFindIdService(id);
            if (value == null)
                value = new About();
            return View(value);
        }
    }
}