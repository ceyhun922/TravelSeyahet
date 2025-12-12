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
    public HomeController(IDestinationService destinationService, IGuideService guideService, ITourService tourService, ITestimonialService testimonialService, Context context)
    {
        _destinationService = destinationService;
        _guideService = guideService;
        _tourService = tourService;
        _testimonialService = testimonialService;
        _context = context;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {

        ViewBag.TravelCount = _destinationService.ListAllService().Count();
        ViewBag.GuideCount = _guideService.ListAllService().Count();
        ViewBag.PopularTour = _tourService.ListAllService(x => x.TourRaiting == 5);
        ViewBag.Testimontals = _testimonialService.ListAllService();
        ViewBag.LatestTours = _tourService.ListAllService().OrderByDescending(x => x.TourId).TakeLast(5).ToList();

        return View();
    }

    [HttpPost]
    public IActionResult RezervSeach(RezerFormViewModel model)
    {
        if (string.IsNullOrEmpty(model.SelectedDestination))
            return RedirectToAction("Index", "Home"); 

        return RedirectToAction("Index", "Tour", new { city = model.SelectedDestination }); 
    }




}
