using System.Linq.Expressions;

namespace ProductManager.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<IQueryable<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}