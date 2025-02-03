namespace Notissimus.CaptureServer.Application.Captures;

/// <summary>
/// Сервис для работы со сниками координат мыши
/// </summary>
public interface ICaptureService
{
    Task AddCapturesAsync(AddCapturesCommand command, CancellationToken cancellationToken = default);
}