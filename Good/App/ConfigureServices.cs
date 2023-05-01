using Bar;
using Foo;

namespace App;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddBar(options =>
        {
            options.Amount = config.GetValue<int>("Bar:Amount");
            options.BaseUrl = config.GetValue<string>("Bar:BaseUrl")!;
        });

        services.AddFoo(options =>
        {
            options.Amount = config.GetValue<int>("Foo:Amount");
            options.BaseUrl = config.GetValue<string>("Foo:BaseUrl")!;
        });

        return services;
    }
}
