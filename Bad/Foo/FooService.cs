using Microsoft.Extensions.Configuration;

namespace Foo;

public sealed class FooService : IFooService
{
    private readonly FooRepository _fooRepository;
    private readonly IConfiguration _config;

    public FooService(
        FooRepository fooRepository,
        IConfiguration config)
    {
        _fooRepository = fooRepository;
        _config = config;
    }

    public async Task GetFoo()
    {
        var amount = _config.GetValue<int>("Foo:Amount");
        await _fooRepository.GetFoo(amount);
    }
}
