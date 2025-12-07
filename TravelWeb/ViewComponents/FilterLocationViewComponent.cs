using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class FilterLocationViewComponent : ViewComponent
    {
        private readonly ITourService _tourService;

        public FilterLocationViewComponent(ITourService tourService)
        {
            _tourService = tourService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
/*           var values = _tourService.AllToursWithRotasionsService().Select(x=>x.TourLocaion).Distinct().ToList();
 */            return View();
        }
    }
}