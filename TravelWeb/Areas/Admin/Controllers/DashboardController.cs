using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class DashboardController : Controller
    {
       private readonly IWriterService _writerService;
       private readonly ITourService _tourService;
       private readonly IRezervationService _rezervationService;
       private readonly UserManager<Writer> _userManager;

        public DashboardController(IWriterService writerService, ITourService tourService, IRezervationService rezervationService, UserManager<Writer> userManager)
        {
            _writerService = writerService;
            _tourService = tourService;
            _rezervationService = rezervationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users =_writerService.ListAllService().Count();
            var user =await _userManager.GetUserAsync(User);
            var tours=_tourService.ListAllService().Count();
            var rezervations =_rezervationService.ListAllService().Count();
            ViewBag.UserCount =users;
            ViewBag.Image =user?.WriterImage;
            @ViewBag.TourCount =tours;
            @ViewBag.RezervationCount =rezervations;
            
            return View();
        }

       

     
    }
}