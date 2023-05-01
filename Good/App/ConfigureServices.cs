using Bar;
using Foo;

namespace App;

public static class ConfigureServices
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddBar(options =>
        {
            options.Id = config.GetValue<int>("Bar:Id");
            options.BaseUrl = config.GetValue<string>("Bar:BaseUrl")!;
        });

        services.AddFoo(options =>
        {
            options.Id = config.GetValue<int>("Foo:Id");
            options.BaseUrl = config.GetValue<string>("Foo:BaseUrl")!;
        });

        return services;
    }
}
