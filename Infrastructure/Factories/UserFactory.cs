using Infrastructure.Data.Entities;
using Infrastructure.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Factories
{
    public class UserFactory
    {
        public static User ToModel(UserEntity entity, string role)
        {
            return entity == null
                ? null!
                : new User
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email ?? string.Empty,
                    Image = entity.Image,
                    Phone = entity.PhoneNumber,
                    Address = entity.Address?.StreetName,
                    PostalCode = entity.Address?.PostalCode,
                    City = entity.Address?.City,
                    Role = role
                };
        }

        public static UserEntity ToEntity(EditUserFormData formData)
        {
            return formData == null
                ? null!
                : new UserEntity
                {
                    Id = formData.Id,
                    FirstName = formData.FirstName,
                    LastName = formData.LastName,
                    Email = formData.Email,
                    Image = formData.Image,
                    PhoneNumber = formData.PhoneNumber,
                    Address = new UserAddressEntity
                    {
                        StreetName = formData.Address,
                        PostalCode = formData.PostalCode,
                        City = formData.City
                    }
                };
        }
        public static UserEntity ToEntity(AddUserFormData formData)
        {
            return formData == null
                ? null!
                : new UserEntity
                {
                    FirstName = formData.FirstName,
                    LastName = formData.LastName,
                    Image = formData.ImageFile,
                    Email = formData.Email,
                    PhoneNumber = formData.PhoneNumber,
                    Address = new UserAddressEntity
                    {
                        StreetName = formData.Address,
                        PostalCode = formData.PostalCode,
                        City = formData.City
                    }
                };
        }
    }
}
