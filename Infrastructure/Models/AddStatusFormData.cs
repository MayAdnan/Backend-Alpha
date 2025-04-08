using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class AddStatusForm
{
    [Required]
    public string StatusName { get; set; } = null!;
}