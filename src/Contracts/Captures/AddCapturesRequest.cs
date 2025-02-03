namespace Notissimus.CaptureServer.Contracts.Captures;

/// <summary>
/// Запрос на добавление снимков координат мыши
/// </summary>
public sealed class AddCapturesRequest
{
    /// <summary>
    /// Список снимков координат мыши
    /// </summary>
    public List<CaptureRequestModel> Captures { get; set; } = new();
}
