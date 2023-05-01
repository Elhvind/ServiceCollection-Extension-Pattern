using Bar;
using Foo;

namespace App;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddBar(options =>
        {
            options.Foo = config.GetValue<string>("Bar:Foo")!;
        });

        services.AddFoo(options =>
        {
            options.Bar = config.GetValue<string>("Foo:Bar")!;
        });

        return services;
    }
}
