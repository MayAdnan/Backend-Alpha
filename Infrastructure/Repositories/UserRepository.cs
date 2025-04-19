using Infrastructure.Data.Contexts;
using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public interface IUserRepository : IBaseRepository<UserEntity>
{
    Task<IEnumerable<UserEntity>> GetAllAsync();

}
public class UserRepository(DataContext context) : BaseRepository<UserEntity>(context), IUserRepository
{
    async Task<IEnumerable<UserEntity>> IUserRepository.GetAllAsync()
    {
        return await _context.Users
            .Include(u => u.Address)
            .ToListAsync();
    }
}
