

using System.Threading.Tasks;
using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace TravelWeb.Controllers
{

    public class WritterController : Controller
    {
        private readonly UserManager<Writer> _userManager;
        private readonly SignInManager<Writer> _signInManager;
        private readonly ITourService _tourService;
        private readonly IDestinationService _destinationService;
        private readonly IRezervationService _rezervationService;
        private readonly Context _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WritterController(UserManager<Writer> userManager, SignInManager<Writer> signInManager, ITourService tourService, IDestinationService destinationService, Context context, IRezervationService rezervationService, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tourService = tourService;
            _destinationService = destinationService;
            _context = context;
            _rezervationService = rezervationService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult NewRezervations()
        {
            var values =
               _destinationService.AllDestinationSubTourService().ToList();

            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> NewRezervations(RezervationViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Məlumat düzgün deyil.");

            var tour = _tourService.GetFindIdService(model.TourId);

            if (tour == null)
                return BadRequest("Tur tapılmadı.");

            if (model.CountPerson > tour.TourCountLimit)
                return BadRequest($"Bu turda yalnız {tour.TourCountLimit} yer var.");

            double total = tour.TourPrice * model.CountPerson;
            var user = await _userManager.GetUserAsync(User);
            var rez = new Rezervation
            {
                DestinationId = model.DestinationId,
                TourId = model.TourId,
                RezervationCountPerson = model.CountPerson,
                RezervationDate = DateTime.Now.Date,
                RezervationTime = TimeOnly.FromDateTime(DateTime.Now),
                RezervationDescription = model.Description,
                TotalPrice = total,
                RezervationStatus = RezervationStatus.Pending,
                RemainderCapaCity = tour.TourCountLimit - model.CountPerson,
                UserId = user.Id
            };


            _rezervationService.InsertService(rez);

            tour.TourCountLimit -= model.CountPerson;
            _tourService.UpdateService(tour);

            return Ok(new { success = true, message = "Rezervasiya uğurla əlavə edildi!" });
        }

        public async Task<IActionResult> AllRezervatons()
        {
            var user = await _userManager.GetUserAsync(User);
            ViewBag.UserId = user.Id; 

            var result = _rezervationService.GetAllRezervationWithDestinationsService(user.Id);

            return View(result);
        }

        public async Task<IActionResult> FilterRezervation(int status, int userID)
        {
            var rezervation = _rezervationService.GetMyAllRezervationService(userID);
            Console.WriteLine(userID);
            if (status >= 0)
            {
                rezervation = rezervation
                    .Where(x => (int)x.RezervationStatus == status)
                    .ToList();
            }

            return PartialView("_RezervationTable", rezervation);
        }




        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(Writer writer)
        {
            var user = await _userManager.GetUserAsync(User);

            user.UserName = writer.UserName;
            user.Email = writer.Email;
            user.WriterImage = writer.WriterImage;
            user.WriterStatus = writer.WriterStatus;

            var result = await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                ViewBag.Succeeded = "Şifrəniz Uğurla Dəyişdirildi";
                return RedirectToAction("Profile", "Writter");
            }

            foreach (var err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }
            return View(model);
        }



    }
}