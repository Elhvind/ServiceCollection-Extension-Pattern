using Microsoft.Extensions.Options;

namespace Foo;

internal sealed class FooService : IFooService
{
    private readonly FooRepository _fooRepository;
    private readonly FooOptions _options;

    public FooService(
        FooRepository fooRepository,
        IOptions<FooOptions> options)
    {
        _fooRepository = fooRepository;
        _options = options.Value;
    }

    public async Task<FooDTO> GetFoo()
    {
        var amount = _options.Id;
        return await _fooRepository.GetFoo(amount);
    }
}
