using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Notissimus.CaptureServer.Application.Captures;
using Notissimus.CaptureServer.Data.Captures;
using Notissimus.CaptureServer.Data.Engine;
using Notissimus.CaptureServer.Data.Options;

namespace Notissimus.CaptureServer.Data;

public static class ServiceCollectionExtension
{
    /// <summary>
    /// Зарегистрировать базу данных
    /// </summary>
    public static void AddData(this IServiceCollection services)
    {
        AddEngine(services);

        services.AddTransient<ICaptureRepository, CaptureRepository>();
    }

    private static void AddEngine(IServiceCollection services)
    {
        services.AddDatabaseOptions();

        services.AddDbContext<DataContext>((provider, builder) =>
        {
            var providerOptions = provider.GetRequiredService<IOptions<DatabaseProviderOptions>>().Value;
            var connectionOptions = provider.GetRequiredService<IOptions<ConnectionStringsOptions>>().Value;

            switch (providerOptions.Provider)
            {
                case DatabaseProviderOptions.DataProvider.Psql:
                    builder.UseNpgsql(connectionOptions.DbConnection,
                        b => b.MigrationsAssembly("Data.Migrations.Psql"));
                    break;
                default:
                    throw new Exception("База данных не поддерживается");
            }
        });
    }

    private static void AddDatabaseOptions(this IServiceCollection services)
    {
        services.AddOptions<DatabaseProviderOptions>()
            .BindConfiguration(DatabaseProviderOptions.OptionKey)
            .ValidateDataAnnotations();

        services.AddOptions<ConnectionStringsOptions>()
            .BindConfiguration(ConnectionStringsOptions.OptionKey)
            .ValidateDataAnnotations();
    }
}
