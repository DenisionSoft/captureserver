using Notissimus.CaptureServer.Domain.Captures;

namespace Notissimus.CaptureServer.Application.Captures;

/// <summary>
/// Репозиторий для работы со снимками координат мыши
/// </summary>
public interface ICaptureRepository : IRepository<Capture>;
