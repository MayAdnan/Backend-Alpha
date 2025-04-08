using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities
{
    public class ClientEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string ClientName { get; set; } = null!;
        public string? ClientImage { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientPhone { get; set; }

        public virtual ICollection<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();
        public virtual ClientInformationEntity ClientInformation { get; set; } = null!;
    }
}
