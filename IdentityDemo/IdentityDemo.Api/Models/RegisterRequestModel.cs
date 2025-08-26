using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Api.Models;

public class RegisterRequestModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string UserName { get; set; } = null!;

    public int? Age { get; set; }

    [Required]
    [MinLength(9)]
    public string Password { get; set; } = null!;
}