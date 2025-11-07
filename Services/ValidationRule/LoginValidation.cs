using System.Data;
using Entities.ViewModel;
using FluentValidation;

namespace Services.ValidationRule
{
    public class LoginValidation : AbstractValidator<LoginViewModel>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Email)
                        .NotEmpty()
                        .WithMessage("E-poçt boş buraxıla bilməz.")
                        .EmailAddress()
                        .WithMessage("Düzgün e-poçt formatı daxil edin.");
            RuleFor(x => x.Password)
                        .NotEmpty().WithMessage("Şifrə boş buraxıla bilməz.")
                        .MinimumLength(5).WithMessage("Şifrə minimum 5 simvol olmalıdır.");
        }
    }
}