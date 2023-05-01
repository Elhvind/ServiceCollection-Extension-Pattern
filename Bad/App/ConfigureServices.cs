using Bar.Interfaces;
using Bar.Services;
using Foo.Interfaces;
using Foo.Services;

namespace App;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBarService, BarService>();
        services.AddScoped<IFooService, FooService>();

        return services;
    }
}
