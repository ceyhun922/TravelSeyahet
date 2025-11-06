

using Entities.Concrete;
using Entities.ViewModel;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.ValidationRule;

namespace TravelWeb.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<Writer> _manager;
        private readonly SignInManager<Writer> _signInManager;

        public RegisterController(UserManager<Writer> manager, SignInManager<Writer> signInManager)
        {
            _manager = manager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            RegisterValidation validation = new RegisterValidation();
            ValidationResult validationResult = validation.Validate(model);

            if (validationResult.IsValid)
            {
               Writer writer = new Writer
                {
                    UserName = model.Username,
                    Email = model.Mail,
                    WriterStatus = true
                };

                var result = await _manager.CreateAsync(writer, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(writer, isPersistent: false);
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(model);
        }

    } 
}