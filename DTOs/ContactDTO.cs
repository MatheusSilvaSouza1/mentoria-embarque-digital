using System.ComponentModel.DataAnnotations;

namespace mentoria_embarque_digital.DTOs;

public class ContactDTO
{
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Phone]
    public string Phone { get; set; } = string.Empty;
}