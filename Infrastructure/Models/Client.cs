using Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Models;

public class Client
{
    public string Id { get; set; } = null!;
    public string ClientName { get; set; } = null!;
    public IFormFile? ClientImage { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public ClientInformation ClientInformation { get; set; } =null!;
    public ICollection<ProjectEntity>? Projects { get; set; }
}