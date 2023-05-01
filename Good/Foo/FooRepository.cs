namespace Foo;

internal sealed class FooRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    public FooRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Task<FooDTO> GetFoo(int id)
    {
        var client = _httpClientFactory.CreateClient("FooClient");
        var foo = new FooDTO()
        {
            Id = id
        };
        return Task.FromResult(foo);
    }
}
