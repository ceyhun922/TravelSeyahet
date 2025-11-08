using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.Abstract;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.ListAllService();
            return View(values);
        }

        public IActionResult Detail(int id)
        {
            var value =_destinationService.GetFindIdService(id);
            return View(value);
        }
    }
}