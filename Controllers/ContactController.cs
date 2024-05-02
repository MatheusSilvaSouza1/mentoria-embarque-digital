using mentoria_embarque_digital.DTOs;
using mentoria_embarque_digital.Services;
using Microsoft.AspNetCore.Mvc;

namespace mentoria_embarque_digital.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpPost]
    public async Task<IActionResult> Post(ContactDTO contact)
    {
        var result = await _contactService.Create(contact);

        if (result.ValidationResult.IsValid)
        {
            return Created(string.Empty, result.Id);
        }

        return BadRequest(result.ValidationResult);
    }
}
