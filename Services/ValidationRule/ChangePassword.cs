using Entities.Concrete;
using Entities.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Services.ValidationRule
{
    public class ChangePassword : AbstractValidator<ChangePasswordViewModel>
    {
        private readonly UserManager<Writer> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChangePassword(UserManager<Writer> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

            RuleFor(x => x.OldPassword)
                .NotEmpty().WithMessage("Köhnə şifrəni daxil edin")
                .Must(ControlOldPassword).WithMessage("Köhnə şifrə yalnışdır");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Yeni şifrəni daxil edin");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.NewPassword).WithMessage("Şifrələr uyğun deyil");
        }

        private bool ControlOldPassword(string oldPassword)
        {
            if (string.IsNullOrWhiteSpace(oldPassword))
                return false;

            var user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;
            if (user == null)
                return false;

            return _userManager.CheckPasswordAsync(user, oldPassword).Result;
        }
    }
}
