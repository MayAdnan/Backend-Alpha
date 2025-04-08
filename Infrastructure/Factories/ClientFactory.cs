using Infrastructure.Data.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories
{
    public class ClientFactory
    {
        public static Client ToModel(ClientEntity entity)
        {
            return entity == null
                ? null!
                : new Client
                {
                    Id = entity.Id,
                    ClientName = entity.ClientName,
                    ClientImage = entity.ClientImage,
                    ClientEmail = entity.ClientEmail,
                    ClientPhone = entity.ClientPhone,

                    ClientInformation = new ClientInformation
                    {
                        Id = entity.ClientInformation.Id,
                        ClientBillingCity = entity.ClientInformation.ClientBillingCity,
                        ClientBillingAddress = entity.ClientInformation.ClientBillingAddress,
                        ClientBillingPostalCode = entity.ClientInformation.ClientBillingPostalCode,
                        ClientBillingReference = entity.ClientInformation.ClientBillingReference,

                    },
                    Projects = entity.Projects.Select(p => new Project
                    {
                        Id = p.Id,
                        ProjectName = p.ProjectName,

                    }).ToList()
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
                        Id = formData.ClientInformationId,
                        ClientBillingCity = formData.ClientBillingCity,
                        ClientBillingAddress = formData.ClientBillingAddress,
                        ClientBillingPostalCode = formData.ClientBillingPostalCode,
                        ClientBillingReference = formData.ClientBillingReference,
                    }
                };
        }
        public static ClientEntity ToEntity(AddClientFormData client)
        {
            return client == null
                ? null!
                : new ClientEntity
                {
                    Id = client.Id,
                    ClientName = client.ClientName,
                    ClientImage = client.ClientImage,
                    ClientEmail = client.ClientEmail,
                    ClientPhone = client.ClientPhone,
                    ClientInformation = new ClientInformationEntity
                    {
                        Id = client.ClientInformation.Id,
                        ClientBillingCity = client.ClientInformation.ClientBillingCity,
                        ClientBillingAddress = client.ClientInformation.ClientBillingAddress,
                        ClientBillingPostalCode = client.ClientInformation.ClientBillingPostalCode,
                        ClientBillingReference = client.ClientInformation.ClientBillingReference,
                    }
                };
        }
    }
}
