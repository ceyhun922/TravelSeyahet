using DAL.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly Context _context;

        public SliderViewComponent(Context context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = _context.Sliders?.Where(x => x.SliderStatus == true).ToList() ?? new List<Slider>();
            return View(sliders);
            
        }
    }
}