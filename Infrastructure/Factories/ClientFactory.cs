using Infrastructure.Data.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories
{
    public class ClientFactory
    {
        public static Client ToModel(ClientEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity)); // Kontrollera null här

            return entity == null
                ? null!
                : new Client
                {
                    Id = entity.Id,
                    ClientName = entity.ClientName,
                    ClientImage = entity.ClientImage,
                    ClientEmail = entity.ClientEmail,
                    ClientPhone = entity.ClientPhone,
                    ClientInformation = entity.ClientInformation != null
                    ? new ClientInformation
                    {
                        Id = entity.ClientInformation.Id,
                        ClientBillingCity = entity.ClientInformation.ClientBillingCity,
                        ClientBillingAddress = entity.ClientInformation.ClientBillingAddress,
                        ClientBillingPostalCode = entity.ClientInformation.ClientBillingPostalCode,
                        ClientBillingReference = entity.ClientInformation.ClientBillingReference,

                    }
                    :null,

                    Projects = entity.Projects.Select(project => new Project
                    {
                        Id = project.Id,
                        ProjectName = project.ProjectName,
                    }).ToList() ?? new List<Project>()

                };
        }
        public static ClientEntity ToEntity(EditClientFormData formData)
        {
            return formData == null
                ? null!
                : new ClientEntity
                {
                    Id = formData.Id,
                    ClientName = formData.ClientName,
                    ClientImage = formData.ClientImage,
                    ClientEmail = formData.ClientEmail,
                    ClientPhone = formData.ClientPhone,
                    ClientInformation = new ClientInformationEntity
                    {
                        Id = formData.
                        ClientBillingCity = formData.ClientBillingCity,
                        ClientBillingAddress = formData.ClientBillingAddress,
                        ClientBillingPostalCode = formData.ClientBillingPostalCode,
                        ClientBillingReference = formData.ClientBillingReference,
                    }
                };
        }
        public static ClientEntity ToEntity(AddClientFormData clientFormData)
        {
            return clientFormData == null
                ? null!
                : new ClientEntity
                {
                    ClientName = clientFormData.ClientName,
                    ClientImage = clientFormData.ClientImage,
                    ClientEmail = clientFormData.ClientEmail,
                    ClientPhone = clientFormData.ClientPhone,

                    ClientInformation = new ClientInformationEntity
                    {
                        ClientBillingCity = clientFormData.ClientBillingCity,
                        ClientBillingAddress = clientFormData.ClientBillingAddress,
                        ClientBillingPostalCode = clientFormData.ClientBillingPostalCode,
                        ClientBillingReference = clientFormData.ClientBillingReference,
                    }
                };
        }
    }
}
