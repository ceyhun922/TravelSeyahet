

using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
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
            var values = _tourService.AllToursWithRotasionsService();


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
        public IActionResult PostComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Comments.Add(comment);
                _context.SaveChanges();
            }

            return RedirectToAction("TourDetail", new { id = comment.TourId });
        }


    }
}