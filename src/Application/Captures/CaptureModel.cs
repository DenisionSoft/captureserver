namespace Notissimus.CaptureServer.Application.Captures;

/// <summary>
/// Снимок координат мыши
/// </summary>
/// <param name="X">Координата X</param>
/// <param name="Y">Координата Y</param>
/// <param name="CapturedAt">Время снятия снимка</param>
public record CaptureModel(
    int X,
    int Y,
    DateTimeOffset CapturedAt
);
