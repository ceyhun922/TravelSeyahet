using Entities.ViewModel;
using FluentValidation;

namespace Services.ValidationRule
{
    public class ContactValidation : AbstractValidator<ContactViewModel>
    {
        public ContactValidation()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ad boş buraxıla bilməz.");

            RuleFor(x => x.Email)
            .NotEmpty().WithMessage("E-poçt boş buraxıla bilməz.")
            .EmailAddress().WithMessage("Düzgün e-poçt formatı daxil edin.");

            RuleFor(x => x.Subject)
            .NotEmpty().WithMessage("Mövzu boş buraxıla bilməz.");

            RuleFor(x => x.Message)
            .NotEmpty().WithMessage("Mesaj boş buraxıla bilməz.");
        }
    }
}