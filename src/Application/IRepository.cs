namespace Notissimus.CaptureServer.Application;

public interface IRepository<TEntity>
{
    Task AddRangeAsync(IReadOnlyList<TEntity> entities, CancellationToken cancellationToken = default);
}