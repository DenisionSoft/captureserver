using Microsoft.Extensions.DependencyInjection;
using Notissimus.CaptureServer.Application.Captures;

namespace Notissimus.CaptureServer.Application;

public static class ServiceCollectionExtension
{
    /// <summary>
    /// Зарегистрировать сервисы приложения
    /// </summary>
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddTransient<ICaptureService, CaptureService>();
    }
}
