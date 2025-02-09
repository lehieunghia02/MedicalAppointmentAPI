using System.Linq.Expressions;

namespace MedicalAppointmentAPI.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
  //Add 
  Task<TEntity> AddAsync(TEntity entity);
  Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

  //Read 
  Task<TEntity> GetByIdAsync(object id);
  Task<IEnumerable<TEntity>> GetAllAsync();
  Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression);
  Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
  Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);

  //Update 
  Task UpdateAsync(TEntity entity);
  Task UpdateRangeAsync(IEnumerable<TEntity> entities);
  //Delete
  Task DeleteAsync(object id);
  Task DeleteRangeAsync(IEnumerable<TEntity> entities);

  // Additional functionality
  Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null);
  IQueryable<TEntity> Query();
}