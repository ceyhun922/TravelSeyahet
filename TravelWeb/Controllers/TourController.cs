

using DAL.Concrete;
using Entities.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class TourController : Controller
    {
        private readonly ITourService _tourService;
        private readonly Context _context;

        public TourController(ITourService tourService, Context context)
        {
            _tourService = tourService;
            _context = context;
        }

      
            public IActionResult Index()
           {
               var values = _tourService.ListAllService();

               if (values == null)
               {
                   values = new List<Tour>();
               }
               return View(values);
           } 
    }
}