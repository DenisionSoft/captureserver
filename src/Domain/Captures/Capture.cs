namespace Notissimus.CaptureServer.Domain.Captures;

/// <summary>
/// Снимок координат мыши
/// </summary>
public class Capture : EntityBase
{

    private Capture(
        Guid id,
        DateTimeOffset createdAt,
        int x,
        int y,
        DateTimeOffset capturedAt
    ) : base(id, createdAt)
    {
        X = x;
        Y = y;
        CapturedAt = capturedAt;
    }

    /// <summary>
    /// Координата X
    /// </summary>
    public int X { get; private set; }

    /// <summary>
    /// Координата Y
    /// </summary>
    public int Y { get; private set; }

    /// <summary>
    /// Время снимка
    /// </summary>
    public DateTimeOffset CapturedAt { get; private set; }

    public static Capture Create(
        int x,
        int y,
        DateTimeOffset capturedAt)
    {
        var id = Guid.CreateVersion7();
        var createdAt = DateTimeOffset.UtcNow;

        return new Capture(
            id,
            createdAt,
            x,
            y,
            capturedAt
        );
    }
}