namespace Bar;

internal sealed class BarRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BarRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Task GetBar(int amount)
    {
        var client = _httpClientFactory.CreateClient("BarClient");
        return Task.CompletedTask;
    }
}
