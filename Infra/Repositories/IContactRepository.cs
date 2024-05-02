using mentoria_embarque_digital.Models;

namespace mentoria_embarque_digital.Infra.Repositories;

public interface IContactRepository
{
    void Add(Contact contact);
    Task<bool> EmailAlredyExists(string email);
    Task SaveChanges();
}