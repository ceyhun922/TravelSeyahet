using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class About2ViewComponent : ViewComponent
    {
        private readonly IAbout2Service _about2Service;

        public About2ViewComponent(IAbout2Service about2Service)
        {
            _about2Service = about2Service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =_about2Service.ListAllService(x=>x.AboutStatus ==true);
            return View(values);
        }
    }
}