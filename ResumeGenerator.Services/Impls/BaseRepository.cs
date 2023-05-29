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
        _dbSet.Add(entity);
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        _dbSet.AddRange(entities);
    }

    public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null)
    {
        return _dbSet.WhereIf(predicate is not null, predicate!);
    }

    public async Task<TEntity?> FindByIdAsync(Guid id, CancellationToken? token = null)
    {
        return await _dbSet.FindAsync(id, token);
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public async Task SaveChangesAsync(CancellationToken token = default)
    {
        await _context.SaveChangesAsync(token);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }
}
