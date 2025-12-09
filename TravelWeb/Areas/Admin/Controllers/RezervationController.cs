using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RezervationController : Controller
    {
        private readonly IRezervationService _rezervationService;
        private readonly Context _context;

        public RezervationController(IRezervationService rezervationService, Context context)
        {
            _rezervationService = rezervationService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _rezervationService.ListAllService();
            return View(values);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateStatus([FromBody] UpdateRezStatusViewModel model)
        {
            var rezervation = _context.Rezervations.FirstOrDefault(r => r.RezervationID == model.RezervationId);
            if (rezervation == null) return NotFound();

            rezervation.RezervationStatus = (RezervationStatus)model.Status;
            _context.SaveChanges();

            return Ok(new { Status = rezervation.RezervationStatus });
        }

    }
}