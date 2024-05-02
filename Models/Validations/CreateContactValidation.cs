using FluentValidation;
using mentoria_embarque_digital.Models;

namespace Domain.Models.Validations;

public class CreateContactValidation : AbstractValidator<Contact>
{
    public CreateContactValidation()
    {
        RuleFor(e => e.Email)
            .EmailAddress()
            .NotEmpty()
            .NotNull();

        RuleFor(e => e.Phone.Length)
            .GreaterThanOrEqualTo(10)
            .LessThan(11)
            .NotEmpty()
            .NotNull();
    }
}