using Notissimus.CaptureServer.Application.Captures;
using Notissimus.CaptureServer.Data.Engine;
using Notissimus.CaptureServer.Domain.Captures;

namespace Notissimus.CaptureServer.Data.Captures;

internal sealed class CaptureRepository : ICaptureRepository
{
    private readonly DataContext dbContext;

    public CaptureRepository(DataContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task AddRangeAsync(
        IReadOnlyList<Capture> captures,
        CancellationToken cancellationToken)
    {
        await dbContext.Captures.AddRangeAsync(captures, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}