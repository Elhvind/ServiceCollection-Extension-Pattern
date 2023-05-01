using Bar;
using Foo;

namespace App;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IBarService, BarService>();
        services.AddScoped<IFooService, FooService>();
        services.AddScoped<FooRepository>();
        services.AddScoped<BarRepository>();
        services.AddHttpClient("FooClient", client =>
        {
            client.BaseAddress = new Uri(config.GetValue<string>("Foo:BaseUrl")!);
        });
        services.AddHttpClient("BarClient", client =>
        {
            client.BaseAddress = new Uri(config.GetValue<string>("Bar:BaseUrl")!);
        });

        return services;
    }
}
