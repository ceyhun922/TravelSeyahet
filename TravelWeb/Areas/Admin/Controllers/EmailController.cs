using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class EmailController : Controller
    {
        private readonly IContactService _contactService;

        public EmailController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.ListAllService(x =>x.ContactStatus ==false);
            return View(values);
        }
    }
}