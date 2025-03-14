using System.Linq.Expressions;
using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Repositories.Implementations;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
  protected readonly ApplicationDbContext _context;
  protected readonly DbSet<TEntity> _dbSet;

  public BaseRepository(ApplicationDbContext context)
  {
    _context = context;
    _dbSet = _context.Set<TEntity>();
  }

  public virtual async Task<TEntity> AddAsync(TEntity entity)
  {
    await _dbSet.AddAsync(entity);
    await _context.SaveChangesAsync();
    return entity;
  }
  public virtual async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
  {
    await _dbSet.AddRangeAsync(entities);
    await _context.SaveChangesAsync();
    return entities;
  }
  public virtual async Task<TEntity?> GetByIdAsync(object id)
  {
    return await _dbSet.FindAsync(id);
  }

  public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
  {
    return await _dbSet.ToListAsync();
  }
  public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
  {
    return await _dbSet.Where(predicate).ToListAsync();
  }
  public virtual async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
  {
    return await _dbSet.FirstOrDefaultAsync(predicate);
  }
  public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
  {
    return await _dbSet.AnyAsync(predicate);
  }


  public virtual async Task UpdateAsync(TEntity entity)
  {
    _dbSet.Update(entity);
    await _context.SaveChangesAsync();
  }
  public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
  {
    _dbSet.UpdateRange(entities);
    await _context.SaveChangesAsync();
  }
  public virtual async Task DeleteAsync(object id)
  {
    var entity = await GetByIdAsync(id);
    if (entity != null)
    {
      _dbSet.Remove(entity);
      await _context.SaveChangesAsync();
    }
  }
  public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
  {
    _dbSet.RemoveRange(entities);
    await _context.SaveChangesAsync();
  }


  public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null)
  {
    if (predicate == null)
    {
      return await _dbSet.CountAsync();
    }
    return await _dbSet.CountAsync(predicate);
  }
  public virtual IQueryable<TEntity> Query()
  {
    return _dbSet.AsQueryable();
  }
}