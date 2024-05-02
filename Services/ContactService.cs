using FluentValidation.Results;
using mentoria_embarque_digital.DTOs;
using mentoria_embarque_digital.Infra.Repositories;
using mentoria_embarque_digital.Models;

namespace mentoria_embarque_digital.Services;

public class ContactService(IContactRepository contactRepository) : IContactService
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<Contact> Create(ContactDTO contactDTO)
    {
        var domainContact = Contact.Create(contactDTO.Email, contactDTO.Phone);

        var emailAlredyExists = await _contactRepository.EmailAlredyExists(contactDTO.Email);
        if (emailAlredyExists)
        {
            domainContact.ValidationResult.Errors.Add(new ValidationFailure("Contact.Email", "O e-mail já existe!"));
        }

        if (!domainContact.ValidationResult.IsValid)
        {
            return domainContact;
        }

        _contactRepository.Add(domainContact);
        await _contactRepository.SaveChanges();

        return domainContact;
    }
}