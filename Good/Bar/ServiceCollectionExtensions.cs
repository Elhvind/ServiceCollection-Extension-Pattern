using Microsoft.Extensions.DependencyInjection;

namespace Bar;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds required Bar services.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> that Bar services are added to.</param>
    /// <param name="options">The Bar services options.</param>
    /// <returns>The <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddBar(this IServiceCollection services, Action<BarOptions> options)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(options);

        var settings = new BarOptions();
        options(settings);

        ArgumentException.ThrowIfNullOrEmpty(settings.BaseUrl);

        if (settings.Id <= 0)
            throw new ArgumentException("ID must be a possitive number");

        if (!Uri.TryCreate(settings.BaseUrl, UriKind.Absolute, out var baseUrl))
            throw new ArgumentException("Invalid base url");

        services.AddScoped<IBarService, BarService>();
        services.AddScoped<BarRepository>();

        services.AddHttpClient("BarClient", client =>
        {
            client.BaseAddress = baseUrl;
        });

        return services;
    }
}
