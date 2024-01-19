using BooksStore.Data.AppContext;
using BooksStore.Shared.Core.Data;
using BooksStore.Shared.Core.Entities;

namespace BooksStore.Data.Repository;
public class GenericRepo<TEntity> : BaseEntityQueryable<TEntity>, IGenericRepo<TEntity> where TEntity : class, IEntity
{
    public GenericRepo(BookDbContext dbContext) : base(dbContext.Set<TEntity>()) { }

    public void Add(TEntity entity) => _entity.Add(entity);

    public async Task AddAsync(TEntity entity, CancellationToken ct) => await _entity.AddAsync(entity, ct);

    public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct) => await _entity.AddRangeAsync(entities, ct);

    public void Remove(TEntity entity) => _entity.Remove(entity);

    public void RemoveRange(IEnumerable<TEntity> entities) => _entity.RemoveRange(entities);

    public void Update(TEntity entity) => _entity.Update(entity);
}
