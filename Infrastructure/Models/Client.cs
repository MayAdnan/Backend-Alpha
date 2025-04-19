namespace Infrastructure.Models;

public class Client
{
    public string Id { get; set; } = null!;
    public string ClientName { get; set; } = null!;
    public string? ClientImage { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public ClientInformation ClientInformation { get; set; } =null!;
    public ICollection<Project>? Projects { get; set; }
}