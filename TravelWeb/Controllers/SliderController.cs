using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class SliderController : Controller
    {
        private readonly Context _context;

        public SliderController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Sliders.ToList();
            return View(values);
        }
    }
}