namespace BooksStore.Shared.Core.Data;
public interface IGenericRepo<TEntity> : IOrderedQueryable<TEntity> where TEntity : class
{
    public void Add(TEntity entity);
    public Task AddAsync(TEntity entity, CancellationToken ct);
    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct);
    public void Update(TEntity entity);
    public void Remove(TEntity entity);
    public void RemoveRange(IEnumerable<TEntity> entities);
}
