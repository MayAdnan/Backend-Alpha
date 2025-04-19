using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? Image { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public UserAddressEntity? Address { get; set; } 
        public virtual ICollection<ProjectEntity> Projects { get; set; } = [];
       
    }
}
