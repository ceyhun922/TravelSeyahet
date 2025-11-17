using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Controllers;

public class HomeController : Controller
{
     private readonly IDestinationService _destinationService;
     private readonly IGuideService _guideService;
    public HomeController(IDestinationService destinationService, IGuideService guideService)
    {
        _destinationService = destinationService;
        _guideService = guideService;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
       
        ViewBag.TravelCount =_destinationService.ListAllService().Count();
        ViewBag.GuideCount =_guideService.ListAllService().Count();
        return View();
    }

}
