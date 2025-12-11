using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]

    public class RotasionController : Controller
    {
        private readonly IRotasionService _rotasionService;

        public RotasionController(IRotasionService rotasionService)
        {
            _rotasionService = rotasionService;
        }

        public IActionResult Index()
        {
            var values =_rotasionService.AllRotasionsWithTourSerice();
            return View(values);
        }
    }
}