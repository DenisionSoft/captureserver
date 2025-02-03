namespace Notissimus.CaptureServer.Contracts.Captures;

/// <summary>
/// Модель снимка координат мыши
/// </summary>
public sealed class CaptureRequestModel
{
    /// <summary>
    /// Координата X
    /// </summary>
    public int? X { get; set; }

    /// <summary>
    /// Координата Y
    /// </summary>
    public int? Y { get; set; }

    /// <summary>
    /// Время снимка
    /// </summary>
    public DateTimeOffset? CapturedAt { get; set; }
}
