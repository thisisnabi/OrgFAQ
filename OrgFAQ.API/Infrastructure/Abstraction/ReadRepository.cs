namespace OrgFAQ.API.Infrastructure.Abstraction;

public class ReadRepository<TEntity> : IReadRepository<TEntity>
    where TEntity : EntityBase
{
    protected readonly DbContext _dbContext;

    public ReadRepository(DbContext dbContext)
        => _dbContext = dbContext;

    public virtual async Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        => await _dbContext
            .Set<TEntity>()
            .AnyAsync(cancellationToken);

    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
        => await _dbContext
            .Set<TEntity>()
            .CountAsync(cancellationToken);

    public virtual async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        => await _dbContext
            .Set<TEntity>()
            .FindAsync(new object[] { id }, cancellationToken: cancellationToken);

    public virtual async Task<List<TEntity>?> ListAsync(CancellationToken cancellationToken = default)
        => await _dbContext
            .Set<TEntity>()
            .ToListAsync(cancellationToken);

    public virtual async Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        => await _dbContext
            .Set<TEntity>()
            .Where(predicate)
            .ToListAsync(cancellationToken);
}