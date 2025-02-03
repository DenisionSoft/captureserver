using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notissimus.CaptureServer.Domain.Captures;

namespace Notissimus.CaptureServer.Data.Captures;

internal sealed class CaptureConfiguration : IEntityTypeConfiguration<Capture>
{
    public void Configure(EntityTypeBuilder<Capture> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.X).IsRequired();
        builder.Property(c => c.Y).IsRequired();
        builder.Property(c => c.CapturedAt).IsRequired();
    }
}