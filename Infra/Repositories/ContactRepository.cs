using mentoria_embarque_digital.Models;
using Microsoft.EntityFrameworkCore;

namespace mentoria_embarque_digital.Infra.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly Context _context;

    public ContactRepository(Context context)
    {
        _context = context;
    }

    public void Add(Contact contact)
    {
        _context.Contacts.Add(contact);
    }

    public async Task<bool> EmailAlredyExists(string email)
    {
        return await _context.Contacts.AnyAsync(e => e.Email == email);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}