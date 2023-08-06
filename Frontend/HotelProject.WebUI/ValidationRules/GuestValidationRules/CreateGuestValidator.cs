using FluentValidation;
using HotelProject.WebUI.DTOs.GuestDTO;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDTO>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Bos gecilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter olmalı.");
            RuleFor(x => x.SurName).MinimumLength(2).WithMessage("En az 2 karakter olmalı.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("En az 3 karakter olmalı.");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("En fazla 30 karakter olmalı.");
            RuleFor(x => x.SurName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı.");
            RuleFor(x => x.Name).MaximumLength(40).WithMessage("En fazla 40 karakter olmalı.");
        }
    }
}
