using System.Diagnostics;
using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace TravelWeb.Controllers;

public class HomeController : Controller
{
    private readonly Context _context;
    private readonly IDestinationService _destinationService;
    private readonly IGuideService _guideService;
    private readonly ITourService _tourService;
    private readonly ITestimonialService _testimonialService;
    private readonly IRezervationService _rezervationService;
    public HomeController(IDestinationService destinationService, IGuideService guideService, ITourService tourService, ITestimonialService testimonialService, Context context, IRezervationService rezervationService)
    {
        _destinationService = destinationService;
        _guideService = guideService;
        _tourService = tourService;
        _testimonialService = testimonialService;
        _context = context;
        _rezervationService = rezervationService;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {

        ViewBag.TravelCount = _destinationService.ListAllService().Count();
        ViewBag.DestinationCount = _tourService.ListAllService().Count();
        ViewBag.RezervationCount = _rezervationService.ListAllService().Count();
        ViewBag.GuideCount = _guideService.ListAllService().Count();
        ViewBag.PopularTour = _tourService.ListAllService(x => x.TourRaiting == 5);
        ViewBag.Testimontals = _testimonialService.ListAllService();
        ViewBag.LatestTours = _tourService.ListAllService().OrderByDescending(x => x.TourId).TakeLast(5).ToList();

        return View();
    }

    [HttpGet]
    public IActionResult RezervSeach(string city)
    {
          if (string.IsNullOrEmpty(city))
        return RedirectToAction("Index", "Tour", new { city = city });

        return RedirectToAction("Index", "Home");
    }



}
