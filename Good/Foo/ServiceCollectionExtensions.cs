using Microsoft.Extensions.DependencyInjection;

namespace Foo;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds required Foo services.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> that Foo services are added to.</param>
    /// <param name="options">The Foo services options.</param>
    /// <returns>The <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddFoo(this IServiceCollection services, Action<FooOptions> options)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(options);

        var settings = new FooOptions();
        options(settings);

        ArgumentException.ThrowIfNullOrEmpty(settings.BaseUrl);

        if (settings.Id <= 0)
            throw new ArgumentException("ID must be a possitive number");

        if (!Uri.TryCreate(settings.BaseUrl, UriKind.Absolute, out var baseUrl))
            throw new ArgumentException("Invalid base url");

        services.AddScoped<IFooService, FooService>();
        services.AddScoped<FooRepository>();

        services.AddHttpClient("FooClient", client =>
        {
            client.BaseAddress = baseUrl;
        });

        return services;
    }
}
