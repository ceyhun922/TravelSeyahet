

using System.Threading.Tasks;
using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly IRezervationService _rezervationService;
        private readonly UserManager<Writer> _userManager;
        private readonly ICommentService _commentService;


        public TourController(ITourService tourService, Context context, UserManager<Writer> userManager, ICommentService commentService)
        {
            _tourService = tourService;
            _context = context;
            _userManager = userManager;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult Index(string city)
        {
            var values = _tourService.AllToursWithRotasionsService();

            if (! string.IsNullOrEmpty(city))
            {
                values =values.Where(x=>x.Destination.DestinationCity==city).ToList();
                ViewBag.City = city;
            }


            if (values == null)
            {
                values = new List<Tour>();
            }
            return View(values);
        }

        /* [HttpPost]
        public IActionResult LocationFilter([FromQuery] FilterLocationViewModel model)
        {
            var query =_tourService.AllToursWithRotasionsService().AsQueryable();

            if (! string.IsNullOrWhiteSpace(model.Keyword))
            {
                query =query.Where(x=>x.TourLocaion.Contains(model.Keyword));
            }

        
            return Json(false);
        } */

        public IActionResult TourDetailWritter(int id)
        {
            var tour = _context.Tours?
                      .Include(x => x.Rotasions)
                      .Where(x => x.TourId == id)
                      .ToList();
            return View(tour);

        }
        public IActionResult TourDetail(int id)
        {
            var tour = _tourService.AllToursWithDestinationAndGuideService(id);
            if (tour == null)
            {
                return NotFound("Sehife tapılmadı");
            }

            ViewBag.Comments = _context.Comments
            .Where(c => c.TourId == tour.TourId)
            .ToList();
            ViewBag.CommentCount = _context.Comments
            .Where(c => c.TourId == tour.TourId).Count();

            return View(tour);

        }
        public IActionResult TourWithRotasion(int id)
        {
            var tour = _tourService.AllToursWithRotasionsService(id);

            return View(tour);

        }

        [HttpPost]
        public async Task<IActionResult> PostComment(Comment comment)
        {
            var user =await _userManager.GetUserAsync(User);

                if (user != null)
                {
                    comment.UserId = user.Id;
                    comment.CommentUserName = user.UserName;
                }

                _commentService.InsertService(comment);

            return RedirectToAction("TourDetail", new { id = comment.TourId });
        }



        public IActionResult Tours(int? tourId)
        {
            var tours = _tourService.ListAllService(); 
            ViewBag.SelectedTour = tourId; 
            return View(tours);
        }


        [HttpPost]
        public IActionResult Tours(int tourId, int countPerson, string description)
        {
            var rezervation = new Rezervation
            {
                TourId = tourId,
                RezervationCountPerson = countPerson,
                RezervationDescription = description,
                RezervationDate = DateTime.Now,
                RezervationTime = TimeOnly.FromDateTime(DateTime.Now),
                DestinationId = _tourService.GetFindIdService(tourId).DestinationId ?? 0, 
                TotalPrice = _tourService.GetFindIdService(tourId).TourPrice * countPerson
            };

            _rezervationService.InsertService(rezervation);

            return Json(new { success = true, message = "Rezervasiya əlavə olundu." });
        }


    }
}