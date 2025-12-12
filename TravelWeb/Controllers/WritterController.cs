
using System.Globalization;
using System.Threading.Tasks;
using DAL.Concrete;
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    [Authorize]

    public class WritterController : Controller
    {
        private readonly UserManager<Writer> _userManager;
        private readonly SignInManager<Writer> _signInManager;
        private readonly ITourService _tourService;
        private readonly IDestinationService _destinationService;
        private readonly IRezervationService _rezervationService;
        private readonly Context _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _env;
        private readonly IWriterService _writerService;


        public WritterController(UserManager<Writer> userManager, SignInManager<Writer> signInManager, ITourService tourService, IDestinationService destinationService, Context context, IRezervationService rezervationService, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env, IWriterService writerService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tourService = tourService;
            _destinationService = destinationService;
            _context = context;
            _rezervationService = rezervationService;
            _httpContextAccessor = httpContextAccessor;
            _env = env;
            _writerService = writerService;
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

            ViewBag.SelectedCity = rez.DestinationId;

            _rezervationService.InsertService(rez);

            tour.TourCountLimit -= model.CountPerson;
            _tourService.UpdateService(tour);

            return Ok(new { success = true, message = "Rezervasiya uğurla əlavə edildi!" });
        }



        [HttpPost]
        public async Task<IActionResult> QuickRezervation(int tourId, int? destinationId, int countPerson)
        {
            var tour = _tourService.GetFindIdService(tourId);
            if (tour == null)
                return BadRequest("Tur tapılmadı.");

            if (countPerson > tour.TourCountLimit)
                return BadRequest($"Bu turda yalnız {tour.TourCountLimit} yer var.");

            var user = await _userManager.GetUserAsync(User);

            var rez = new Rezervation
            {
                DestinationId = destinationId ?? 0,
                TourId = tourId,
                RezervationCountPerson = countPerson,
                RezervationDate = DateTime.Now.Date,
                RezervationTime = TimeOnly.FromDateTime(DateTime.Now),
                RezervationDescription = "Popüler tur rezervasyonu",
                TotalPrice = tour.TourPrice * countPerson,
                RezervationStatus = RezervationStatus.Pending,
                RemainderCapaCity = tour.TourCountLimit - countPerson,
                UserId = user.Id
            };

            _rezervationService.InsertService(rez);

            tour.TourCountLimit -= countPerson;
            _tourService.UpdateService(tour);

            return Ok(new { message = "Rezervasiya uğurla əlavə edildi!" });
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

        public async Task<IActionResult> MyComments()
        {
            var user = await _userManager.GetUserAsync(User);

            var values = _context.Comments.Where(x => x.UserId == user.Id).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Traffichart()
        {
            var all = _rezervationService.ListAllService();
            var total = all.Count();

            if (total == 0)
                return Json(new { approved = 0, pending = 0, cancelled = 0 });

            var approved = all.Count(x => x.RezervationStatus == RezervationStatus.Approved);
            var pending = all.Count(x => x.RezervationStatus == RezervationStatus.Pending);
            var cancelled = all.Count(x => x.RezervationStatus == RezervationStatus.Cancelled);

            var data = new
            {
                approved = (approved * 100) / total,
                pending = (pending * 100) / total,
                cancelled = (cancelled * 100) / total
            };
            Console.WriteLine(data);
            return Json(data);
        }

        public IActionResult TrafficMounth()
        {
            var rezByMonth = _rezervationService.ListAllService()
                      .GroupBy(r => r.RezervationDate.Month)
                      .Select(g => new
                      {
                          Month = g.Key,
                          Count = g.Count()
                      })
                      .OrderBy(x => x.Month)
                      .ToList();

            return Json(rezByMonth);
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Writter");
            }


            var rez = _rezervationService.ListAllService(x => x.UserId == user.Id && x.RezervationStatus == RezervationStatus.Approved).Count();
            var topRez = _context.Tours?.Include(x => x.Guide).Include(x => x.Destination).Include(x => x.Destination).ToList().Take(5);
            ViewBag.RezAmount =_rezervationService.ListAllService(x=>x.RezervationStatus ==RezervationStatus.Approved).Sum(x=>x.TotalPrice);
            ViewBag.RezAmountAvg =Math.Round((decimal)ViewBag.RezAmount * 1.10m);
            ViewBag.TopRez = topRez;
            ViewBag.Rezervations = rez;

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
        public async Task<IActionResult> Profile(Writer writer, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(User);

            if (file != null && file.Length > 0)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                var allowed = new[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" };

                if (!allowed.Contains(extension))
                    return Content("Yalnız .jpg, .png, .jpeg, .svg .webp faylları qebul edilir");

                var FolderPath = Path.Combine(_env.WebRootPath, "uploads");

                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }

                var fileName = Guid.NewGuid() + extension;
                var fullPath = Path.Combine(FolderPath, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                user.WriterImage = "/uploads/" + fileName;

            }

            user.UserName = writer.UserName;
            user.Email = writer.Email;
            user.WriterStatus = writer.WriterStatus;

            var result = await _userManager.UpdateAsync(user);

            return RedirectToAction("Index", "Writter");
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


        public IActionResult Tours(int id)
        {
            var tour = _context.Tours
                               .Include(t => t.Destination)
                               .FirstOrDefault(t => t.TourId == id);

            if (tour == null)
                return NotFound();

            return View(tour);
        }

        [HttpPost]
        public async Task<IActionResult> Tours([FromBody] Rezervation model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Məlumat düzgün deyil." });

            var tour = _tourService.GetFindIdService(model.TourId);
            if (tour == null)
                return BadRequest(new { message = "Tur tapılmadı." });

            if (model.RezervationCountPerson > tour.TourCountLimit)
                return BadRequest(new { message = $"Bu turda yalnız {tour.TourCountLimit} yer var." });

            double total = tour.TourPrice * model.RezervationCountPerson;

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return BadRequest(new { message = "İstifadəçi tapılmadı." });

            var rez = new Rezervation
            {
                DestinationId = model.DestinationId,
                TourId = model.TourId,
                RezervationCountPerson = model.RezervationCountPerson,
                RezervationDate = DateTime.Now.Date,
                RezervationTime = TimeOnly.FromDateTime(DateTime.Now),
                RezervationDescription = model.RezervationDescription,
                TotalPrice = total,
                RezervationStatus = RezervationStatus.Pending,
                RemainderCapaCity = tour.TourCountLimit - model.RezervationCountPerson,
                UserId = user.Id
            };

            _rezervationService.InsertService(rez);

            tour.TourCountLimit -= model.RezervationCountPerson;
            _tourService.UpdateService(tour);

            return Ok(new { success = true, message = "Rezervasiya uğurla əlavə edildi!" });
        }


        [HttpGet("/api/getrezervationformonth")]
        public IActionResult GetRezervationForMonth()
        {
            var rezervasyon = _context.Rezervations.Include(x => x.Tour).Where(x => x.Tour != null).ToList();

            if (!rezervasyon.Any())
                return Json(new { message = "Rezervasiya Tapılmadı" });

            var culture =new CultureInfo("az-AZ");

            var mostRezervation = rezervasyon
                .GroupBy(x => new
                {
                    x.Tour.TourLocaion,
                    Month =x.RezervationDate.Month
                })
                .Select(g => new
                {
                    Location = g.Key.TourLocaion,
                    Month =culture.DateTimeFormat.GetMonthName(g.Key.Month),
                    Count = g.Count(),
                    Amount = g.Sum(x => x.TotalPrice)
                })
                .ToList();
            return Ok(mostRezervation);
        }


    }
}