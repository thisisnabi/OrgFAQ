namespace OrgFAQ.API.Infrastructure.Abstraction;

public class Repository<TEntity> : ReadRepository<TEntity>, IRepository<TEntity>
    where TEntity : EntityBase
{
    public Repository(DbContext dbContext) : base(dbContext) { }
   
    public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        => (await _dbContext
                   .Set<TEntity>()
                   .AddAsync(entity, cancellationToken))
                   .Entity;

    public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        => await Task.Run(() =>
            _dbContext.Set<TEntity>().Update(entity).Entity,
                cancellationToken);

    public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        => await Task.Run(() =>
            _dbContext.Set<TEntity>().Remove(entity),
                cancellationToken);

    public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        => await Task.Run(() =>
            _dbContext.Set<TEntity>().RemoveRange(entities),
                cancellationToken);
}