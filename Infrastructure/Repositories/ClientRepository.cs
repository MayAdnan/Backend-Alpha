using Infrastructure.Data.Contexts;
using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public interface IClientRepository : IBaseRepository<ClientEntity>
    {
        Task<ClientEntity?> GetClientWithDetailsAsync(string id);
    }
    public class ClientRepository(DataContext context) : BaseRepository<ClientEntity>(context), IClientRepository
    {

        public async Task<ClientEntity?> GetClientWithDetailsAsync(string id)
        {
            return await _context.Clients
                .Include(c => c.ClientInformation)
                .Include(c => c.Projects)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }
}
    
