using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    public class RotasionController : Controller
    {
        private readonly IRotasionService _rotasionService;
        private readonly ITourService _tourService;

        public RotasionController(IRotasionService rotasionService, ITourService tourService)
        {
            _rotasionService = rotasionService;
            _tourService = tourService;
        }

        /*         public IActionResult RotasionDetail()
                {
                    var values =_rotasionService.ListAllService();
                    return View(values);
                } */

        public IActionResult Rotasions(int id)
        {

            var rotasions = _rotasionService
                               .ListAllService()
                               .Where(x => x.TourId == id)
                               .ToList();

            ViewBag.Rotasions = rotasions;

            return View(rotasions);
        }



    }
}