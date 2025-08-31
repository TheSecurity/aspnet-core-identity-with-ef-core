using IdentityDemo.Api.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Api.Models;

public class CreateProjectRequestModel
{
    [Required]
    [MaxLength(FieldLengths.Project.Name)]
    public string Name { get; set; } = null!;

    [MaxLength(FieldLengths.Project.Description)]
    public string? Description { get; set; }
}