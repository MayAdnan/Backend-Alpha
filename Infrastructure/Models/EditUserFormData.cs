﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class UpdateUserForm
{
    [Required]
    public string Id { get; set; } = null!;

    public string? Image { get; set; }
    public IFormFile? NewImage { get; set; }


    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;


    public string? PhoneNumber { get; set; }
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }

}