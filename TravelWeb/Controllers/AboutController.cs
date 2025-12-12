using DAL.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        private readonly Context context;
        private readonly ITestimonialService _testimonialService;
        private readonly IDestinationService _destinationService;


        public AboutController(ITestimonialService testimonialService, IDestinationService destinationService, Context context)
        {
            _testimonialService = testimonialService;
            _destinationService = destinationService;
            this.context = context;
        }

        public IActionResult Index(int id )
        {
            ViewBag.Customers =_testimonialService.ListAllService().Count();
            ViewBag.Destinations =_destinationService.ListAllService().Count();
            ViewBag.DestinationnwithTours = this.context.Destinations.Include(x=>x.Tours).Where(x=>x.DestinationStatus==true).ToList().Count();
            return View(id);
        }   
    }
}