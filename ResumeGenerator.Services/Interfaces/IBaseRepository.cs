using System.Linq.Expressions;

namespace ResumeGenerator.Services;

public interface IBaseRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = default);
    Task<TEntity?> FindByIdAsync(Guid id, CancellationToken? token = default);
    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    Task SaveChangesAsync(CancellationToken token = default);
}
