using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignInFormData
{

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; }

}