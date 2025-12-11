
using System.Threading.Tasks;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        private readonly IEmailService _emailService;

        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _emailService.SendEmailAsync(model.Email,model.Subject,model.Message);
                TempData["success"] ="Mailiz Gönderildi! 24 saat içində sizinlə əlaqə saxlanılacaq";
            }
            return View(model);
        }
    }
}