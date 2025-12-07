using System.Globalization;
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
        private readonly ICommentService _commentService;

        public DashboardController(IWriterService writerService, ITourService tourService, IRezervationService rezervationService, UserManager<Writer> userManager, ICommentService commentService)
        {
            _writerService = writerService;
            _tourService = tourService;
            _rezervationService = rezervationService;
            _userManager = userManager;
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            var comments = _commentService.ListAllService().Take(3).ToList();
            @ViewBag.Comments = comments;
            var users = _writerService.ListAllService().Count();
            var user = await _userManager.GetUserAsync(User);
            var tours = _tourService.ListAllService().Count();
            var rezervations = _rezervationService.ListAllService().Count();
            

            ViewBag.UserCount = users;
            ViewBag.Image = user?.WriterImage;
            @ViewBag.TourCount = tours;
            @ViewBag.RezervationCount = rezervations;

            return View();
        }

[HttpGet]
public IActionResult GetMonthlyStats()
{
    var rezervations = _rezervationService.ListAllService();

    // Boş liste dönerse: []
    if (rezervations == null || !rezervations.Any())
        return Json(Array.Empty<object>());

    var culture = new CultureInfo("AZ-az");

    var monthlyData = rezervations
        .Where(r => r.RezervationDate != null) 
        .GroupBy(r => r.RezervationDate.Month)
        .Select(g => new
        {
            MonthNumber = g.Key,
            Month = culture.DateTimeFormat.GetMonthName(g.Key),
            Count = g.Count()
        })
        .OrderBy(x => x.MonthNumber)
        .Select(x => new
        {
            x.Month,
            x.Count
        })
        .ToList();

    return Json(monthlyData);
}



    }
}