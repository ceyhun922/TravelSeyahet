using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]

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
                TempData["warning"] = "Boş ola bilmez";
            }

            var existsCity = _destinationService.ListAllService().FirstOrDefault(x => x.DestinationCity == destination.DestinationCity);

            if (existsCity != null)
            {
                TempData["error"] = "Bu qeyd artıq mövcuddur";

                return View(destination);
            }

            TempData["success"] = "Elave Edildi";
            _destinationService.InsertService(destination);

            return RedirectToAction(nameof(Index), new { area = "Admin" });

        }

        [HttpGet]
        public IActionResult UpdateCity(int id)
        {
            var value = _destinationService.GetFindIdService(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCity()
        {
            return RedirectToAction(nameof(Index), new { area = "Admin" });
        }


        [HttpPost]
        public IActionResult StatusToogle([FromBody] RequestStatusDTO request)
        {
            var destination =_destinationService.GetFindIdService(request.Id);

            if(destination == null)
                return Json(new {success =false});

            destination.DestinationStatus =!destination.DestinationStatus;
            _destinationService.UpdateService(destination);

            return Json(new {success =true, status =destination.DestinationStatus});
        }



    }
}