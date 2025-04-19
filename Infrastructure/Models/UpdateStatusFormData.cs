using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class UpdateStatusFormData
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string StatusName { get; set; } = null!;
}