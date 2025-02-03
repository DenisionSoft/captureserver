namespace Notissimus.CaptureServer.Application.Captures;

/// <summary>
/// Команда на добавление снимков координат мыши
/// </summary>
/// <param name="Captures">Список снимков</param>
public sealed record AddCapturesCommand(
    IReadOnlyList<CaptureModel> Captures
);
