using System.Linq.Expressions;

namespace AccountService.Domain.RepositoryInterfaces;

public interface IRepository<T, TKey>
{
    IEnumerable<T> Get(Expression<Func<T, bool>>? predicate = default);
    Task<T> GetOneAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(TKey id);
    Task<T> AddAsync(T entity);
    Task<bool> AddRangeAsync(IEnumerable<T> entities);
    Task<T> UpdateAsync(TKey id, T entity);
    T Update(TKey id, T entity);
    Task<T> UpdateAsync(Expression<Func<T, bool>> predicate, T entity);
    Task DeleteAsync(TKey id);
    Task DeleteAsync(T entity);
}
