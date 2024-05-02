using mentoria_embarque_digital.DTOs;
using mentoria_embarque_digital.Models;

namespace mentoria_embarque_digital.Services;

public interface IContactService
{
    Task<Contact> Create(ContactDTO contactDTO);
}
