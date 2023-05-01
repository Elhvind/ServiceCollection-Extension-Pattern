namespace Foo;

public sealed class FooRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    public FooRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Task GetFoo(int amount)
    {
        var client = _httpClientFactory.CreateClient("FooClient");
        return Task.CompletedTask;
    }
}
