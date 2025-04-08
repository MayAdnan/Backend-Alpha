using Infrastructure.Data.Contexts;
using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public interface IProjectRepository : IBaseRepository<ProjectEntity>
{
    Task<IEnumerable<ProjectEntity>> GetByIaAsync(string id);
    Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression);
}
public class ProjectRepository(DataContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{

    public async Task<ProjectEntity?> GetByIdAsync(string id)
    {
        return await GetAsync(p => p.Id == id);
    }

    public async Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        var entity = await _dbSet
            .Include(x => x.Client)
            .Include(x => x.User)
            .Include(x => x.Status)
            .FirstOrDefaultAsync(expression);

        return entity;
    }
}