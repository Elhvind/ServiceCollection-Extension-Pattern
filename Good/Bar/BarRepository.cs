namespace Bar;

internal sealed class BarRepository
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BarRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Task<BarDTO> GetBar(int id)
    {
        var client = _httpClientFactory.CreateClient("BarClient");
        var bar = new BarDTO()
        {
            Id = id
        };
        return Task.FromResult(bar);
    }
}
