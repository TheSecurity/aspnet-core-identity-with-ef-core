using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Api.Models;

public class CreateProjectRequestModel
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    public string? Description { get; set; }
}