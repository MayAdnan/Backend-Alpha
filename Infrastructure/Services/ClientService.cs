using Infrastructure.Data.Entities;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public interface IClientService
{
    Task<Client?> CreateClientAsync (AddClientFormData formData);
    Task<Client?> UpdateClientAsync(string id, EditClientFormData formData);
    Task<bool> DeleteClientAsync(string id);
    Task<IEnumerable<Client>> GetClientsAsync();
    Task<Client> GetUserByClientNameAsync(string clientName);
    Task<Client> GetClientByIdAsync(string id);
}

public class ClientService(IClientRepository clientRepository) : IClientService
{
    private readonly IClientRepository _clientRepository = clientRepository;

    public async Task<Client?> CreateClientAsync(AddClientFormData formData)
    {
        var entity = new ClientEntity
        {
            ClientName = formData.ClientName,
            ClientEmail = formData.ClientEmail,
            ClientPhone = formData.ClientPhone,
            ClientImage = formData.ClientImage,
           
        };
        var createdEntity = await _clientRepository.CreateAsync(entity);
        return createdEntity == null ? null! : new Client
        {
            Id = createdEntity.Id,
            ClientName = createdEntity.ClientName,
        };
    }
    public async Task<Client?> UpdateClientAsync(string id, EditClientFormData formData)
    {
        var entity = await _clientRepository.GetAsync(x => x.Id == id);
        if (entity == null) return null;

        entity.ClientName = formData.ClientName;
        entity.ClientEmail = formData.ClientEmail;
        entity.ClientPhone = formData.ClientPhone;
        entity.ClientImage = formData.ClientImage;

        var updateResult = await _clientRepository.UpdateAsync(entity);

        return updateResult ? new Client
        {
            Id = entity.Id,
            ClientName = entity.ClientName,
        } : null;
    }
    public async Task<bool> DeleteClientAsync(string id)
    {
        var entity = await _clientRepository.GetAsync(x => x.Id == id);
        if (entity == null) return false;
        var deleteResult = await _clientRepository.DeleteAsync(entity);
        return deleteResult;
    }

    public async Task<IEnumerable<Client>> GetClientsAsync()
    {
        var entites = await _clientRepository.GetAllAsync(sortBy: x => x.ClientName);
        var clients = entites.Select(entity => new Client
        {
            Id = entity.Id,
            ClientName = entity.ClientName,
        });

        return clients;
    }

    public async Task<Client> GetUserByIdAsync(string id)
    {
        var entity = await _clientRepository.GetAsync(x => x.Id == id);
        return entity == null ? null! : new Client
        {
            Id = entity.Id,
            ClientName = entity.ClientName,
        };
    }

    public async Task<Client> GetUserByClientNameAsync(string clientName)
    {
        var entity = await _clientRepository.GetAsync(x => x.ClientName.Equals(clientName, StringComparison.CurrentCultureIgnoreCase));
        return entity == null ? null! : new Client
        {
            Id = entity.Id,
            ClientName = entity.ClientName,
        };
    }
}