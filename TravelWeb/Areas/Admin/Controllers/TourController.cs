using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class TourController : Controller
    {
        private readonly ITourService _tourService;
        private readonly IDestinationService _destinationService;
        private readonly IGuideService _guideService;
        private readonly IWebHostEnvironment _env;

        public TourController(ITourService tourService, IDestinationService destinationService, IGuideService guideService, IWebHostEnvironment env)
        {
            _tourService = tourService;
            _destinationService = destinationService;
            _guideService = guideService;
            _env = env;
        }

        public IActionResult Index()
        {
            var values = _tourService.AllToursWithRotasionsService();


            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewTour()
        {

            var tours = new SelectList(_destinationService.ListAllService(), "DestinationId", "DestinationCity");
            var guides = new SelectList(_guideService.ListAllService(), "GuideID", "GuideName");


            ViewBag.Tours = tours;
            ViewBag.Guides = guides;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewTour(Tour tour, IFormFile file)
        {

            ModelState.Remove("DestinationId");
            ModelState.Remove("GuideID");

            if (file != null && file.Length > 0)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                var allowed = new[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" };

                if (!allowed.Contains(extension))
                {
                    return Content("Desteklenmeyen Fayl");
                }

                var FolderPath = Path.Combine(_env.WebRootPath, "tourImages");
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }

                var fileName = Guid.NewGuid() + extension;
                var fullPath = Path.Combine(FolderPath, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                tour.TourImage = "/tourImages/" + fileName;

            }

            if (!ModelState.IsValid)
            {
                ViewBag.Tours = new SelectList(_destinationService.ListAllService(), "DestinationId", "DestinationCity");
                ViewBag.Guides = new SelectList(_guideService.ListAllService(), "GuideID", "GuideName");

                return View(tour);
            }



            if (tour.GuideID == null || tour.GuideID == 0)
                return BadRequest("Guide seçilməyib.");

            if (tour.DestinationId == null || tour.DestinationId == 0)
                return BadRequest("Destination seçilməyib.");

            if (tour.TestimonialID == null || tour.TestimonialID == 0)
            {
                tour.TestimonialID = null;
            }


            _tourService.InsertService(tour);
            TempData["success"] = "Elave Edildi";

            return RedirectToAction(nameof(Index), new { Area = "Admin" });
        }
    }
}