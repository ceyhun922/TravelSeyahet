
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult Index()
        {
            var values =_sliderService.ListAllService();
            return View(values);
        }

        public IActionResult AddNewSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewSlider(Slider slider)
        {
            return View();
        }
    }
}