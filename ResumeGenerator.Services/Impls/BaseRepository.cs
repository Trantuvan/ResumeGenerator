using Microsoft.EntityFrameworkCore;
using ResumeGenerator.Core;
using System.Linq.Expressions;

namespace ResumeGenerator.Services;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly ResumeDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(ResumeDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public void Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> FindByIdAsync(Guid id, CancellationToken? token = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync(CancellationToken? token = null)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
