
using System.Threading.Tasks;
using Entities.Concrete;
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
        private readonly IContactService _contactService;

        public ContactController(IEmailService emailService, IContactService contactService)
        {
            _emailService = emailService;
            _contactService = contactService;
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
                var contact = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Subject = model.Subject,
                    Message = model.Message
                };

                _contactService.InsertService(contact);


                await _emailService.SendEmailAsync(model.Email, model.Subject, model.Message);


                TempData["success"] = "Mailiz Gönderildi! 24 saat içində sizinlə əlaqə saxlanılacaq";
            }
            return View(model);
        }
    }
}