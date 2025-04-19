using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class AddStatusFormData
{
    [Required]
    public string StatusName { get; set; } = null!;
}