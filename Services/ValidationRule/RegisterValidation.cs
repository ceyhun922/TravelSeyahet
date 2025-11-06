using Entities.ViewModel;
using FluentValidation;

namespace Services.ValidationRule
{
    public class RegisterValidation : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.Username)
            .NotEmpty().WithMessage("İstifadəçi adı boş buraxıla bilməz.");

            RuleFor(x => x.Mail)
            .NotEmpty().WithMessage("E-poçt boş buraxıla bilməz.")
            .EmailAddress().WithMessage("Düzgün e-poçt formatı daxil edin.");

            RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Şifrə boş buraxıla bilməz.")
            .MinimumLength(6).WithMessage("Şifrə minimum 6 simvol olmalıdır.");

            RuleFor(x => x.ConfirmPassword)
            .Equal(x => x.Password).WithMessage("Şifrələr eyni olmalıdır.");
        }
    }
}