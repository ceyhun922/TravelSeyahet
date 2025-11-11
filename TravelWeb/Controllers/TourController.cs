

using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class TourController : Controller
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        public IActionResult Index()
        {
            var values = _tourService.ListAllService();

            if (values == null)
            {
                values = new List<Tour>();
            }
            return View(values);
        }
    }
}