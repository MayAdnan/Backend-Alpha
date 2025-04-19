using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public interface IClientService
{
    Task<bool> CreateClientAsync (AddClientFormData formData);
    Task<bool> UpdateClientAsync(EditClientFormData formData);
    Task<bool> DeleteClientAsync(string id);
    Task<IEnumerable<Client>> GetClientsAsync();
    Task<Client> GetClientByIdAsync(string id);
}

public class ClientService(IClientRepository clientRepository) : IClientService
{
    private readonly IClientRepository _clientRepository = clientRepository;

    public async Task<bool> CreateClientAsync(AddClientFormData formData)
    {
        if (formData == null)
            return false;

        var clientEntity = ClientFactory.ToEntity(formData);
        var createResult = await _clientRepository.AddAsync(clientEntity);
        return createResult;

    }
    public async Task<bool> UpdateClientAsync( EditClientFormData formData)
    {
        if (formData == null)
            return false;

        if (!await _clientRepository.ExistsAsync(x => x.Id == formData.Id))
            return false;

        var clientEntity = ClientFactory.ToEntity(formData);
        var updateResult = await _clientRepository.UpdateAsync(clientEntity);
        return updateResult;
    }
    public async Task<bool> DeleteClientAsync(string id)
    {
        var entity = await _clientRepository.GetAsync(x => x.Id == id);
        if (entity == null) return false;
        var deleteResult = await _clientRepository.DeleteAsync(x => x.Id == id);
        return deleteResult;
    }

    public async Task<IEnumerable<Client>> GetClientsAsync()
    {
        var entites = await _clientRepository.GetAllAsync(
            orderByDescending: false,
            sortBy: x => x.ClientName,
            filterBy: null,
            i => i.ClientInformation,
            i => i.Projects);

        var clients = entites.Select(ClientFactory.ToModel);
        return clients;
    }

    public async Task<Client> GetClientByIdAsync(string id)
    {
        var entity = await _clientRepository.GetClientWithDetailsAsync(id);
        if(entity == null) return null!;
        var client = ClientFactory.ToModel(entity);
        return client;

    }

}