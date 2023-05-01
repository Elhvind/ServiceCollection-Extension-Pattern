using Microsoft.Extensions.DependencyInjection;

namespace Bar;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBar(this IServiceCollection services, Action<BarOptions> options)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(options);

        services.AddScoped<IBarService, BarService>();

        return services;
    }
}
