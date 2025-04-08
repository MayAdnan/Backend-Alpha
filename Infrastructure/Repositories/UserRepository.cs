using Infrastructure.Data.Contexts;
using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public interface IUserRepository : IBaseRepository<UserEntity>
{
    Task<IEnumerable<UserEntity>> GetAllAsync();
    Task<UserEntity?> GetAsync(Expression<Func<UserEntity, bool>> expression);

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
