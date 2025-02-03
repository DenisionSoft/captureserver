using Microsoft.EntityFrameworkCore;
using Notissimus.CaptureServer.Domain.Captures;

namespace Notissimus.CaptureServer.Data.Engine;

public sealed class DataContext : DbContext
{
    public DbSet<Capture> Captures => Set<Capture>();

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}