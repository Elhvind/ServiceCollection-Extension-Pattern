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

    public async Task<FooDTO> GetFoo()
    {
        var id = _config.GetValue<int>("Foo:Id");
        return await _fooRepository.GetFoo(id);
    }
}
