using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class GuidesViewComponent : ViewComponent
    {
        private readonly IGuideService _guideService;

        public GuidesViewComponent(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =_guideService.ListAllService(x=>x.GuideStatus ==true).Take(4).ToList(); ;
            return View(values);
        }
    }
}