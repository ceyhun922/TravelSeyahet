using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            var values = _destinationService.ListAllService();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewCity()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewCity(Destination destination)
        {
            if (!ModelState.IsValid)
            {
                return View(destination);
            }

            if (string.IsNullOrEmpty(destination.DestinationCity))
            {
                TempData["warning"]="Boş ola bilmez";
            }

            var existsCity = _destinationService.ListAllService().FirstOrDefault(x => x.DestinationCity == destination.DestinationCity);

            if (existsCity != null)
            {
                TempData["error"]="Bu qeyd artıq mövcuddur";

                return View(destination);
            }

            if (true)
            {
                
            }

            TempData["success"]="Elave Edildi";
            _destinationService.InsertService(destination);

            return RedirectToAction(nameof(Index), new { area = "Admin" });

        }
    }
}