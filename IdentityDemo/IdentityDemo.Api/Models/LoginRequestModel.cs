﻿using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Api.Models;

public class LoginRequestModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(9)]
    public string Password { get; set; } = null!;
}
