using Domain.Models.Validations;
using FluentValidation.Results;

namespace mentoria_embarque_digital.Models;

public class Contact
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public ValidationResult ValidationResult { get; set; } = new();

    private Contact() { }

    public static Contact Create(string email, string phone)
    {
        // Regras de negocio
        Contact contact = new() { Email = email, Phone = phone };
        contact.ValidationResult = new CreateContactValidation().Validate(contact);

        return contact;
    }
}