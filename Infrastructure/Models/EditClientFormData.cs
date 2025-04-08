using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class EditClientFormData
    {
        [Required]
        public string Id { get; set; } =null!;

        [Required]
        public string ClientName { get; set; } = null!;
        [Required]
        public string ClientEmail { get; set; } = null!;
        [Required]
        public string ClientPhone { get; set; } = null!;
        [Required]
        public string ClientBillingAddress { get; set; } = null!;   
        public IFormFile? ClientImage { get; set; }
     
        public string ClientBillingCity { get; set; } = null!;
        public string? ClientBillingPostalCode { get; set; }
        public string? ClientBillingReference { get; set; }
        public string ClientId { get; set; } = null!;   
    }
}
