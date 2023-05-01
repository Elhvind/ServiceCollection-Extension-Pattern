using Microsoft.Extensions.DependencyInjection;

namespace Foo;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFoo(this IServiceCollection services, Action<FooOptions> options)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(options);

        services.AddScoped<IFooService, FooService>();

        return services;
    }
}
