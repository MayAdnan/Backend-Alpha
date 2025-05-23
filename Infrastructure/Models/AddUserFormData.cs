﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class AddUserFormData
{
    public string? ImageFile { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    public string Role { get; set; } = "User";
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
}