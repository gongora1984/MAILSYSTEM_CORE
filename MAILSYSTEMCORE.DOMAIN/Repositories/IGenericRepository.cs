using System.Linq.Expressions;

namespace MAILSYSTEMCORE.DOMAIN.Repositories;

public interface IGenericRepository<T>
    where T : class
{
    Task<bool> Add(T entity, CancellationToken cancellationToken = default);

    Task<bool> AddRange(IEnumerable<T> entities, CancellationToken cancellationToken = default);

    Task<T?> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsUniqueAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    void Update(T entity);

    void UpdateRange(IEnumerable<T> entities);

    void Remove(T entity);

    void RemoveRange(IEnumerable<T> entities);
}
